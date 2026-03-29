//HintName: G.Commands.SpansAddSpanFeedbackScoreCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SpansAddSpanFeedbackScoreCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid id,
            string name,
            string? categoryName,
            double value,
            string? reason,
            global::G.FeedbackScoreSource source,
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

        private global::System.CommandLine.Argument<double> Value { get; } = new(
            name: "value")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<global::G.FeedbackScoreSource> Source { get; } = new(
            name: "source")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> CategoryName { get; } = new(
            name: "categoryName")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Reason { get; } = new(
            name: "reason")
        {
            Description = @"",
        };


        public SpansAddSpanFeedbackScoreCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "add",
            description: @"Add span feedback score")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Id);
            Arguments.Add(Name);
            Arguments.Add(Value);
            Arguments.Add(Source);
            Options.Add(CategoryName);
            Options.Add(Reason);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var id = parseResult.GetRequiredValue(Id);
            var name = parseResult.GetRequiredValue(Name);
            var categoryName = parseResult.GetRequiredValue(CategoryName);
            var value = parseResult.GetRequiredValue(Value);
            var reason = parseResult.GetRequiredValue(Reason);
            var source = parseResult.GetRequiredValue(Source);

            Validate(
                parseResult: parseResult,
                id: id,
                name: name,
                categoryName: categoryName,
                value: value,
                reason: reason,
                source: source,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Spans.AddSpanFeedbackScoreAsync(
                id: id,
                name: name,
                categoryName: categoryName,
                value: value,
                reason: reason,
                source: source,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}