//HintName: G.Commands.PipelinePublicServiceUpdateNamespacePipelineCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PipelinePublicServiceUpdateNamespacePipelineCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string namespaceId,
            string pipelineId,
            string? id,
            string? description,
            object recipe,
            global::G.Sharing? sharing,
            object? metadata,
            string? readme,
            global::System.Collections.Generic.IList<string>? tags,
            string? rawRecipe,
            string? sourceUrl,
            string? documentationUrl,
            string? license,
            string? profileImage,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.UpdateNamespacePipelineResponse response,
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

        private global::System.CommandLine.Argument<object> Recipe { get; } = new(
            name: "recipe")
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

        private global::System.CommandLine.Option<global::G.Sharing?> Sharing { get; } = new(
            name: "sharing")
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

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> Tags { get; } = new(
            name: "tags")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> RawRecipe { get; } = new(
            name: "rawRecipe")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> SourceUrl { get; } = new(
            name: "sourceUrl")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> DocumentationUrl { get; } = new(
            name: "documentationUrl")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> License { get; } = new(
            name: "license")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> ProfileImage { get; } = new(
            name: "profileImage")
        {
            Description = "",
        };
        public PipelinePublicServiceUpdateNamespacePipelineCommand(G.IApi client) : base(
            name: "pipeline",
            description: @"Udpates a pipeline, accessing it by its resource name, which is defined by
the parent namespace and the ID of the pipeline. The authenticated namespace must be
the parent of the pipeline in order to modify it.

In REST requests, only the supplied pipeline fields will be taken into
account when updating the resource.")
        {
            _client = client;

            Arguments.Add(NamespaceId);
            Arguments.Add(PipelineId);
            Arguments.Add(Recipe);
            Options.Add(Id);
            Options.Add(Description);
            Options.Add(Sharing);
            Options.Add(Metadata);
            Options.Add(Readme);
            Options.Add(Tags);
            Options.Add(RawRecipe);
            Options.Add(SourceUrl);
            Options.Add(DocumentationUrl);
            Options.Add(License);
            Options.Add(ProfileImage);

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
            var recipe = parseResult.GetRequiredValue(Recipe);
            var sharing = parseResult.GetRequiredValue(Sharing);
            var metadata = parseResult.GetRequiredValue(Metadata);
            var readme = parseResult.GetRequiredValue(Readme);
            var tags = parseResult.GetRequiredValue(Tags);
            var rawRecipe = parseResult.GetRequiredValue(RawRecipe);
            var sourceUrl = parseResult.GetRequiredValue(SourceUrl);
            var documentationUrl = parseResult.GetRequiredValue(DocumentationUrl);
            var license = parseResult.GetRequiredValue(License);
            var profileImage = parseResult.GetRequiredValue(ProfileImage);

            Validate(
                parseResult: parseResult,
                namespaceId: namespaceId,
                pipelineId: pipelineId,
                id: id,
                description: description,
                recipe: recipe,
                sharing: sharing,
                metadata: metadata,
                readme: readme,
                tags: tags,
                rawRecipe: rawRecipe,
                sourceUrl: sourceUrl,
                documentationUrl: documentationUrl,
                license: license,
                profileImage: profileImage,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.VDP.PipelinePublicServiceUpdateNamespacePipelineAsync(
                namespaceId: namespaceId,
                pipelineId: pipelineId,
                id: id,
                description: description,
                recipe: recipe,
                sharing: sharing,
                metadata: metadata,
                readme: readme,
                tags: tags,
                rawRecipe: rawRecipe,
                sourceUrl: sourceUrl,
                documentationUrl: documentationUrl,
                license: license,
                profileImage: profileImage,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}