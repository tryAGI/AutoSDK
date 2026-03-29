//HintName: G.Commands.RunnersCreateJobCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class RunnersCreateJobCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string agentName,
            global::G.JsonNode? inputs,
            global::System.Guid projectId,
            global::System.Guid? maskId,
            global::G.LocalRunnerJobMetadata? metadata,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> AgentName { get; } = new(
            name: "agentName")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<global::System.Guid> ProjectId { get; } = new(
            name: "projectId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.JsonNode?> Inputs { get; } = new(
            name: "inputs")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Guid?> MaskId { get; } = new(
            name: "maskId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.LocalRunnerJobMetadata?> Metadata { get; } = new(
            name: "metadata")
        {
            Description = @"",
        };


        public RunnersCreateJobCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"Create a local runner job and enqueue it for execution")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(AgentName);
            Arguments.Add(ProjectId);
            Options.Add(Inputs);
            Options.Add(MaskId);
            Options.Add(Metadata);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var agentName = parseResult.GetRequiredValue(AgentName);
            var inputs = parseResult.GetRequiredValue(Inputs);
            var projectId = parseResult.GetRequiredValue(ProjectId);
            var maskId = parseResult.GetRequiredValue(MaskId);
            var metadata = parseResult.GetRequiredValue(Metadata);

            Validate(
                parseResult: parseResult,
                agentName: agentName,
                inputs: inputs,
                projectId: projectId,
                maskId: maskId,
                metadata: metadata,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Runners.CreateJobAsync(
                agentName: agentName,
                inputs: inputs,
                projectId: projectId,
                maskId: maskId,
                metadata: metadata,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}