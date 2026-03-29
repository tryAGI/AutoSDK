//HintName: G.Commands.SnapshotsGetFullSnapshotCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SnapshotsGetFullSnapshotCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string snapshotName,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            byte[] response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> SnapshotName { get; } = new(
            name: "snapshotName")
        {
            Description = @"Name of the snapshot to download",
        };



        public SnapshotsGetFullSnapshotCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Download specified snapshot of the whole storage as a file")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(SnapshotName);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var snapshotName = parseResult.GetRequiredValue(SnapshotName);

            Validate(
                parseResult: parseResult,
                snapshotName: snapshotName,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Snapshots.GetFullSnapshotAsync(
                snapshotName: snapshotName,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}