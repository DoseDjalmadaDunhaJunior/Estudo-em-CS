namespace Tipos
{
    /// <summary>
    /// Essa classe obrigatoriamente recebe X e Y
    /// virando algo como um tipo com 2 valores e ambos do tipo int
    /// </summary>
    public class Point
    {
        public int X { get; }
        public int Y { get; }

        public Point(int x, int y) => (X, Y) = (x, y);

    }
}
