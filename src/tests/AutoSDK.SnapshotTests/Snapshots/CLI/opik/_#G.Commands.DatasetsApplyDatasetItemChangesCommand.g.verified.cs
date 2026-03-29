//HintName: G.Commands.DatasetsApplyDatasetItemChangesCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DatasetsApplyDatasetItemChangesCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid id,
            bool? @override,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.DatasetVersionPublic response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> Id { get; } = new(
            name: "id")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<bool?> Override { get; } = new(
            name: "@override")
        {
            Description = @"",
        };


        public DatasetsApplyDatasetItemChangesCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "apply",
            description: @"Apply delta changes (add, edit, delete) to a dataset version with conflict detection.

This endpoint:
- Creates a new version with the applied changes
- Validates that baseVersion matches the latest version (unless override=true)
- Returns 409 Conflict if baseVersion is stale and override is not set

Use `override=true` query parameter to force version creation even with stale baseVersion.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Id);
            Options.Add(Override);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var id = parseResult.GetRequiredValue(Id);
            var @override = parseResult.GetRequiredValue(Override);

            Validate(
                parseResult: parseResult,
                id: id,
                @override: @override,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Datasets.ApplyDatasetItemChangesAsync(
                id: id,
                @override: @override,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}