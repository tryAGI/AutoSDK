//HintName: G.Commands.RedirectDatasetsRedirectCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class RedirectDatasetsRedirectCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid datasetId,
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


        public RedirectDatasetsRedirectCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "datasets",
            description: @"Create dataset redirect url")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(DatasetId);
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
            var workspaceName = parseResult.GetRequiredValue(WorkspaceName);
            var path = parseResult.GetRequiredValue(Path);

            Validate(
                parseResult: parseResult,
                datasetId: datasetId,
                workspaceName: workspaceName,
                path: path,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Redirect.DatasetsRedirectAsync(
                datasetId: datasetId,
                workspaceName: workspaceName,
                path: path,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}