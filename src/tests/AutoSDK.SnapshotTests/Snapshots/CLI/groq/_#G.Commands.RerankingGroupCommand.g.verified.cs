//HintName: G.Commands.RerankingGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class RerankingGroupCommand : global::System.CommandLine.Command
    {
        public RerankingGroupCommand(
            RerankingCreateRerankingCommand command0)
            : base(
                name: "reranking")
        {
            Subcommands.Add(command0);
        }
    }
}