//HintName: G.Commands.ConduitGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ConduitGroupCommand : global::System.CommandLine.Command
    {
        public ConduitGroupCommand(
            ConduitsCreateConduitsCommand command0,
            ConduitsDeleteConduitCommand command1,
            ConduitsGetConduitShardsCommand command2,
            ConduitsGetConduitsCommand command3,
            ConduitsUpdateConduitShardsCommand command4,
            ConduitsUpdateConduitsCommand command5)
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