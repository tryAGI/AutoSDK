//HintName: G.Commands.SnapshotsDeleteFullSnapshotCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SnapshotsDeleteFullSnapshotCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string snapshotName,
            bool? wait,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.DeleteFullSnapshotResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> SnapshotName { get; } = new(
            name: "snapshotName")
        {
            Description = @"Name of the full snapshot to delete",
        };

        private global::System.CommandLine.Option<bool?> Wait { get; } = new(
            name: "wait")
        {
            Description = @"If true, wait for changes to actually happen. If false - let changes happen in background. Default is true.",
        };


        public SnapshotsDeleteFullSnapshotCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "delete",
            description: @"Delete snapshot of the whole storage")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(SnapshotName);
            Options.Add(Wait);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var snapshotName = parseResult.GetRequiredValue(SnapshotName);
            var wait = parseResult.GetRequiredValue(Wait);

            Validate(
                parseResult: parseResult,
                snapshotName: snapshotName,
                wait: wait,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Snapshots.DeleteFullSnapshotAsync(
                snapshotName: snapshotName,
                wait: wait,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}