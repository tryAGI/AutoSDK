//HintName: G.Commands.GraphqlCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GraphqlCommand : global::System.CommandLine.Command
    {
        public GraphqlCommand(
            GraphqlPostCommand command0,
            GraphqlBatchCommand command1)
            : base(
                name: "graphql")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
        }
    }
}