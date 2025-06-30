//HintName: G.Commands.StyleGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class StyleGroupCommand : global::System.CommandLine.Command
    {
        public StyleGroupCommand(
            ListStylesCommand command0,
            CreateStyleCommand command1,
            DeleteStyleCommand command2)
            : base(
                name: "style")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
        }
    }
}