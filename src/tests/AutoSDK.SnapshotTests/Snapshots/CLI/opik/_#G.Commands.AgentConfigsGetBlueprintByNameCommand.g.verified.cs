//HintName: G.Commands.AgentConfigsGetBlueprintByNameCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AgentConfigsGetBlueprintByNameCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string name,
            global::System.Guid projectId,
            global::System.Guid? maskId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.AgentBlueprintPublic response,
            global::System.Threading.CancellationToken cancellationToken);

        private new global::System.CommandLine.Argument<string> Name { get; } = new(
            name: "name")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<global::System.Guid> ProjectId { get; } = new(
            name: "projectId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Guid?> MaskId { get; } = new(
            name: "maskId")
        {
            Description = @"",
        };


        public AgentConfigsGetBlueprintByNameCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Retrieves a specific blueprint by its name within a project")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Name);
            Arguments.Add(ProjectId);
            Options.Add(MaskId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var name = parseResult.GetRequiredValue(Name);
            var projectId = parseResult.GetRequiredValue(ProjectId);
            var maskId = parseResult.GetRequiredValue(MaskId);

            Validate(
                parseResult: parseResult,
                name: name,
                projectId: projectId,
                maskId: maskId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.AgentConfigs.GetBlueprintByNameAsync(
                name: name,
                projectId: projectId,
                maskId: maskId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}