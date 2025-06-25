//HintName: G.Commands.CancelOrDeleteTaskCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CancelOrDeleteTaskCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.CancelOrDeleteTaskXRunwayVersion xRunwayVersion,
            global::System.Guid id,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.CancelOrDeleteTaskXRunwayVersion> XRunwayVersion { get; } = new(
            name: "xRunwayVersion")
        {
            Description = @"API version header.",
        };

        private global::System.CommandLine.Argument<global::System.Guid> Id { get; } = new(
            name: "id")
        {
            Description = @"The ID of the task.",
        };

        public CancelOrDeleteTaskCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "cancel",
            description: @"Cancel a running task or delete a completed one.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(XRunwayVersion);
            Arguments.Add(Id);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var xRunwayVersion = parseResult.GetRequiredValue(XRunwayVersion);
            var id = parseResult.GetRequiredValue(Id);

            Validate(
                parseResult: parseResult,
                xRunwayVersion: xRunwayVersion,
                id: id,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.CancelOrDeleteTaskAsync(
                xRunwayVersion: xRunwayVersion,
                id: id,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}