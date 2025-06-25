//HintName: G.Commands.ListFineTuningCheckpointPermissionsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ListFineTuningCheckpointPermissionsCommand : global::System.CommandLine.Command
    {
        private readonly G.IOpenAiClient _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string fineTunedModelCheckpoint,
            string? projectId,
            string? after,
            int? limit,
            global::G.ListFineTuningCheckpointPermissionsOrder? order,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ListFineTuningCheckpointPermissionResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> FineTunedModelCheckpoint { get; } = new(
            name: "fineTunedModelCheckpoint")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> ProjectId { get; } = new(
            name: "projectId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> After { get; } = new(
            name: "after")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> Limit { get; } = new(
            name: "limit")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ListFineTuningCheckpointPermissionsOrder?> Order { get; } = new(
            name: "order")
        {
            Description = "",
        };
        public ListFineTuningCheckpointPermissionsCommand(G.IOpenAiClient client) : base(
            name: "list",
            description: @"")
        {
            _client = client;

            Arguments.Add(FineTunedModelCheckpoint);
            Options.Add(ProjectId);
            Options.Add(After);
            Options.Add(Limit);
            Options.Add(Order);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var fineTunedModelCheckpoint = parseResult.GetRequiredValue(FineTunedModelCheckpoint);
            var projectId = parseResult.GetRequiredValue(ProjectId);
            var after = parseResult.GetRequiredValue(After);
            var limit = parseResult.GetRequiredValue(Limit);
            var order = parseResult.GetRequiredValue(Order);

            Validate(
                parseResult: parseResult,
                fineTunedModelCheckpoint: fineTunedModelCheckpoint,
                projectId: projectId,
                after: after,
                limit: limit,
                order: order,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.FineTuning.ListFineTuningCheckpointPermissionsAsync(
                fineTunedModelCheckpoint: fineTunedModelCheckpoint,
                projectId: projectId,
                after: after,
                limit: limit,
                order: order,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}