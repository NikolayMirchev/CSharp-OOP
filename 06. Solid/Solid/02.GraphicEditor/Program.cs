using _02.GraphicEditor.Models;

namespace _02.GraphicEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            GraphicEditor graphicEditor = new GraphicEditor();
            graphicEditor.DrawShape(new Circle());
            graphicEditor.DrawShape(new Square());
            graphicEditor.DrawShape(new Rectangle());

        }
    }
}
