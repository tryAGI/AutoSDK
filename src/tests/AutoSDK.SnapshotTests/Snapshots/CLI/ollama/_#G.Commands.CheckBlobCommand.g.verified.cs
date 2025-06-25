//HintName: G.Commands.CheckBlobCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CheckBlobCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string digest,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Digest { get; } = new(
            name: "digest")
        {
            Description = "",
        };

        public CheckBlobCommand(G.IApi client) : base(
            name: "check",
            description: @"This is checking your Ollama server and not Ollama.ai.")
        {
            _client = client;

            Arguments.Add(Digest);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var digest = parseResult.GetRequiredValue(Digest);

            Validate(
                parseResult: parseResult,
                digest: digest,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Models.CheckBlobAsync(
                digest: digest,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}