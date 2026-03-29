//HintName: G.Commands.SpansGetSpanByIdCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SpansGetSpanByIdCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid id,
            bool? stripAttachments,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.SpanPublic response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> Id { get; } = new(
            name: "id")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<bool?> StripAttachments { get; } = new(
            name: "stripAttachments")
        {
            Description = @"If true, returns attachment references like [file.png]; if false, downloads and reinjects attachment content from S3 (default: false for backward compatibility)",
        };


        public SpansGetSpanByIdCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Get span by id")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Id);
            Options.Add(StripAttachments);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var id = parseResult.GetRequiredValue(Id);
            var stripAttachments = parseResult.GetRequiredValue(StripAttachments);

            Validate(
                parseResult: parseResult,
                id: id,
                stripAttachments: stripAttachments,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Spans.GetSpanByIdAsync(
                id: id,
                stripAttachments: stripAttachments,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}