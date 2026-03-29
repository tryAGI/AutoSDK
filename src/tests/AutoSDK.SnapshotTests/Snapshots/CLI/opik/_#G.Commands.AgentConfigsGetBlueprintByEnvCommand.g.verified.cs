//HintName: G.Commands.AgentConfigsGetBlueprintByEnvCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AgentConfigsGetBlueprintByEnvCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string envName,
            global::System.Guid projectId,
            global::System.Guid? maskId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.AgentBlueprintPublic response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> EnvName { get; } = new(
            name: "envName")
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


        public AgentConfigsGetBlueprintByEnvCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Retrieves the blueprint associated with a specific environment")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(EnvName);
            Arguments.Add(ProjectId);
            Options.Add(MaskId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var envName = parseResult.GetRequiredValue(EnvName);
            var projectId = parseResult.GetRequiredValue(ProjectId);
            var maskId = parseResult.GetRequiredValue(MaskId);

            Validate(
                parseResult: parseResult,
                envName: envName,
                projectId: projectId,
                maskId: maskId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.AgentConfigs.GetBlueprintByEnvAsync(
                envName: envName,
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