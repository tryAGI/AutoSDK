//HintName: G.Commands.ProjectCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ProjectCommand : global::System.CommandLine.Command
    {
        public ProjectCommand(
            CreateProjectsPodcastCreateCommand command0,
            GetProjectsCommand command1,
            CreateProjectsAddCommand command2,
            CreateProjectsByProjectIdCommand command3,
            GetProjectsByProjectIdCommand command4,
            DeleteProjectsByProjectIdCommand command5,
            CreateProjectsByProjectIdContentCommand command6,
            CreateProjectsByProjectIdConvertCommand command7,
            GetProjectsByProjectIdSnapshotsCommand command8,
            CreateProjectsByProjectIdSnapshotsByProjectSnapshotIdStreamCommand command9,
            CreateProjectsByProjectIdSnapshotsByProjectSnapshotIdArchiveCommand command10,
            GetProjectsByProjectIdChaptersCommand command11,
            GetProjectsByProjectIdChaptersByChapterIdCommand command12,
            EditProjectsByProjectIdChaptersByChapterIdCommand command13,
            DeleteProjectsByProjectIdChaptersByChapterIdCommand command14,
            CreateProjectsByProjectIdChaptersAddCommand command15,
            CreateProjectsByProjectIdChaptersByChapterIdConvertCommand command16,
            GetProjectsByProjectIdChaptersByChapterIdSnapshotsCommand command17,
            CreateProjectsByProjectIdChaptersByChapterIdSnapshotsByChapterSnapshotIdStreamCommand command18,
            CreateProjectsByProjectIdUpdatePronunciationDictionariesCommand command19)
            : base(
                name: "project")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
            Subcommands.Add(command4);
            Subcommands.Add(command5);
            Subcommands.Add(command6);
            Subcommands.Add(command7);
            Subcommands.Add(command8);
            Subcommands.Add(command9);
            Subcommands.Add(command10);
            Subcommands.Add(command11);
            Subcommands.Add(command12);
            Subcommands.Add(command13);
            Subcommands.Add(command14);
            Subcommands.Add(command15);
            Subcommands.Add(command16);
            Subcommands.Add(command17);
            Subcommands.Add(command18);
            Subcommands.Add(command19);
        }
    }
}