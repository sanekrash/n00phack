using UnityEngine;
using UnityEngine.UI;


public class Terminal : MonoBehaviour
{
    [SerializeField] private GameObject _charPrefab;
    [SerializeField] [Multiline] private string _text;
    private GridLayoutGroup _layout;
    private int _w, _h;
    private CharController[ /*x*/][ /*y*/] _matrix;

    /*
        *[text] - bold
        ~[text] - strike
        _[text] - underline
        @[text] - inv color 
        `* `~ `_ `` `[ `] `' - escaped characters
        `n        - new line
        `3x[text] - texttexttext
        `4f[text] - foreground color
        `4b[text] - background color
        
        input files:
        'green' = `3
        'red' = `4
        'elf' = 'green'f@
    */

    private void Awake()
    {
        The.Terminal = this;
        The.Game = new Game();
       
    }


    private void Update()
    {
        Show(The.Game.GetMatrix());
    }


    private void Resize(int w, int h)
    {
        if (w == _w && h == _h) return;

        foreach (Transform child in transform) Destroy(child.gameObject);

        _layout = GetComponent<GridLayoutGroup>();
        _layout.constraintCount = w;

        _matrix = new CharController[w][];
        for (int x = 0; x < w; x++) _matrix[x] = new CharController[h];

        for (int x = 0; x < w; x++)
        for (int y = 0; y < h; y++)
        {
            var ch = Instantiate(_charPrefab, transform, false).GetComponent<CharController>();
            ch.Background = Color.black;
            ch.Color = Color.green;
            ch.Glyph = (char) (x + y * w);
            _matrix[x][y] = ch;
        }
    }



    public void Show(Matrix matrix)
    {

        var w = matrix.Widht;
        var h = matrix.Height;
        Resize(w, h);
        for (int x = 0; x < w; x++)
        for (int y = 0; y < h; y++)
        {
            _matrix[x][y].Background = matrix[x, y].Background;
            _matrix[x][y].Color = matrix[x, y].Color;
            _matrix[x][y].Glyph = matrix[x, y].Glygh; 
        }

    }
}