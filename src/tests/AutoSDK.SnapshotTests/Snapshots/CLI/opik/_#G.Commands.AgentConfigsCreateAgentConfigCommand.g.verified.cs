//HintName: G.Commands.AgentConfigsCreateAgentConfigCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AgentConfigsCreateAgentConfigCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid? projectId,
            string? projectName,
            global::System.Guid? id,
            global::G.AgentBlueprintWrite blueprint,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.AgentBlueprintWrite> Blueprint { get; } = new(
            name: "blueprint")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Guid?> ProjectId { get; } = new(
            name: "projectId")
        {
            Description = @"Project ID. Either project_id or project_name must be provided",
        };

        private global::System.CommandLine.Option<string?> ProjectName { get; } = new(
            name: "projectName")
        {
            Description = @"Project name. Either project_id or project_name must be provided",
        };

        private global::System.CommandLine.Option<global::System.Guid?> Id { get; } = new(
            name: "id")
        {
            Description = @"Agent config ID. Generated automatically if not provided",
        };


        public AgentConfigsCreateAgentConfigCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"Creates a new optimizer config with initial blueprint. Fails if the project already has a config.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Blueprint);
            Options.Add(ProjectId);
            Options.Add(ProjectName);
            Options.Add(Id);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var projectId = parseResult.GetRequiredValue(ProjectId);
            var projectName = parseResult.GetRequiredValue(ProjectName);
            var id = parseResult.GetRequiredValue(Id);
            var blueprint = parseResult.GetRequiredValue(Blueprint);

            Validate(
                parseResult: parseResult,
                projectId: projectId,
                projectName: projectName,
                id: id,
                blueprint: blueprint,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.AgentConfigs.CreateAgentConfigAsync(
                projectId: projectId,
                projectName: projectName,
                id: id,
                blueprint: blueprint,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}