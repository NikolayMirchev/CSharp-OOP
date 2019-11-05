using _02.GraphicEditor.Models.Interfaces;

namespace _02.GraphicEditor.Core
{
    public class GraphicEditor
    {
        public void DrawShape(IShape shape)
        {
            shape.Draw();
        }
    }
}
