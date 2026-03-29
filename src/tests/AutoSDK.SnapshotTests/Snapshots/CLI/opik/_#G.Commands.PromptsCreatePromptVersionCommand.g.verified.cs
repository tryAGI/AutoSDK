//HintName: G.Commands.PromptsCreatePromptVersionCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PromptsCreatePromptVersionCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string name,
            global::G.PromptVersionDetail version,
            global::G.CreatePromptVersionDetailTemplateStructure? templateStructure,
            global::System.Collections.Generic.IList<global::System.Guid>? excludeBlueprintUpdateForProjects,
            global::System.Guid? projectId,
            string? projectName,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.PromptVersionDetail response,
            global::System.Threading.CancellationToken cancellationToken);

        private new global::System.CommandLine.Argument<string> Name { get; } = new(
            name: "name")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<global::G.PromptVersionDetail> Version { get; } = new(
            name: "version")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.CreatePromptVersionDetailTemplateStructure?> TemplateStructure { get; } = new(
            name: "templateStructure")
        {
            Description = @"Template structure for the prompt: 'text' or 'chat'. Note: This field is only used when creating a new prompt. If a prompt with the given name already exists, this field is ignored and the existing prompt's template structure is used. Template structure is immutable after prompt creation.",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::System.Guid>?> ExcludeBlueprintUpdateForProjects { get; } = new(
            name: "excludeBlueprintUpdateForProjects")
        {
            Description = @"Optional set of project IDs to exclude from automatic blueprint creation when this prompt version is committed.",
        };

        private global::System.CommandLine.Option<global::System.Guid?> ProjectId { get; } = new(
            name: "projectId")
        {
            Description = @"Project ID. Takes precedence over project_name when both are provided.",
        };

        private global::System.CommandLine.Option<string?> ProjectName { get; } = new(
            name: "projectName")
        {
            Description = @"If provided, scopes the prompt to the specified project. Ignored when project_id is provided.",
        };


        public PromptsCreatePromptVersionCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"Create prompt version")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Name);
            Arguments.Add(Version);
            Options.Add(TemplateStructure);
            Options.Add(ExcludeBlueprintUpdateForProjects);
            Options.Add(ProjectId);
            Options.Add(ProjectName);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var name = parseResult.GetRequiredValue(Name);
            var version = parseResult.GetRequiredValue(Version);
            var templateStructure = parseResult.GetRequiredValue(TemplateStructure);
            var excludeBlueprintUpdateForProjects = parseResult.GetRequiredValue(ExcludeBlueprintUpdateForProjects);
            var projectId = parseResult.GetRequiredValue(ProjectId);
            var projectName = parseResult.GetRequiredValue(ProjectName);

            Validate(
                parseResult: parseResult,
                name: name,
                version: version,
                templateStructure: templateStructure,
                excludeBlueprintUpdateForProjects: excludeBlueprintUpdateForProjects,
                projectId: projectId,
                projectName: projectName,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Prompts.CreatePromptVersionAsync(
                name: name,
                version: version,
                templateStructure: templateStructure,
                excludeBlueprintUpdateForProjects: excludeBlueprintUpdateForProjects,
                projectId: projectId,
                projectName: projectName,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}