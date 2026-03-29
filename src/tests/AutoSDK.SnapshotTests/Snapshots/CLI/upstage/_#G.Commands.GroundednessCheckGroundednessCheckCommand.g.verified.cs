//HintName: G.Commands.GroundednessCheckGroundednessCheckCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GroundednessCheckGroundednessCheckCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string context,
            string answer,
            string? model,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.GroundednessCheckResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Context { get; } = new(
            name: "context")
        {
            Description = @"The context/source text against which the answer will be verified.",
        };

        private global::System.CommandLine.Argument<string> Answer { get; } = new(
            name: "answer")
        {
            Description = @"The answer/response to check for groundedness.",
        };

        private global::System.CommandLine.Option<string?> Model { get; } = new(
            name: "model")
        {
            Description = @"The model to use for groundedness check.
Default: groundedness-check",
        };


        public GroundednessCheckGroundednessCheckCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "groundedness",
            description: @"Checks whether a given answer is grounded in the provided context.
Returns a boolean result, confidence score, and reason.
Useful for verifying that LLM responses are factually supported by source material.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Context);
            Arguments.Add(Answer);
            Options.Add(Model);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var context = parseResult.GetRequiredValue(Context);
            var answer = parseResult.GetRequiredValue(Answer);
            var model = parseResult.GetRequiredValue(Model);

            Validate(
                parseResult: parseResult,
                context: context,
                answer: answer,
                model: model,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.GroundednessCheck.GroundednessCheckAsync(
                context: context,
                answer: answer,
                model: model,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}