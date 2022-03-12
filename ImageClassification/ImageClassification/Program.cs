using ConsoleApp;
using AConfig;
using NeoCortexApi.Encoders;
using NeoCortexApi.Network;
using NeoCortexApi.Utility;


void execute(string inp,string monthName,int idx)
{
    CortexNetworkContext ctx = new CortexNetworkContext();
    DateTimeOffset now = DateTimeOffset.Now;
    Dictionary<string, Dictionary<string, object>> encoderSettings = new Dictionary<string, Dictionary<string, object>>();
    encoderSettings.Add("DateTimeEncoder", new Dictionary<string, object>()
        {
            { "W", 21},
            { "N", 1024},
            { "MinVal", now.AddYears(-20)},
            { "MaxVal", now},
            { "Periodic", false},
            { "Name", "DateTimeEncoder"},
            { "ClipInput", false},
            { "Padding", 5},
        });
    DateTimeEncoder encoder = new DateTimeEncoder(encoderSettings, DateTimeEncoder.Precision.Days);
    int[] result = encoder.Encode(DateTimeOffset.Parse(inp.ToString()));
    //Debug.WriteLine(NeoCortexApi.Helpers.StringifyVector(result));
    //Debug.WriteLine(NeoCortexApi.Helpers.StringifyVector(expectedOutput));
    int[,] twoDimenArray = ArrayUtils.Make2DArray<int>(result, 32, 32);
    int[,] twoDimArray = ArrayUtils.Transpose(twoDimenArray);
    NeoCortex.NeoCortexUtils.DrawBitmap(twoDimArray, 1024, 1024, $"DateTime_out_{inp.ToString().Replace("/", "-").Replace(":", "-")}_32x32-N-{encoderSettings["DateTimeEncoder"]["N"]}-W-{encoderSettings["DateTimeEncoder"]["W"]}.png",monthName,idx);
}

string[] monthName = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
// Getting the list of args from the command line
string inp;

for (int i = 0; i < 4; i++)
{

    Console.WriteLine("Please give Date & Time input for " + monthName[i]);
    for(int j= 0; j < 4; j++)
    {

        inp = Console.ReadLine();
        execute(inp,monthName[i],j+1);
    }
}

// Assert.IsTrue(result.SequenceEqual(expectedOutput));

//save files into input folder

//helper class method call to show in the console 


ArgsConfig config = new ArgsConfig(args);

Experiment ex1 = new Experiment(config);
ex1.run();
