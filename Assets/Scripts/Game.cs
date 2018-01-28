using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Game
{
    public Map Map;
    public Matrix GetMatrix()
    {
        Matrix matrix = new Matrix(15,15,new Char('H', Color.green, Color.red));
        matrix.PrintLine("Мастиры сасут",1,1,Color.black, Color.green);
        matrix.PrintLine("Нупские саветы",1,3,Color.black, Color.green);
        matrix.PrintLine("Пыщ лучемет",1,5,Color.black, Color.green);
        return matrix;
    }

}
