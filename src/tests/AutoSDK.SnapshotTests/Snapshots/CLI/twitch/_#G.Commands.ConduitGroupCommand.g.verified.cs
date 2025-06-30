//HintName: G.Commands.ConduitGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ConduitGroupCommand : global::System.CommandLine.Command
    {
        public ConduitGroupCommand(
            GetConduitsCommand command0,
            CreateConduitsCommand command1,
            UpdateConduitsCommand command2,
            DeleteConduitCommand command3,
            GetConduitShardsCommand command4,
            UpdateConduitShardsCommand command5)
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