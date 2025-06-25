//HintName: G.Commands.CopyModelCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CopyModelCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string source,
            string destination,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Source { get; } = new(
            name: "source")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Destination { get; } = new(
            name: "destination")
        {
            Description = "",
        };

        public CopyModelCommand(G.IApi client) : base(
            name: "copy",
            description: @"")
        {
            _client = client;

            Arguments.Add(Source);
            Arguments.Add(Destination);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var source = parseResult.GetRequiredValue(Source);
            var destination = parseResult.GetRequiredValue(Destination);

            Validate(
                parseResult: parseResult,
                source: source,
                destination: destination,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Models.CopyModelAsync(
                source: source,
                destination: destination,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}