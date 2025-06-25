//HintName: G.Commands.BatchObjectsDeleteCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class BatchObjectsDeleteCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.BatchObjectsDeleteConsistencyLevel? consistencyLevel,
            string? tenant,
            global::G.BatchDeleteMatch? match,
            global::G.BatchDeleteOutput? output,
            bool? dryRun,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.BatchDeleteResponse response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<global::G.BatchObjectsDeleteConsistencyLevel?> ConsistencyLevel { get; } = new(
            name: "consistencyLevel")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Tenant { get; } = new(
            name: "tenant")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.BatchDeleteMatch?> Match { get; } = new(
            name: "match")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.BatchDeleteOutput?> Output { get; } = new(
            name: "output")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> DryRun { get; } = new(
            name: "dryRun")
        {
            Description = "",
        };
        public BatchObjectsDeleteCommand(G.IApi client) : base(
            name: "batch",
            description: @"Batch delete objects that match a particular filter. <br/><br/>The request body takes a single `where` filter and will delete all objects matched. <br/><br/>Note that there is a limit to the number of objects to be deleted at once using this filter, in order to protect against unexpected memory surges and very-long-running requests. The default limit is 10,000 and may be configured by setting the `QUERY_MAXIMUM_RESULTS` environment variable. <br/><br/>Objects are deleted in the same order that they would be returned in an equivalent Get query. To delete more objects than the limit, run the same query multiple times.")
        {
            _client = client;

            Options.Add(ConsistencyLevel);
            Options.Add(Tenant);
            Options.Add(Match);
            Options.Add(Output);
            Options.Add(DryRun);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var consistencyLevel = parseResult.GetRequiredValue(ConsistencyLevel);
            var tenant = parseResult.GetRequiredValue(Tenant);
            var match = parseResult.GetRequiredValue(Match);
            var output = parseResult.GetRequiredValue(Output);
            var dryRun = parseResult.GetRequiredValue(DryRun);

            Validate(
                parseResult: parseResult,
                consistencyLevel: consistencyLevel,
                tenant: tenant,
                match: match,
                output: output,
                dryRun: dryRun,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Batch.BatchObjectsDeleteAsync(
                consistencyLevel: consistencyLevel,
                tenant: tenant,
                match: match,
                output: output,
                dryRun: dryRun,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}