//HintName: G.Commands.ListPaginatedFineTuningJobsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ListPaginatedFineTuningJobsCommand : global::System.CommandLine.Command
    {
        private readonly G.IOpenAiClient _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? after,
            int? limit,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ListPaginatedFineTuningJobsResponse response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<string?> After { get; } = new(
            name: "after")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> Limit { get; } = new(
            name: "limit")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.Dictionary<string, string>?> Metadata { get; } = new(
            name: "metadata")
        {
            Description = "",
        };
        public ListPaginatedFineTuningJobsCommand(G.IOpenAiClient client) : base(
            name: "list",
            description: @"")
        {
            _client = client;

            Options.Add(After);
            Options.Add(Limit);
            Options.Add(Metadata);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var after = parseResult.GetRequiredValue(After);
            var limit = parseResult.GetRequiredValue(Limit);
            var metadata = parseResult.GetRequiredValue(Metadata);

            Validate(
                parseResult: parseResult,
                after: after,
                limit: limit,
                metadata: metadata,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.FineTuning.ListPaginatedFineTuningJobsAsync(
                after: after,
                limit: limit,
                metadata: metadata,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}