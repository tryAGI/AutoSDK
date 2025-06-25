//HintName: G.Commands.CreateProjectsByProjectIdSnapshotsByProjectSnapshotIdArchiveCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateProjectsByProjectIdSnapshotsByProjectSnapshotIdArchiveCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string projectId,
            string projectSnapshotId,
            string? xiApiKey,
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
        public CreateProjectsByProjectIdSnapshotsByProjectSnapshotIdArchiveCommand(G.IApi client) : base(
            name: "create",
            description: @"Streams archive with project audio.")
        {
            _client = client;

            Arguments.Add(ProjectId);
            Arguments.Add(ProjectSnapshotId);
            Options.Add(XiApiKey);

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

            Validate(
                parseResult: parseResult,
                projectId: projectId,
                projectSnapshotId: projectSnapshotId,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Projects.CreateProjectsByProjectIdSnapshotsByProjectSnapshotIdArchiveAsync(
                projectId: projectId,
                projectSnapshotId: projectSnapshotId,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}