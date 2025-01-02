public class Program
{
    public void SearchForString(string folderPath, string searchString)
    {
        if (!Directory.Exists(folderPath))
        {
            Console.WriteLine("Folder not found.");
            return;
        }

        string[] files = Directory.GetFiles(folderPath);

        foreach (string file in files)
        {
            try
            {
                string fileContents = File.ReadAllText(file);

                if (fileContents.Contains(searchString))
                {
                    Console.WriteLine($"Present:{Path.GetFileName(file)}");
                }
                else
                {
                    Console.WriteLine($"Absent:{Path.GetFileName(file)}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading file {Path.GetFileName(file)}: {ex.Message}");
            }
        }
    }

    public static void Main(string[] args)
    {
        Program finder = new Program();
        finder.SearchForString(@"C:\Development\repository", "Test");
    }
}