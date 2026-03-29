//HintName: G.Commands.DatasetsMarkDatasetExportJobViewedCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DatasetsMarkDatasetExportJobViewedCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid jobId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> JobId { get; } = new(
            name: "jobId")
        {
            Description = @"",
        };



        public DatasetsMarkDatasetExportJobViewedCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "mark",
            description: @"Marks a dataset export job as viewed by setting the viewed_at timestamp. This is used to track that a user has seen a failed job's error message. This operation is idempotent.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(JobId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var jobId = parseResult.GetRequiredValue(JobId);

            Validate(
                parseResult: parseResult,
                jobId: jobId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Datasets.MarkDatasetExportJobViewedAsync(
                jobId: jobId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}