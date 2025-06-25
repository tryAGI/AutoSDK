//HintName: G.Commands.AgentsPartialUpdateCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AgentsPartialUpdateCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid agentId,
            string? name,
            global::G.UltravoxV1CallTemplate? callTemplate,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.Agent response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> AgentId { get; } = new(
            name: "agentId")
        {
            Description = @"",
        };

        private new global::System.CommandLine.Option<string?> Name { get; } = new(
            name: "name")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.UltravoxV1CallTemplate?> CallTemplate { get; } = new(
            name: "callTemplate")
        {
            Description = @"A CallTemplate that can be used to create Ultravox calls with shared properties.",
        };
        public AgentsPartialUpdateCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "agents",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(AgentId);
            Options.Add(Name);
            Options.Add(CallTemplate);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var agentId = parseResult.GetRequiredValue(AgentId);
            var name = parseResult.GetRequiredValue(Name);
            var callTemplate = parseResult.GetRequiredValue(CallTemplate);

            Validate(
                parseResult: parseResult,
                agentId: agentId,
                name: name,
                callTemplate: callTemplate,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Agents.AgentsPartialUpdateAsync(
                agentId: agentId,
                name: name,
                callTemplate: callTemplate,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}