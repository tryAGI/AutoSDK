//HintName: G.Commands.PromptsCreatePromptCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PromptsCreatePromptCommand : global::System.CommandLine.Command
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
            string? description,
            string? template,
            global::G.JsonNodeWrite? metadata,
            string? changeDescription,
            global::G.PromptWriteType? type,
            global::G.PromptWriteTemplateStructure? templateStructure,
            global::System.Collections.Generic.IList<string>? tags,
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
            Description = @"For project scope, specify either project_id or project_name. If project_name is provided and the project does not exist, it will be created. Ignored when project_id is provided. If neither is provided, the prompt is created at workspace level.",
        };

        private new global::System.CommandLine.Option<string?> Description { get; } = new(
            name: "description")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Template { get; } = new(
            name: "template")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.JsonNodeWrite?> Metadata { get; } = new(
            name: "metadata")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> ChangeDescription { get; } = new(
            name: "changeDescription")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.PromptWriteType?> Type { get; } = new(
            name: "type")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.PromptWriteTemplateStructure?> TemplateStructure { get; } = new(
            name: "templateStructure")
        {
            Description = @"Template structure type: 'text' or 'chat'. Immutable after creation.",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> Tags { get; } = new(
            name: "tags")
        {
            Description = @"",
        };


        public PromptsCreatePromptCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"Create prompt")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Name);
            Options.Add(Id);
            Options.Add(ProjectId);
            Options.Add(ProjectName);
            Options.Add(Description);
            Options.Add(Template);
            Options.Add(Metadata);
            Options.Add(ChangeDescription);
            Options.Add(Type);
            Options.Add(TemplateStructure);
            Options.Add(Tags);

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
            var description = parseResult.GetRequiredValue(Description);
            var template = parseResult.GetRequiredValue(Template);
            var metadata = parseResult.GetRequiredValue(Metadata);
            var changeDescription = parseResult.GetRequiredValue(ChangeDescription);
            var type = parseResult.GetRequiredValue(Type);
            var templateStructure = parseResult.GetRequiredValue(TemplateStructure);
            var tags = parseResult.GetRequiredValue(Tags);

            Validate(
                parseResult: parseResult,
                id: id,
                name: name,
                projectId: projectId,
                projectName: projectName,
                description: description,
                template: template,
                metadata: metadata,
                changeDescription: changeDescription,
                type: type,
                templateStructure: templateStructure,
                tags: tags,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Prompts.CreatePromptAsync(
                id: id,
                name: name,
                projectId: projectId,
                projectName: projectName,
                description: description,
                template: template,
                metadata: metadata,
                changeDescription: changeDescription,
                type: type,
                templateStructure: templateStructure,
                tags: tags,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}