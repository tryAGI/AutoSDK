//HintName: G.Commands.TagGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TagGroupCommand : global::System.CommandLine.Command
    {
        public TagGroupCommand(
            TagsGetAllStreamTagsCommand command0,
            TagsGetStreamTagsCommand command1)
            : base(
                name: "tag")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
        }
    }
}