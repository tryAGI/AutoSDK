//HintName: G.Commands.SubmitFeedbackV1FeedbackPostCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SubmitFeedbackV1FeedbackPostCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? xiApiKey,
            string message,
            string? contactEmail,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            string response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Message { get; } = new(
            name: "message")
        {
            Description = @"The message you'd like to send to deepinfra team",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> ContactEmail { get; } = new(
            name: "contactEmail")
        {
            Description = @"Optional contact email to reach you back",
        };
        public SubmitFeedbackV1FeedbackPostCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "submit",
            description: @"Submit feedback")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Message);
            Options.Add(XiApiKey);
            Options.Add(ContactEmail);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var message = parseResult.GetRequiredValue(Message);
            var contactEmail = parseResult.GetRequiredValue(ContactEmail);

            Validate(
                parseResult: parseResult,
                xiApiKey: xiApiKey,
                message: message,
                contactEmail: contactEmail,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.SubmitFeedbackV1FeedbackPostAsync(
                xiApiKey: xiApiKey,
                message: message,
                contactEmail: contactEmail,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}