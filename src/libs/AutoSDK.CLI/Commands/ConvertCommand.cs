using System.CommandLine;

namespace AutoSDK.CLI.Commands;

internal sealed class ConvertCommand : Command
{
    private Argument<string> Input { get; } = new(
        name: "input")
    {
        DefaultValueFactory = _ => string.Empty,
        Description = "Input file path",
    };

    private Option<string> Output { get; } = new(
        name: "--output",
        aliases: ["-o"])
    {
        DefaultValueFactory = _ => "openapi30.yaml",
        Description = "Output file path",
    };

    public ConvertCommand() : base(name: "convert-to-openapi30", description: "Converts OpenAPI 3.1 spec to OpenAPI 3.0. (Note: Microsoft.OpenApi 3.x has native OpenAPI 3.1 support, so this command may not be needed)")
    {
        Arguments.Add(Input);
        Options.Add(Output);

        SetAction(HandleAsync);
    }

    private static Task HandleAsync(ParseResult parseResult)
    {
        Console.WriteLine("This command is currently disabled.");
        Console.WriteLine("Microsoft.OpenApi 3.x now has native support for OpenAPI 3.1 specifications.");
        Console.WriteLine("If you still need conversion functionality, please open an issue on GitHub.");

        return Task.CompletedTask;
    }
}