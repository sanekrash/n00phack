using UnityEngine;
using UnityEngine.UI;

public class CharController : MonoBehaviour
{
    Image _image;
    Text _text;
    private char _glyph;
    private Color _color;
    private Color _background;

    private void Awake()
    {
        _text = GetComponentInChildren<Text>();
        _image = GetComponentInChildren<Image>();
        Glyph = '1';
        Color = Color.red;
        Background = Color.black;
    }

    public char Glyph
    {
        get { return _glyph; }
        set
        {
            _glyph = value;
            _text.text = value.ToString();
        }
    }

    public Color Color
    {
        get { return _color; }
        set
        {
            _color = value;
            _text.color = value;
        }
    }

    public Color Background
    {
        get { return _background; }
        set
        {
            _background = value;
            _image.color = value;
        }
    }
}