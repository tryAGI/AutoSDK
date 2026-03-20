//HintName: G.Commands.ConduitGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ConduitGroupCommand : global::System.CommandLine.Command
    {
        public ConduitGroupCommand(
            ConduitsGetConduitsCommand command0,
            ConduitsCreateConduitsCommand command1,
            ConduitsUpdateConduitsCommand command2,
            ConduitsDeleteConduitCommand command3,
            ConduitsGetConduitShardsCommand command4,
            ConduitsUpdateConduitShardsCommand command5)
            : base(
                name: "conduit")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
            Subcommands.Add(command4);
            Subcommands.Add(command5);
        }
    }
}