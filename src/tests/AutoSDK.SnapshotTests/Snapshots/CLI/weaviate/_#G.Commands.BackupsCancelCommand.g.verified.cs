//HintName: G.Commands.BackupsCancelCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class BackupsCancelCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string backend,
            string id,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Backend { get; } = new(
            name: "backend")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Id { get; } = new(
            name: "id")
        {
            Description = "",
        };

        public BackupsCancelCommand(G.IApi client) : base(
            name: "backups",
            description: @"Cancel created backup with specified ID")
        {
            _client = client;

            Arguments.Add(Backend);
            Arguments.Add(Id);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var backend = parseResult.GetRequiredValue(Backend);
            var id = parseResult.GetRequiredValue(Id);

            Validate(
                parseResult: parseResult,
                backend: backend,
                id: id,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Backups.BackupsCancelAsync(
                backend: backend,
                id: id,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}