//HintName: G.Commands.CliVersionCliVersionGetCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CliVersionCliVersionGetCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string version,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            string response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Version { get; } = new(
            name: "version")
        {
            Description = "",
        };

        public CliVersionCliVersionGetCommand(G.IApi client) : base(
            name: "cli",
            description: @"")
        {
            _client = client;

            Arguments.Add(Version);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var version = parseResult.GetRequiredValue(Version);

            Validate(
                parseResult: parseResult,
                version: version,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.CliVersionCliVersionGetAsync(
                version: version,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}