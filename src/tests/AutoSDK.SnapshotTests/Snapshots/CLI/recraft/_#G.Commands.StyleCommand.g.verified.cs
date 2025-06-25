//HintName: G.Commands.StyleCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class StyleCommand : global::System.CommandLine.Command
    {
        public StyleCommand(
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