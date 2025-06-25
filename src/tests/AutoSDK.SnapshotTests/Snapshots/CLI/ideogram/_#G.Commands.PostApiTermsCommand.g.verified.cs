//HintName: G.Commands.PostApiTermsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PostApiTermsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string termsId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> TermsId { get; } = new(
            name: "termsId")
        {
            Description = @"The ID of the terms which are being accepted.",
        };

        public PostApiTermsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "post",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(TermsId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var termsId = parseResult.GetRequiredValue(TermsId);

            Validate(
                parseResult: parseResult,
                termsId: termsId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Manage.PostApiTermsAsync(
                termsId: termsId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}