//HintName: G.Commands.SnapshotsCreateFullSnapshotCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SnapshotsCreateFullSnapshotCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            bool? wait,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.CreateFullSnapshotResponse response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<bool?> Wait { get; } = new(
            name: "wait")
        {
            Description = @"If true, wait for changes to actually happen. If false - let changes happen in background. Default is true.",
        };


        public SnapshotsCreateFullSnapshotCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"Create new snapshot of the whole storage")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(Wait);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var wait = parseResult.GetRequiredValue(Wait);

            Validate(
                parseResult: parseResult,
                wait: wait,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Snapshots.CreateFullSnapshotAsync(
                wait: wait,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}