using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public struct Char
{

    public Char( char glyph, Color color, Color background)
    {
        Glygh = glyph;
        Color = color;
        Background = background;
    }
    public char Glygh;
    public Color Color;
    public Color Background;

    static Char Overlap(Char a, Char b)
    {
        return new Char();
    }
}