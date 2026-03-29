//HintName: G.Commands.ProjectsUpdateProjectCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ProjectsUpdateProjectCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid id,
            string? name,
            string? description,
            global::G.ProjectUpdateVisibility? visibility,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> Id { get; } = new(
            name: "id")
        {
            Description = @"",
        };

        private new global::System.CommandLine.Option<string?> Name { get; } = new(
            name: "name")
        {
            Description = @"",
        };

        private new global::System.CommandLine.Option<string?> Description { get; } = new(
            name: "description")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.ProjectUpdateVisibility?> Visibility { get; } = new(
            name: "visibility")
        {
            Description = @"",
        };


        public ProjectsUpdateProjectCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "update",
            description: @"Update project by id")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Id);
            Options.Add(Name);
            Options.Add(Description);
            Options.Add(Visibility);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var id = parseResult.GetRequiredValue(Id);
            var name = parseResult.GetRequiredValue(Name);
            var description = parseResult.GetRequiredValue(Description);
            var visibility = parseResult.GetRequiredValue(Visibility);

            Validate(
                parseResult: parseResult,
                id: id,
                name: name,
                description: description,
                visibility: visibility,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Projects.UpdateProjectAsync(
                id: id,
                name: name,
                description: description,
                visibility: visibility,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}