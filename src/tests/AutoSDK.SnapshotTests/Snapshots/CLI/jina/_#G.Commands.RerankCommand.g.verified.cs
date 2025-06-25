//HintName: G.Commands.RerankCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class RerankCommand : global::System.CommandLine.Command
    {
        public RerankCommand(
            RankV1RerankPostCommand command0)
            : base(
                name: "rerank")
        {
            Subcommands.Add(command0);
        }
    }
}