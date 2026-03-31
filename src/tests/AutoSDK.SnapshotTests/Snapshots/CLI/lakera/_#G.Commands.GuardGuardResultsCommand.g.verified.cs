//HintName: G.Commands.GuardGuardResultsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GuardGuardResultsCommand : global::System.CommandLine.Command
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

            global::G.GuardResultsResponse response,
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


        public GuardGuardResultsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "guard",
            description: @"Similar to /v2/guard but returns detailed detection results with confidence scores, 
matched substrings, and additional metadata for each detector that triggered.
Use this endpoint when you need granular information about why content was flagged,
including exact text spans and detector confidence values.")
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
            var response = await _client.GuardResultsAsync(
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