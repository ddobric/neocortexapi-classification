using NeoCortexApi.Encoders;
using NeoCortexApi.Network;
using NeoCortexApi.Utility;

static void Main(string[] args)
{
    Dictionary<string, Dictionary<string, object>> dateTimeinput = Dictionary<string, Dictionary<string, object> >();
    Dictionary<string, object> Inp = new Dictionary<string, object>;
    dateTimeinput["DateTimeEncoder"]["MinVal"] = DateTime.Now.AddYears(-10);
    dateTimeinput["DateTimeEncoder"]["MaxVal"] = DateTime.Now;
    string s = Console.ReadLine();
    

    Precision.dazs = a 
    for (int i = 0; i < 20; i++)
    {

    }
   DateTimeEncoder tmp = new DateTimeEncoder()
   /*ortexNetworkContext ctx = new CortexNetworkContext();
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
    Debug.WriteLine(NeoCortexApi.Helpers.StringifyVector(result));
    //Debug.WriteLine(NeoCortexApi.Helpers.StringifyVector(expectedOutput));
    int[,] twoDimenArray = ArrayUtils.Make2DArray<int>(result, 32, 32);
    int[,] twoDimArray = ArrayUtils.Transpose(twoDimenArray);
    NeoCortexUtils.DrawBitmap(twoDimArray, 1024, 1024, $"DateTime_out_{input.ToString().Replace("/", "-").Replace(":", "-")}_32x32-N-{encoderSettings["DateTimeEncoder"]["N"]}-W-{encoderSettings["DateTimeEncoder"]["W"]}.png");
    // Assert.IsTrue(result.SequenceEqual(expectedOutput));*/
}
