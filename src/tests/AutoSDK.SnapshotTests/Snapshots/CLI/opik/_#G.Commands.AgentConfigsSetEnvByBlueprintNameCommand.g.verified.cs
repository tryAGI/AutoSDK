//HintName: G.Commands.AgentConfigsSetEnvByBlueprintNameCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AgentConfigsSetEnvByBlueprintNameCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string envName,
            global::System.Guid projectId,
            string blueprintName,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
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

        private global::System.CommandLine.Argument<string> BlueprintName { get; } = new(
            name: "blueprintName")
        {
            Description = @"",
        };



        public AgentConfigsSetEnvByBlueprintNameCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "set",
            description: @"Sets an environment to point to a blueprint identified by name")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(EnvName);
            Arguments.Add(ProjectId);
            Arguments.Add(BlueprintName);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var envName = parseResult.GetRequiredValue(EnvName);
            var projectId = parseResult.GetRequiredValue(ProjectId);
            var blueprintName = parseResult.GetRequiredValue(BlueprintName);

            Validate(
                parseResult: parseResult,
                envName: envName,
                projectId: projectId,
                blueprintName: blueprintName,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.AgentConfigs.SetEnvByBlueprintNameAsync(
                envName: envName,
                projectId: projectId,
                blueprintName: blueprintName,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}