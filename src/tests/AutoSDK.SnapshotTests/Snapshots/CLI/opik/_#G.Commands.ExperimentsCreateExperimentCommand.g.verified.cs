//HintName: G.Commands.ExperimentsCreateExperimentCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ExperimentsCreateExperimentCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid? id,
            string? datasetName,
            global::System.Guid? projectId,
            string? projectName,
            string? name,
            global::G.JsonListStringWrite? metadata,
            global::System.Collections.Generic.IList<string>? tags,
            global::G.ExperimentWriteType? type,
            global::G.ExperimentWriteEvaluationMethod? evaluationMethod,
            global::System.Guid? optimizationId,
            global::G.ExperimentWriteStatus? status,
            global::System.Collections.Generic.IList<global::G.ExperimentScoreWrite>? experimentScores,
            global::G.PromptVersionLinkWrite? promptVersion,
            global::System.Collections.Generic.IList<global::G.PromptVersionLinkWrite>? promptVersions,
            global::System.Guid? datasetVersionId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<global::System.Guid?> Id { get; } = new(
            name: "id")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> DatasetName { get; } = new(
            name: "datasetName")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Guid?> ProjectId { get; } = new(
            name: "projectId")
        {
            Description = @"Project ID. Takes precedence over project_name when both are provided.",
        };

        private global::System.CommandLine.Option<string?> ProjectName { get; } = new(
            name: "projectName")
        {
            Description = @"Project name. Creates project if it doesn't exist. Ignored when project_id is provided.",
        };

        private new global::System.CommandLine.Option<string?> Name { get; } = new(
            name: "name")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.JsonListStringWrite?> Metadata { get; } = new(
            name: "metadata")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> Tags { get; } = new(
            name: "tags")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.ExperimentWriteType?> Type { get; } = new(
            name: "type")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.ExperimentWriteEvaluationMethod?> EvaluationMethod { get; } = new(
            name: "evaluationMethod")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Guid?> OptimizationId { get; } = new(
            name: "optimizationId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.ExperimentWriteStatus?> Status { get; } = new(
            name: "status")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.ExperimentScoreWrite>?> ExperimentScores { get; } = new(
            name: "experimentScores")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.PromptVersionLinkWrite?> PromptVersion { get; } = new(
            name: "promptVersion")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.PromptVersionLinkWrite>?> PromptVersions { get; } = new(
            name: "promptVersions")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Guid?> DatasetVersionId { get; } = new(
            name: "datasetVersionId")
        {
            Description = @"ID of the dataset version this experiment is linked to. If not provided at creation, experiment will be automatically linked to the latest version.",
        };


        public ExperimentsCreateExperimentCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"Create experiment")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(Id);
            Options.Add(DatasetName);
            Options.Add(ProjectId);
            Options.Add(ProjectName);
            Options.Add(Name);
            Options.Add(Metadata);
            Options.Add(Tags);
            Options.Add(Type);
            Options.Add(EvaluationMethod);
            Options.Add(OptimizationId);
            Options.Add(Status);
            Options.Add(ExperimentScores);
            Options.Add(PromptVersion);
            Options.Add(PromptVersions);
            Options.Add(DatasetVersionId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var id = parseResult.GetRequiredValue(Id);
            var datasetName = parseResult.GetRequiredValue(DatasetName);
            var projectId = parseResult.GetRequiredValue(ProjectId);
            var projectName = parseResult.GetRequiredValue(ProjectName);
            var name = parseResult.GetRequiredValue(Name);
            var metadata = parseResult.GetRequiredValue(Metadata);
            var tags = parseResult.GetRequiredValue(Tags);
            var type = parseResult.GetRequiredValue(Type);
            var evaluationMethod = parseResult.GetRequiredValue(EvaluationMethod);
            var optimizationId = parseResult.GetRequiredValue(OptimizationId);
            var status = parseResult.GetRequiredValue(Status);
            var experimentScores = parseResult.GetRequiredValue(ExperimentScores);
            var promptVersion = parseResult.GetRequiredValue(PromptVersion);
            var promptVersions = parseResult.GetRequiredValue(PromptVersions);
            var datasetVersionId = parseResult.GetRequiredValue(DatasetVersionId);

            Validate(
                parseResult: parseResult,
                id: id,
                datasetName: datasetName,
                projectId: projectId,
                projectName: projectName,
                name: name,
                metadata: metadata,
                tags: tags,
                type: type,
                evaluationMethod: evaluationMethod,
                optimizationId: optimizationId,
                status: status,
                experimentScores: experimentScores,
                promptVersion: promptVersion,
                promptVersions: promptVersions,
                datasetVersionId: datasetVersionId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Experiments.CreateExperimentAsync(
                id: id,
                datasetName: datasetName,
                projectId: projectId,
                projectName: projectName,
                name: name,
                metadata: metadata,
                tags: tags,
                type: type,
                evaluationMethod: evaluationMethod,
                optimizationId: optimizationId,
                status: status,
                experimentScores: experimentScores,
                promptVersion: promptVersion,
                promptVersions: promptVersions,
                datasetVersionId: datasetVersionId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}