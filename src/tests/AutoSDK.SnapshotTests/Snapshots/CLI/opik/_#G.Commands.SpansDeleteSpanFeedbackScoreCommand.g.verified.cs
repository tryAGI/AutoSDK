//HintName: G.Commands.SpansDeleteSpanFeedbackScoreCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SpansDeleteSpanFeedbackScoreCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid id,
            string name,
            string? author,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> Id { get; } = new(
            name: "id")
        {
            Description = @"",
        };

        private new global::System.CommandLine.Argument<string> Name { get; } = new(
            name: "name")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Author { get; } = new(
            name: "author")
        {
            Description = @"",
        };


        public SpansDeleteSpanFeedbackScoreCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "delete",
            description: @"Delete span feedback score")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Id);
            Arguments.Add(Name);
            Options.Add(Author);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var id = parseResult.GetRequiredValue(Id);
            var name = parseResult.GetRequiredValue(Name);
            var author = parseResult.GetRequiredValue(Author);

            Validate(
                parseResult: parseResult,
                id: id,
                name: name,
                author: author,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Spans.DeleteSpanFeedbackScoreAsync(
                id: id,
                name: name,
                author: author,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}