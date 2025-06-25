//HintName: G.Commands.BackupsCreateStatusCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class BackupsCreateStatusCommand : global::System.CommandLine.Command
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
            global::G.BackupCreateStatusResponse response,
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

        public BackupsCreateStatusCommand(G.IApi client) : base(
            name: "backups",
            description: @"Returns status of backup creation attempt for a set of collections. <br/><br/>All client implementations have a `wait for completion` option which will poll the backup status in the background and only return once the backup has completed (successfully or unsuccessfully). If you set the `wait for completion` option to false, you can also check the status yourself using this endpoint.")
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
            var response = await _client.Backups.BackupsCreateStatusAsync(
                backend: backend,
                id: id,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}