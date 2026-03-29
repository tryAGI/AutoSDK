//HintName: G.Commands.SnapshotsDeleteSnapshotCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SnapshotsDeleteSnapshotCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string collectionName,
            string snapshotName,
            bool? wait,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.DeleteSnapshotResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> CollectionName { get; } = new(
            name: "collectionName")
        {
            Description = @"Name of the collection for which to delete a snapshot",
        };

        private global::System.CommandLine.Argument<string> SnapshotName { get; } = new(
            name: "snapshotName")
        {
            Description = @"Name of the snapshot to delete",
        };

        private global::System.CommandLine.Option<bool?> Wait { get; } = new(
            name: "wait")
        {
            Description = @"If true, wait for changes to actually happen. If false - let changes happen in background. Default is true.",
        };


        public SnapshotsDeleteSnapshotCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "delete",
            description: @"Delete snapshot for a collection")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(CollectionName);
            Arguments.Add(SnapshotName);
            Options.Add(Wait);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var collectionName = parseResult.GetRequiredValue(CollectionName);
            var snapshotName = parseResult.GetRequiredValue(SnapshotName);
            var wait = parseResult.GetRequiredValue(Wait);

            Validate(
                parseResult: parseResult,
                collectionName: collectionName,
                snapshotName: snapshotName,
                wait: wait,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Snapshots.DeleteSnapshotAsync(
                collectionName: collectionName,
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