//HintName: G.Commands.MetaCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class MetaCommand : global::System.CommandLine.Command
    {
        public MetaCommand(
            MetaRootCommand command0,
            MetaGetCommand command1,
            MetaGetOctocatCommand command2,
            MetaGetAllVersionsCommand command3,
            MetaGetZenCommand command4)
            : base(
                name: "meta")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
            Subcommands.Add(command4);
        }
    }
}