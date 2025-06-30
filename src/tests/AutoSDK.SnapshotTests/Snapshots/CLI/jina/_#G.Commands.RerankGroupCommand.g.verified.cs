//HintName: G.Commands.RerankGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class RerankGroupCommand : global::System.CommandLine.Command
    {
        public RerankGroupCommand(
            RankV1RerankPostCommand command0)
            : base(
                name: "rerank")
        {
            Subcommands.Add(command0);
        }
    }
}