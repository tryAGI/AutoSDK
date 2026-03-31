//HintName: G.Commands.AgentsAgentsListCallsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AgentsAgentsListCallsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.AgentsListCallsCartesiaVersion cartesiaVersion,
            string agentId,
            string? expand,
            string? startingAfter,
            string? endingBefore,
            int? limit,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.GetCallsResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.AgentsListCallsCartesiaVersion> CartesiaVersion { get; } = new(
            name: "cartesiaVersion")
        {
            Description = @"API version header. Must be set to the API version, e.g. '2024-06-10'.",
        };

        private global::System.CommandLine.Argument<string> AgentId { get; } = new(
            name: "agentId")
        {
            Description = @"The ID of the agent.",
        };

        private global::System.CommandLine.Option<string?> Expand { get; } = new(
            name: "expand")
        {
            Description = @"The fields to expand in the response. Currently, the only supported value is `transcript`.",
        };

        private global::System.CommandLine.Option<string?> StartingAfter { get; } = new(
            name: "startingAfter")
        {
            Description = @"(Pagination option)The ID of the call to start after.",
        };

        private global::System.CommandLine.Option<string?> EndingBefore { get; } = new(
            name: "endingBefore")
        {
            Description = @"(Pagination option) The ID of the call to end before.",
        };

        private global::System.CommandLine.Option<int?> Limit { get; } = new(
            name: "limit")
        {
            Description = @"(Pagination option) The number of calls to return per page, ranging between 1 and 100.",
        };


        public AgentsAgentsListCallsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "agents",
            description: @"Lists calls sorted by start time in descending order for a specific agent. `agent_id` is required and if you want to include `transcript` in the response, add `expand=transcript` to the request. This endpoint is paginated.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(CartesiaVersion);
            Arguments.Add(AgentId);
            Options.Add(Expand);
            Options.Add(StartingAfter);
            Options.Add(EndingBefore);
            Options.Add(Limit);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var cartesiaVersion = parseResult.GetRequiredValue(CartesiaVersion);
            var agentId = parseResult.GetRequiredValue(AgentId);
            var expand = parseResult.GetRequiredValue(Expand);
            var startingAfter = parseResult.GetRequiredValue(StartingAfter);
            var endingBefore = parseResult.GetRequiredValue(EndingBefore);
            var limit = parseResult.GetRequiredValue(Limit);

            Validate(
                parseResult: parseResult,
                cartesiaVersion: cartesiaVersion,
                agentId: agentId,
                expand: expand,
                startingAfter: startingAfter,
                endingBefore: endingBefore,
                limit: limit,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Agents.AgentsListCallsAsync(
                cartesiaVersion: cartesiaVersion,
                agentId: agentId,
                expand: expand,
                startingAfter: startingAfter,
                endingBefore: endingBefore,
                limit: limit,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}