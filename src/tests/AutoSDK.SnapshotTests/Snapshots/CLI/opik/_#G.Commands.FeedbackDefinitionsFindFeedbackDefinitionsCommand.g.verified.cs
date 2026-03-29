//HintName: G.Commands.FeedbackDefinitionsFindFeedbackDefinitionsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class FeedbackDefinitionsFindFeedbackDefinitionsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int? page,
            int? size,
            string? name,
            global::G.FindFeedbackDefinitionsType? type,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.FeedbackDefinitionPagePublic response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<int?> Page { get; } = new(
            name: "page")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<int?> Size { get; } = new(
            name: "size")
        {
            Description = @"",
        };

        private new global::System.CommandLine.Option<string?> Name { get; } = new(
            name: "name")
        {
            Description = @"Filter feedback definitions by name (partial match, case insensitive)",
        };

        private global::System.CommandLine.Option<global::G.FindFeedbackDefinitionsType?> Type { get; } = new(
            name: "type")
        {
            Description = @"",
        };


        public FeedbackDefinitionsFindFeedbackDefinitionsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "find",
            description: @"Find Feedback definitions")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(Page);
            Options.Add(Size);
            Options.Add(Name);
            Options.Add(Type);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var page = parseResult.GetRequiredValue(Page);
            var size = parseResult.GetRequiredValue(Size);
            var name = parseResult.GetRequiredValue(Name);
            var type = parseResult.GetRequiredValue(Type);

            Validate(
                parseResult: parseResult,
                page: page,
                size: size,
                name: name,
                type: type,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.FeedbackDefinitions.FindFeedbackDefinitionsAsync(
                page: page,
                size: size,
                name: name,
                type: type,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}