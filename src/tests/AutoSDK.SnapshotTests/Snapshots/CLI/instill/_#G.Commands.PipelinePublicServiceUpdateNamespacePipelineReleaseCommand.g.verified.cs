//HintName: G.Commands.PipelinePublicServiceUpdateNamespacePipelineReleaseCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PipelinePublicServiceUpdateNamespacePipelineReleaseCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string namespaceId,
            string pipelineId,
            string releaseId,
            string? id,
            string? description,
            object? metadata,
            string? readme,
            string? rawRecipe,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.UpdateNamespacePipelineReleaseResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> NamespaceId { get; } = new(
            name: "namespaceId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> PipelineId { get; } = new(
            name: "pipelineId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> ReleaseId { get; } = new(
            name: "releaseId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Id { get; } = new(
            name: "id")
        {
            Description = "",
        };

        private new global::System.CommandLine.Option<string?> Description { get; } = new(
            name: "description")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<object?> Metadata { get; } = new(
            name: "metadata")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Readme { get; } = new(
            name: "readme")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> RawRecipe { get; } = new(
            name: "rawRecipe")
        {
            Description = "",
        };
        public PipelinePublicServiceUpdateNamespacePipelineReleaseCommand(G.IApi client) : base(
            name: "pipeline",
            description: @"Updates the details of a pipeline release, where the pipeline is
identified by its resource name, formed by its parent namespace and ID.

The authenticated namespace must be the parent of the pipeline in order to
perform this action.")
        {
            _client = client;

            Arguments.Add(NamespaceId);
            Arguments.Add(PipelineId);
            Arguments.Add(ReleaseId);
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
            var releaseId = parseResult.GetRequiredValue(ReleaseId);
            var id = parseResult.GetRequiredValue(Id);
            var description = parseResult.GetRequiredValue(Description);
            var metadata = parseResult.GetRequiredValue(Metadata);
            var readme = parseResult.GetRequiredValue(Readme);
            var rawRecipe = parseResult.GetRequiredValue(RawRecipe);

            Validate(
                parseResult: parseResult,
                namespaceId: namespaceId,
                pipelineId: pipelineId,
                releaseId: releaseId,
                id: id,
                description: description,
                metadata: metadata,
                readme: readme,
                rawRecipe: rawRecipe,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.VDP.PipelinePublicServiceUpdateNamespacePipelineReleaseAsync(
                namespaceId: namespaceId,
                pipelineId: pipelineId,
                releaseId: releaseId,
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