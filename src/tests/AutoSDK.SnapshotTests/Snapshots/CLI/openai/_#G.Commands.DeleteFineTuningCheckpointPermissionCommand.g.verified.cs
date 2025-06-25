//HintName: G.Commands.DeleteFineTuningCheckpointPermissionCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DeleteFineTuningCheckpointPermissionCommand : global::System.CommandLine.Command
    {
        private readonly G.IOpenAiClient _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string fineTunedModelCheckpoint,
            string permissionId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.DeleteFineTuningCheckpointPermissionResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> FineTunedModelCheckpoint { get; } = new(
            name: "fineTunedModelCheckpoint")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> PermissionId { get; } = new(
            name: "permissionId")
        {
            Description = "",
        };

        public DeleteFineTuningCheckpointPermissionCommand(G.IOpenAiClient client) : base(
            name: "delete",
            description: @"")
        {
            _client = client;

            Arguments.Add(FineTunedModelCheckpoint);
            Arguments.Add(PermissionId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var fineTunedModelCheckpoint = parseResult.GetRequiredValue(FineTunedModelCheckpoint);
            var permissionId = parseResult.GetRequiredValue(PermissionId);

            Validate(
                parseResult: parseResult,
                fineTunedModelCheckpoint: fineTunedModelCheckpoint,
                permissionId: permissionId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.FineTuning.DeleteFineTuningCheckpointPermissionAsync(
                fineTunedModelCheckpoint: fineTunedModelCheckpoint,
                permissionId: permissionId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}