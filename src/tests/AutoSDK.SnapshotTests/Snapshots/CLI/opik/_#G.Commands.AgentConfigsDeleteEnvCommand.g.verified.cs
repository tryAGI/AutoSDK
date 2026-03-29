//HintName: G.Commands.AgentConfigsDeleteEnvCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AgentConfigsDeleteEnvCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string envName,
            global::System.Guid projectId,
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



        public AgentConfigsDeleteEnvCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "delete",
            description: @"Soft-deletes an environment by setting its ended_at timestamp")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(EnvName);
            Arguments.Add(ProjectId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var envName = parseResult.GetRequiredValue(EnvName);
            var projectId = parseResult.GetRequiredValue(ProjectId);

            Validate(
                parseResult: parseResult,
                envName: envName,
                projectId: projectId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.AgentConfigs.DeleteEnvAsync(
                envName: envName,
                projectId: projectId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}