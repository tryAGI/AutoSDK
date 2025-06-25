//HintName: G.Commands.PipelinePublicServiceCreateNamespacePipelineReleaseCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PipelinePublicServiceCreateNamespacePipelineReleaseCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string namespaceId,
            string pipelineId,
            string? id,
            string? description,
            object? metadata,
            string? readme,
            string? rawRecipe,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.CreateNamespacePipelineReleaseResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> NamespaceId { get; } = new(
            name: "namespaceId")
        {
            Description = @"Namespace ID",
        };

        private global::System.CommandLine.Argument<string> PipelineId { get; } = new(
            name: "pipelineId")
        {
            Description = @"Pipeline ID",
        };

        private global::System.CommandLine.Option<string?> Id { get; } = new(
            name: "id")
        {
            Description = @"Release resource ID (used in `name` as the last segment). It must be a
sematic version vX.Y.Z.",
        };

        private new global::System.CommandLine.Option<string?> Description { get; } = new(
            name: "description")
        {
            Description = @"Release description.",
        };

        private global::System.CommandLine.Option<object?> Metadata { get; } = new(
            name: "metadata")
        {
            Description = @"Key-value object with console-related data such as the pipeline builder
layout.",
        };

        private global::System.CommandLine.Option<string?> Readme { get; } = new(
            name: "readme")
        {
            Description = @"README.",
        };

        private global::System.CommandLine.Option<string?> RawRecipe { get; } = new(
            name: "rawRecipe")
        {
            Description = @"Recipe in YAML format describes the components of a pipeline and how they
are connected.",
        };
        public PipelinePublicServiceCreateNamespacePipelineReleaseCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "pipeline",
            description: @"Commits the version of a pipeline, identified by its resource name, which
is formed by the parent namespace and ID of the pipeline.

The authenticated namespace must be the parent of the pipeline in order to
perform this action.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(NamespaceId);
            Arguments.Add(PipelineId);
            Options.Add(Id);
            Options.Add(Description);
            Options.Add(Metadata);
            Options.Add(Readme);
            Options.Add(RawRecipe);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var namespaceId = parseResult.GetRequiredValue(NamespaceId);
            var pipelineId = parseResult.GetRequiredValue(PipelineId);
            var id = parseResult.GetRequiredValue(Id);
            var description = parseResult.GetRequiredValue(Description);
            var metadata = parseResult.GetRequiredValue(Metadata);
            var readme = parseResult.GetRequiredValue(Readme);
            var rawRecipe = parseResult.GetRequiredValue(RawRecipe);

            Validate(
                parseResult: parseResult,
                namespaceId: namespaceId,
                pipelineId: pipelineId,
                id: id,
                description: description,
                metadata: metadata,
                readme: readme,
                rawRecipe: rawRecipe,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.VDP.PipelinePublicServiceCreateNamespacePipelineReleaseAsync(
                namespaceId: namespaceId,
                pipelineId: pipelineId,
                id: id,
                description: description,
                metadata: metadata,
                readme: readme,
                rawRecipe: rawRecipe,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}