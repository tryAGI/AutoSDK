//HintName: G.Commands.AgentsRetrieveCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AgentsRetrieveCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid agentId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.Agent response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> AgentId { get; } = new(
            name: "agentId")
        {
            Description = "",
        };

        public AgentsRetrieveCommand(G.IApi client) : base(
            name: "agents",
            description: @"")
        {
            _client = client;

            Arguments.Add(AgentId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var agentId = parseResult.GetRequiredValue(AgentId);

            Validate(
                parseResult: parseResult,
                agentId: agentId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Agents.AgentsRetrieveAsync(
                agentId: agentId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}