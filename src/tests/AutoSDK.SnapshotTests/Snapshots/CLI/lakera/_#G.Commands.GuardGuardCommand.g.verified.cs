//HintName: G.Commands.GuardGuardCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GuardGuardCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::G.GuardMessage> messages,
            global::G.Policy? policy,
            bool? breakdown,
            object? metadata,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.GuardResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<global::G.GuardMessage>> Messages { get; } = new(
            name: "messages")
        {
            Description = @"Array of chat messages to screen. Follows the OpenAI chat format.",
        };

        private global::System.CommandLine.Option<global::G.Policy?> Policy { get; } = new(
            name: "policy")
        {
            Description = @"Inline policy configuration that specifies which detectors to run and their thresholds.",
        };

        private global::System.CommandLine.Option<bool?> Breakdown { get; } = new(
            name: "breakdown")
        {
            Description = @"If true, returns per-message breakdown in the results.",
        };

        private global::System.CommandLine.Option<object?> Metadata { get; } = new(
            name: "metadata")
        {
            Description = @"Optional metadata to attach to this screening request for logging/tracking.",
        };


        public GuardGuardCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "guard",
            description: @"Screens messages for prompt injection, jailbreaks, PII, profanity, malicious links, 
unknown links, relevant languages, and other threats. Returns a boolean flagged verdict 
along with per-category results.
The messages array follows the OpenAI chat format with role and content fields.
You can optionally specify a policy to customize which detectors run and their thresholds.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Messages);
            Options.Add(Policy);
            Options.Add(Breakdown);
            Options.Add(Metadata);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var messages = parseResult.GetRequiredValue(Messages);
            var policy = parseResult.GetRequiredValue(Policy);
            var breakdown = parseResult.GetRequiredValue(Breakdown);
            var metadata = parseResult.GetRequiredValue(Metadata);

            Validate(
                parseResult: parseResult,
                messages: messages,
                policy: policy,
                breakdown: breakdown,
                metadata: metadata,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.GuardAsync(
                messages: messages,
                policy: policy,
                breakdown: breakdown,
                metadata: metadata,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}