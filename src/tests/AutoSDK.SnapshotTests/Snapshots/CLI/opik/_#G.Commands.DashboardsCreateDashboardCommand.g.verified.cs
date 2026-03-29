//HintName: G.Commands.DashboardsCreateDashboardCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DashboardsCreateDashboardCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid? projectId,
            string? projectName,
            string name,
            global::G.DashboardWriteType? type,
            string? description,
            global::G.JsonNodeWrite config,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.DashboardPublic response,
            global::System.Threading.CancellationToken cancellationToken);

        private new global::System.CommandLine.Argument<string> Name { get; } = new(
            name: "name")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<global::G.JsonNodeWrite> Config { get; } = new(
            name: "config")
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
            Description = @"For project scope, specify either project_id or project_name. If project_name is provided and the project does not exist, it will be created. Ignored when project_id is provided. If neither is provided, the dashboard is created at workspace level.",
        };

        private global::System.CommandLine.Option<global::G.DashboardWriteType?> Type { get; } = new(
            name: "type")
        {
            Description = @"",
        };

        private new global::System.CommandLine.Option<string?> Description { get; } = new(
            name: "description")
        {
            Description = @"",
        };


        public DashboardsCreateDashboardCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"Create a new dashboard in a workspace")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Name);
            Arguments.Add(Config);
            Options.Add(ProjectId);
            Options.Add(ProjectName);
            Options.Add(Type);
            Options.Add(Description);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var projectId = parseResult.GetRequiredValue(ProjectId);
            var projectName = parseResult.GetRequiredValue(ProjectName);
            var name = parseResult.GetRequiredValue(Name);
            var type = parseResult.GetRequiredValue(Type);
            var description = parseResult.GetRequiredValue(Description);
            var config = parseResult.GetRequiredValue(Config);

            Validate(
                parseResult: parseResult,
                projectId: projectId,
                projectName: projectName,
                name: name,
                type: type,
                description: description,
                config: config,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Dashboards.CreateDashboardAsync(
                projectId: projectId,
                projectName: projectName,
                name: name,
                type: type,
                description: description,
                config: config,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}