//HintName: G.Commands.AgentsAgentsCreateMetricCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AgentsAgentsCreateMetricCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.AgentsCreateMetricCartesiaVersion cartesiaVersion,
            string name,
            string? displayName,
            string prompt,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.Metric response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.AgentsCreateMetricCartesiaVersion> CartesiaVersion { get; } = new(
            name: "cartesiaVersion")
        {
            Description = @"API version header. Must be set to the API version, e.g. '2024-06-10'.",
        };

        private new global::System.CommandLine.Argument<string> Name { get; } = new(
            name: "name")
        {
            Description = @"The name of the metric. This must be a unique name that only allows lower case letters, numbers, and the characters _, -, and .",
        };

        private global::System.CommandLine.Argument<string> Prompt { get; } = new(
            name: "prompt")
        {
            Description = @"The prompt associated with the metric, detailing the task and evaluation criteria.",
        };

        private global::System.CommandLine.Option<string?> DisplayName { get; } = new(
            name: "displayName")
        {
            Description = @"The display name of the metric.",
        };


        public AgentsAgentsCreateMetricCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "agents",
            description: @"Create a new metric.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(CartesiaVersion);
            Arguments.Add(Name);
            Arguments.Add(Prompt);
            Options.Add(DisplayName);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var cartesiaVersion = parseResult.GetRequiredValue(CartesiaVersion);
            var name = parseResult.GetRequiredValue(Name);
            var displayName = parseResult.GetRequiredValue(DisplayName);
            var prompt = parseResult.GetRequiredValue(Prompt);

            Validate(
                parseResult: parseResult,
                cartesiaVersion: cartesiaVersion,
                name: name,
                displayName: displayName,
                prompt: prompt,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Agents.AgentsCreateMetricAsync(
                cartesiaVersion: cartesiaVersion,
                name: name,
                displayName: displayName,
                prompt: prompt,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}