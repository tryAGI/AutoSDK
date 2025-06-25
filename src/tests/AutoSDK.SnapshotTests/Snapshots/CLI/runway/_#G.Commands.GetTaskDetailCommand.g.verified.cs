//HintName: G.Commands.GetTaskDetailCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetTaskDetailCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GetTaskDetailXRunwayVersion xRunwayVersion,
            global::System.Guid id,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GetTaskDetailResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.GetTaskDetailXRunwayVersion> XRunwayVersion { get; } = new(
            name: "xRunwayVersion")
        {
            Description = @"API version header.",
        };

        private global::System.CommandLine.Argument<global::System.Guid> Id { get; } = new(
            name: "id")
        {
            Description = @"The ID of the task.",
        };

        public GetTaskDetailCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Return details about a task. Updates every 5 seconds.")
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
            var response = await _client.GetTaskDetailAsync(
                xRunwayVersion: xRunwayVersion,
                id: id,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}