//HintName: G.Commands.AgentsAgentsGetCallCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AgentsAgentsGetCallCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.AgentsGetCallCartesiaVersion cartesiaVersion,
            string callId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.AgentCall response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.AgentsGetCallCartesiaVersion> CartesiaVersion { get; } = new(
            name: "cartesiaVersion")
        {
            Description = @"API version header. Must be set to the API version, e.g. '2024-06-10'.",
        };

        private global::System.CommandLine.Argument<string> CallId { get; } = new(
            name: "callId")
        {
            Description = @"The ID of the call.",
        };



        public AgentsAgentsGetCallCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "agents",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(CartesiaVersion);
            Arguments.Add(CallId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var cartesiaVersion = parseResult.GetRequiredValue(CartesiaVersion);
            var callId = parseResult.GetRequiredValue(CallId);

            Validate(
                parseResult: parseResult,
                cartesiaVersion: cartesiaVersion,
                callId: callId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Agents.AgentsGetCallAsync(
                cartesiaVersion: cartesiaVersion,
                callId: callId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}