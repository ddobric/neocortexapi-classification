using ConsoleApp;
using AConfig;
using NeoCortexApi.Encoders;
using NeoCortexApi.Network;
using NeoCortexApi.Utility;

// Getting the list of args from the command line
Object input = "05/07/2011 21:58:07";
CortexNetworkContext ctx = new CortexNetworkContext();
DateTimeOffset now = DateTimeOffset.Now;
Dictionary<string, Dictionary<string, object>> encoderSettings = new Dictionary<string, Dictionary<string, object>>();
encoderSettings.Add("DateTimeEncoder", new Dictionary<string, object>()
        {
            { "W", 21},
            { "N", 1024},
            { "MinVal", now.AddYears(-10)},
            { "MaxVal", now},
            { "Periodic", false},
            { "Name", "DateTimeEncoder"},
            { "ClipInput", false},
            { "Padding", 5},
        });
DateTimeEncoder encoder = new DateTimeEncoder(encoderSettings, DateTimeEncoder.Precision.Days);
int[] result = encoder.Encode(DateTimeOffset.Parse(input.ToString()));
//Debug.WriteLine(NeoCortexApi.Helpers.StringifyVector(result));
//Debug.WriteLine(NeoCortexApi.Helpers.StringifyVector(expectedOutput));
int[,] twoDimenArray = ArrayUtils.Make2DArray<int>(result, 32, 32);
int[,] twoDimArray = ArrayUtils.Transpose(twoDimenArray);
NeoCortex.NeoCortexUtils.DrawBitmap(twoDimArray, 1024, 1024, $"DateTime_out_{input.ToString().Replace("/", "-").Replace(":", "-")}_32x32-N-{encoderSettings["DateTimeEncoder"]["N"]}-W-{encoderSettings["DateTimeEncoder"]["W"]}.png");
// Assert.IsTrue(result.SequenceEqual(expectedOutput));

//save files into input folder

//helper class method call to show in the console 


//ArgsConfig config = new ArgsConfig(args);

//Experiment ex1 = new Experiment(config);
//ex1.run();
