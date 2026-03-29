//HintName: G.Commands.OptimizationsUpsertOptimizationCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class OptimizationsUpsertOptimizationCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid? id,
            string? name,
            string datasetName,
            string? projectName,
            global::System.Guid? projectId,
            string objectiveName,
            global::G.OptimizationWriteStatus status,
            global::G.JsonListStringWrite? metadata,
            global::G.OptimizationStudioConfigWrite? studioConfig,
            global::System.DateTime? lastUpdatedAt,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> DatasetName { get; } = new(
            name: "datasetName")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> ObjectiveName { get; } = new(
            name: "objectiveName")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<global::G.OptimizationWriteStatus> Status { get; } = new(
            name: "status")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Guid?> Id { get; } = new(
            name: "id")
        {
            Description = @"",
        };

        private new global::System.CommandLine.Option<string?> Name { get; } = new(
            name: "name")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> ProjectName { get; } = new(
            name: "projectName")
        {
            Description = @"Project name. Creates project if it doesn't exist. Ignored when project_id is provided.",
        };

        private global::System.CommandLine.Option<global::System.Guid?> ProjectId { get; } = new(
            name: "projectId")
        {
            Description = @"Project ID. Takes precedence over project_name when both are provided.",
        };

        private global::System.CommandLine.Option<global::G.JsonListStringWrite?> Metadata { get; } = new(
            name: "metadata")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.OptimizationStudioConfigWrite?> StudioConfig { get; } = new(
            name: "studioConfig")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.DateTime?> LastUpdatedAt { get; } = new(
            name: "lastUpdatedAt")
        {
            Description = @"",
        };


        public OptimizationsUpsertOptimizationCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "upsert",
            description: @"Upsert optimization")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(DatasetName);
            Arguments.Add(ObjectiveName);
            Arguments.Add(Status);
            Options.Add(Id);
            Options.Add(Name);
            Options.Add(ProjectName);
            Options.Add(ProjectId);
            Options.Add(Metadata);
            Options.Add(StudioConfig);
            Options.Add(LastUpdatedAt);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var id = parseResult.GetRequiredValue(Id);
            var name = parseResult.GetRequiredValue(Name);
            var datasetName = parseResult.GetRequiredValue(DatasetName);
            var projectName = parseResult.GetRequiredValue(ProjectName);
            var projectId = parseResult.GetRequiredValue(ProjectId);
            var objectiveName = parseResult.GetRequiredValue(ObjectiveName);
            var status = parseResult.GetRequiredValue(Status);
            var metadata = parseResult.GetRequiredValue(Metadata);
            var studioConfig = parseResult.GetRequiredValue(StudioConfig);
            var lastUpdatedAt = parseResult.GetRequiredValue(LastUpdatedAt);

            Validate(
                parseResult: parseResult,
                id: id,
                name: name,
                datasetName: datasetName,
                projectName: projectName,
                projectId: projectId,
                objectiveName: objectiveName,
                status: status,
                metadata: metadata,
                studioConfig: studioConfig,
                lastUpdatedAt: lastUpdatedAt,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Optimizations.UpsertOptimizationAsync(
                id: id,
                name: name,
                datasetName: datasetName,
                projectName: projectName,
                projectId: projectId,
                objectiveName: objectiveName,
                status: status,
                metadata: metadata,
                studioConfig: studioConfig,
                lastUpdatedAt: lastUpdatedAt,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}