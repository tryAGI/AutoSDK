//HintName: G.Commands.DatasetsCreateDatasetCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DatasetsCreateDatasetCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid? id,
            string name,
            global::System.Guid? projectId,
            string? projectName,
            global::G.DatasetWriteType? type,
            global::G.DatasetWriteVisibility? visibility,
            global::System.Collections.Generic.IList<string>? tags,
            string? description,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private new global::System.CommandLine.Argument<string> Name { get; } = new(
            name: "name")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Guid?> Id { get; } = new(
            name: "id")
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
            Description = @"For project scope, specify either project_id or project_name. If project_name is provided and the project does not exist, it will be created. Ignored when project_id is provided. If neither is provided, the dataset is created at workspace level.",
        };

        private global::System.CommandLine.Option<global::G.DatasetWriteType?> Type { get; } = new(
            name: "type")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.DatasetWriteVisibility?> Visibility { get; } = new(
            name: "visibility")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> Tags { get; } = new(
            name: "tags")
        {
            Description = @"",
        };

        private new global::System.CommandLine.Option<string?> Description { get; } = new(
            name: "description")
        {
            Description = @"",
        };


        public DatasetsCreateDatasetCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"Create dataset")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Name);
            Options.Add(Id);
            Options.Add(ProjectId);
            Options.Add(ProjectName);
            Options.Add(Type);
            Options.Add(Visibility);
            Options.Add(Tags);
            Options.Add(Description);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var id = parseResult.GetRequiredValue(Id);
            var name = parseResult.GetRequiredValue(Name);
            var projectId = parseResult.GetRequiredValue(ProjectId);
            var projectName = parseResult.GetRequiredValue(ProjectName);
            var type = parseResult.GetRequiredValue(Type);
            var visibility = parseResult.GetRequiredValue(Visibility);
            var tags = parseResult.GetRequiredValue(Tags);
            var description = parseResult.GetRequiredValue(Description);

            Validate(
                parseResult: parseResult,
                id: id,
                name: name,
                projectId: projectId,
                projectName: projectName,
                type: type,
                visibility: visibility,
                tags: tags,
                description: description,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Datasets.CreateDatasetAsync(
                id: id,
                name: name,
                projectId: projectId,
                projectName: projectName,
                type: type,
                visibility: visibility,
                tags: tags,
                description: description,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}