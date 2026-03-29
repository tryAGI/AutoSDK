//HintName: G.Commands.AgentConfigsCreateOrUpdateEnvsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AgentConfigsCreateOrUpdateEnvsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid projectId,
            global::System.Collections.Generic.IList<global::G.AgentConfigEnv> envs,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> ProjectId { get; } = new(
            name: "projectId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<global::G.AgentConfigEnv>> Envs { get; } = new(
            name: "envs")
        {
            Description = @"",
        };



        public AgentConfigsCreateOrUpdateEnvsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"Creates or updates environment-to-blueprint mappings")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(ProjectId);
            Arguments.Add(Envs);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var projectId = parseResult.GetRequiredValue(ProjectId);
            var envs = parseResult.GetRequiredValue(Envs);

            Validate(
                parseResult: parseResult,
                projectId: projectId,
                envs: envs,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.AgentConfigs.CreateOrUpdateEnvsAsync(
                projectId: projectId,
                envs: envs,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}