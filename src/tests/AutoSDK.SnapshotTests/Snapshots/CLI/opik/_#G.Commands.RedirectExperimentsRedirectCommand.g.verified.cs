//HintName: G.Commands.RedirectExperimentsRedirectCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class RedirectExperimentsRedirectCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid datasetId,
            global::System.Guid experimentId,
            string? workspaceName,
            string path,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> DatasetId { get; } = new(
            name: "datasetId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<global::System.Guid> ExperimentId { get; } = new(
            name: "experimentId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> Path { get; } = new(
            name: "path")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> WorkspaceName { get; } = new(
            name: "workspaceName")
        {
            Description = @"",
        };


        public RedirectExperimentsRedirectCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "experiments",
            description: @"Create experiment redirect url")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(DatasetId);
            Arguments.Add(ExperimentId);
            Arguments.Add(Path);
            Options.Add(WorkspaceName);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var datasetId = parseResult.GetRequiredValue(DatasetId);
            var experimentId = parseResult.GetRequiredValue(ExperimentId);
            var workspaceName = parseResult.GetRequiredValue(WorkspaceName);
            var path = parseResult.GetRequiredValue(Path);

            Validate(
                parseResult: parseResult,
                datasetId: datasetId,
                experimentId: experimentId,
                workspaceName: workspaceName,
                path: path,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Redirect.ExperimentsRedirectAsync(
                datasetId: datasetId,
                experimentId: experimentId,
                workspaceName: workspaceName,
                path: path,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}