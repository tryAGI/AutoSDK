//HintName: G.Commands.CreateProjectsByProjectIdSnapshotsByProjectSnapshotIdStreamCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateProjectsByProjectIdSnapshotsByProjectSnapshotIdStreamCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string projectId,
            string projectSnapshotId,
            string? xiApiKey,
            bool? convertToMpeg,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ProjectId { get; } = new(
            name: "projectId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> ProjectSnapshotId { get; } = new(
            name: "projectSnapshotId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> ConvertToMpeg { get; } = new(
            name: "convertToMpeg")
        {
            Description = "",
        };
        public CreateProjectsByProjectIdSnapshotsByProjectSnapshotIdStreamCommand(G.IApi client) : base(
            name: "create",
            description: @"Stream the audio from a project snapshot.")
        {
            _client = client;

            Arguments.Add(ProjectId);
            Arguments.Add(ProjectSnapshotId);
            Options.Add(XiApiKey);
            Options.Add(ConvertToMpeg);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var projectId = parseResult.GetRequiredValue(ProjectId);
            var projectSnapshotId = parseResult.GetRequiredValue(ProjectSnapshotId);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var convertToMpeg = parseResult.GetRequiredValue(ConvertToMpeg);

            Validate(
                parseResult: parseResult,
                projectId: projectId,
                projectSnapshotId: projectSnapshotId,
                xiApiKey: xiApiKey,
                convertToMpeg: convertToMpeg,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Projects.CreateProjectsByProjectIdSnapshotsByProjectSnapshotIdStreamAsync(
                projectId: projectId,
                projectSnapshotId: projectSnapshotId,
                xiApiKey: xiApiKey,
                convertToMpeg: convertToMpeg,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}