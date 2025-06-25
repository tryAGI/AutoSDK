//HintName: G.Commands.StudioCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class StudioCommand : global::System.CommandLine.Command
    {
        public StudioCommand(
            CreateStudioPodcastsCommand command0,
            GetStudioProjectsCommand command1,
            CreateStudioProjectsCommand command2,
            CreateStudioProjectsByProjectIdCommand command3,
            GetStudioProjectsByProjectIdCommand command4,
            DeleteStudioProjectsByProjectIdCommand command5,
            CreateStudioProjectsByProjectIdContentCommand command6,
            CreateStudioProjectsByProjectIdConvertCommand command7,
            GetStudioProjectsByProjectIdSnapshotsCommand command8,
            GetStudioProjectsByProjectIdSnapshotsByProjectSnapshotIdCommand command9,
            CreateStudioProjectsByProjectIdSnapshotsByProjectSnapshotIdStreamCommand command10,
            CreateStudioProjectsByProjectIdSnapshotsByProjectSnapshotIdArchiveCommand command11,
            GetStudioProjectsByProjectIdChaptersCommand command12,
            CreateStudioProjectsByProjectIdChaptersCommand command13,
            GetStudioProjectsByProjectIdChaptersByChapterIdCommand command14,
            CreateStudioProjectsByProjectIdChaptersByChapterIdCommand command15,
            DeleteStudioProjectsByProjectIdChaptersByChapterIdCommand command16,
            CreateStudioProjectsByProjectIdChaptersByChapterIdConvertCommand command17,
            GetStudioProjectsByProjectIdChaptersByChapterIdSnapshotsCommand command18,
            GetStudioProjectsByProjectIdChaptersByChapterIdSnapshotsByChapterSnapshotIdCommand command19,
            CreateStudioProjectsByProjectIdChaptersByChapterIdSnapshotsByChapterSnapshotIdStreamCommand command20,
            CreateStudioProjectsByProjectIdPronunciationDictionariesCommand command21)
            : base(
                name: "studio")
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
            Subcommands.Add(command20);
            Subcommands.Add(command21);
        }
    }
}