//HintName: G.Commands.AgentsAgentsUpdateCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AgentsAgentsUpdateCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.AgentsUpdateCartesiaVersion cartesiaVersion,
            string agentId,
            string? name,
            string? description,
            string? ttsVoice,
            string? ttsLanguage,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.AgentSummary response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.AgentsUpdateCartesiaVersion> CartesiaVersion { get; } = new(
            name: "cartesiaVersion")
        {
            Description = @"API version header. Must be set to the API version, e.g. '2024-06-10'.",
        };

        private global::System.CommandLine.Argument<string> AgentId { get; } = new(
            name: "agentId")
        {
            Description = @"The ID of the agent.",
        };

        private new global::System.CommandLine.Option<string?> Name { get; } = new(
            name: "name")
        {
            Description = @"The name of the agent.",
        };

        private new global::System.CommandLine.Option<string?> Description { get; } = new(
            name: "description")
        {
            Description = @"The description of the agent.",
        };

        private global::System.CommandLine.Option<string?> TtsVoice { get; } = new(
            name: "ttsVoice")
        {
            Description = @"The ID of the voice.",
        };

        private global::System.CommandLine.Option<string?> TtsLanguage { get; } = new(
            name: "ttsLanguage")
        {
            Description = @"The language to use for text-to-speech.",
        };


        public AgentsAgentsUpdateCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "agents",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(CartesiaVersion);
            Arguments.Add(AgentId);
            Options.Add(Name);
            Options.Add(Description);
            Options.Add(TtsVoice);
            Options.Add(TtsLanguage);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var cartesiaVersion = parseResult.GetRequiredValue(CartesiaVersion);
            var agentId = parseResult.GetRequiredValue(AgentId);
            var name = parseResult.GetRequiredValue(Name);
            var description = parseResult.GetRequiredValue(Description);
            var ttsVoice = parseResult.GetRequiredValue(TtsVoice);
            var ttsLanguage = parseResult.GetRequiredValue(TtsLanguage);

            Validate(
                parseResult: parseResult,
                cartesiaVersion: cartesiaVersion,
                agentId: agentId,
                name: name,
                description: description,
                ttsVoice: ttsVoice,
                ttsLanguage: ttsLanguage,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Agents.AgentsUpdateAsync(
                cartesiaVersion: cartesiaVersion,
                agentId: agentId,
                name: name,
                description: description,
                ttsVoice: ttsVoice,
                ttsLanguage: ttsLanguage,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}