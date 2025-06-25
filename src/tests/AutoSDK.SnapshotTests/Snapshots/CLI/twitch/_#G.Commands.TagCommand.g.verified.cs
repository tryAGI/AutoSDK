//HintName: G.Commands.TagCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TagCommand : global::System.CommandLine.Command
    {
        public TagCommand(
            GetAllStreamTagsCommand command0,
            GetStreamTagsCommand command1)
            : base(
                name: "tag")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
        }
    }
}