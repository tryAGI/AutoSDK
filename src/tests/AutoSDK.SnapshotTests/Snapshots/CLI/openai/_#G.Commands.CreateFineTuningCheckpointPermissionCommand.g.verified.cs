//HintName: G.Commands.CreateFineTuningCheckpointPermissionCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateFineTuningCheckpointPermissionCommand : global::System.CommandLine.Command
    {
        private readonly G.IOpenAiClient _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string fineTunedModelCheckpoint,
            global::System.Collections.Generic.IList<string> projectIds,
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

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<string>> ProjectIds { get; } = new(
            name: "projectIds")
        {
            Description = "",
        };

        public CreateFineTuningCheckpointPermissionCommand(G.IOpenAiClient client) : base(
            name: "create",
            description: @"")
        {
            _client = client;

            Arguments.Add(FineTunedModelCheckpoint);
            Arguments.Add(ProjectIds);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var fineTunedModelCheckpoint = parseResult.GetRequiredValue(FineTunedModelCheckpoint);
            var projectIds = parseResult.GetRequiredValue(ProjectIds);

            Validate(
                parseResult: parseResult,
                fineTunedModelCheckpoint: fineTunedModelCheckpoint,
                projectIds: projectIds,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.FineTuning.CreateFineTuningCheckpointPermissionAsync(
                fineTunedModelCheckpoint: fineTunedModelCheckpoint,
                projectIds: projectIds,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}