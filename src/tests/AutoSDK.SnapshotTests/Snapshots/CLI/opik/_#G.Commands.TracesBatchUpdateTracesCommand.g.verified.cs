//HintName: G.Commands.TracesBatchUpdateTracesCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TracesBatchUpdateTracesCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::System.Guid> ids,
            global::G.TraceUpdate update,
            bool? mergeTags,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<global::System.Guid>> Ids { get; } = new(
            name: "ids")
        {
            Description = @"List of trace IDs to update (max 1000)",
        };

        private global::System.CommandLine.Argument<global::G.TraceUpdate> Update { get; } = new(
            name: "update")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<bool?> MergeTags { get; } = new(
            name: "mergeTags")
        {
            Description = @"If true, merge tags with existing tags instead of replacing them. Default: false",
        };


        public TracesBatchUpdateTracesCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "batch",
            description: @"Update multiple traces")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Ids);
            Arguments.Add(Update);
            Options.Add(MergeTags);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var ids = parseResult.GetRequiredValue(Ids);
            var update = parseResult.GetRequiredValue(Update);
            var mergeTags = parseResult.GetRequiredValue(MergeTags);

            Validate(
                parseResult: parseResult,
                ids: ids,
                update: update,
                mergeTags: mergeTags,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Traces.BatchUpdateTracesAsync(
                ids: ids,
                update: update,
                mergeTags: mergeTags,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}