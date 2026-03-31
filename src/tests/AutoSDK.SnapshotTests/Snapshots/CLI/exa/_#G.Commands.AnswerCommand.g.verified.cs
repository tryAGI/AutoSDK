//HintName: G.Commands.AnswerCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AnswerCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string query,
            bool? text,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.AllOf<global::G.AnswerResult, global::G.AnswerResponse2> response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Query { get; } = new(
            name: "query")
        {
            Description = @"The question or query to answer.",
        };

        private global::System.CommandLine.Option<bool?> Text { get; } = new(
            name: "text")
        {
            Description = @"If true, the response includes full text content in the search results",
        };


        public AnswerCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "answer",
            description: @"Performs a search based on the query and generates either a direct answer or a detailed summary with citations, depending on the query type.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Query);
            Options.Add(Text);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var query = parseResult.GetRequiredValue(Query);
            var text = parseResult.GetRequiredValue(Text);

            Validate(
                parseResult: parseResult,
                query: query,
                text: text,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.AnswerAsync(
                query: query,
                text: text,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}