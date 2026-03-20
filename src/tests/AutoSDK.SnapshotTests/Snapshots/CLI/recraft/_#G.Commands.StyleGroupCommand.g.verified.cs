//HintName: G.Commands.StyleGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class StyleGroupCommand : global::System.CommandLine.Command
    {
        public StyleGroupCommand(
            StyleListStylesCommand command0,
            StyleCreateStyleCommand command1,
            StyleDeleteStyleCommand command2)
            : base(
                name: "style")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
        }
    }
}