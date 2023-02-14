
class CopyFileProgram
{
    static void Main(string[] args)
    {
        string pathFrom = args[0]; //@"C:\Users\home\source\repos\CopyFileSampleTask\sourceFolder";
        string pathTo = args[1]; //@"C:\Users\home\source\repos\CopyFileSampleTask\destFolder";


        CopyFilesRecursively(pathFrom, pathTo);
    }


    private static void CopyFilesRecursively(string pathFrom, string pathTo)
    {

        //creating same folders in destination path
        foreach (string dirPath in Directory.GetDirectories(pathFrom, "*", SearchOption.AllDirectories))
        {
            Directory.CreateDirectory(dirPath.Replace(pathFrom, pathTo));
        }

        //copying files to created folders
        foreach (string newPath in Directory.GetFiles(pathFrom, "*.*", SearchOption.AllDirectories))
        {
            File.Copy(newPath, newPath.Replace(pathFrom, pathTo), true);
        }

    }

    //path of exe
    //cd source\repos\CopyFileSampleTask\bin\Debug\net7.0

    //call with arguments
    //CopyFileSampleTask "C:\Users\home\source\repos\CopyFileSampleTask\sourceFolder" "C:\Users\home\source\repos\CopyFileSampleTask\destFolder"
}