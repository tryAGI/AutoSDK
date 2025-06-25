//HintName: G.Commands.BackupsListCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class BackupsListCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string backend,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::G.BackupListResponseItem> response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Backend { get; } = new(
            name: "backend")
        {
            Description = "",
        };

        public BackupsListCommand(G.IApi client) : base(
            name: "backups",
            description: @"List all backups in progress")
        {
            _client = client;

            Arguments.Add(Backend);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var backend = parseResult.GetRequiredValue(Backend);

            Validate(
                parseResult: parseResult,
                backend: backend,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Backups.BackupsListAsync(
                backend: backend,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}