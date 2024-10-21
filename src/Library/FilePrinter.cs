using System.IO;

namespace Full_GRASP_And_SOLID
{
    public class FilePrinter : IPrinter
    {
        public void PrintRecipe(IPrinteable printeableRecipe)
        {
            File.WriteAllText("Recipe.txt", printeableRecipe.GetTextToPrint());
        }
    }
}