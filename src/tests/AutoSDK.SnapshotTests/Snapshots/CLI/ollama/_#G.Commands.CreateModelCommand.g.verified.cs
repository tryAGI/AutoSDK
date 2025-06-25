//HintName: G.Commands.CreateModelCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateModelCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string model,
            string modelfile,
            string? path,
            string? quantize,
            bool? stream,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.CreateModelResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Model { get; } = new(
            name: "model")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Modelfile { get; } = new(
            name: "modelfile")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Path { get; } = new(
            name: "path")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Quantize { get; } = new(
            name: "quantize")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> Stream { get; } = new(
            name: "stream")
        {
            Description = "",
        };
        public CreateModelCommand(G.IApi client) : base(
            name: "create",
            description: @"It is recommended to set `modelfile` to the content of the Modelfile rather than just set `path`. This is a requirement for remote create. Remote model creation should also create any file blobs, fields such as `FROM` and `ADAPTER`, explicitly with the server using Create a Blob and the value to the path indicated in the response.")
        {
            _client = client;

            Arguments.Add(Model);
            Arguments.Add(Modelfile);
            Options.Add(Path);
            Options.Add(Quantize);
            Options.Add(Stream);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var model = parseResult.GetRequiredValue(Model);
            var modelfile = parseResult.GetRequiredValue(Modelfile);
            var path = parseResult.GetRequiredValue(Path);
            var quantize = parseResult.GetRequiredValue(Quantize);
            var stream = parseResult.GetRequiredValue(Stream);

            Validate(
                parseResult: parseResult,
                model: model,
                modelfile: modelfile,
                path: path,
                quantize: quantize,
                stream: stream,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Models.CreateModelAsync(
                model: model,
                modelfile: modelfile,
                path: path,
                quantize: quantize,
                stream: stream,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}