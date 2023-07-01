using System.CommandLine;
using System.Threading.Tasks;

namespace SqlDataExtractor;

public class Program
{
    public static async Task<int> Main(string[] args)
    {
        var appCommand = new RootCommand("An application for extracting data from SQL-based databases.");
        return await appCommand.InvokeAsync(args);
    }

}
