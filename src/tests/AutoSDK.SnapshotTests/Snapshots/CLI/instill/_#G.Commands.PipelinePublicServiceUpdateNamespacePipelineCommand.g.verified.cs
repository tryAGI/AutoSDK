//HintName: G.Commands.PipelinePublicServiceUpdateNamespacePipelineCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PipelinePublicServiceUpdateNamespacePipelineCommand : global::System.CommandLine.Command
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
            Description = @"Namespace ID",
        };

        private global::System.CommandLine.Argument<string> PipelineId { get; } = new(
            name: "pipelineId")
        {
            Description = @"Pipeline ID",
        };

        private global::System.CommandLine.Argument<object> Recipe { get; } = new(
            name: "recipe")
        {
            Description = @"Recipe describes the components of a Pipeline and how they are connected.",
        };

        private global::System.CommandLine.Option<string?> Id { get; } = new(
            name: "id")
        {
            Description = @"Pipeline resource ID (used in `name` as the last segment). This conforms
to RFC-1034, which restricts to letters, numbers, and hyphen, with the
first character a letter, the last a letter or a number, and a 63
character maximum.",
        };

        private new global::System.CommandLine.Option<string?> Description { get; } = new(
            name: "description")
        {
            Description = @"Pipeline description.",
        };

        private global::System.CommandLine.Option<global::G.Sharing?> Sharing { get; } = new(
            name: "sharing")
        {
            Description = @"Pipeline sharing information.",
        };

        private global::System.CommandLine.Option<object?> Metadata { get; } = new(
            name: "metadata")
        {
            Description = @"Metadata holds console-related data such as the pipeline builder layout.",
        };

        private global::System.CommandLine.Option<string?> Readme { get; } = new(
            name: "readme")
        {
            Description = @"README holds the pipeline documentation.",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> Tags { get; } = new(
            name: "tags")
        {
            Description = @"Tags.",
        };

        private global::System.CommandLine.Option<string?> RawRecipe { get; } = new(
            name: "rawRecipe")
        {
            Description = @"Recipe in YAML format describes the components of a pipeline and how they
are connected.",
        };

        private global::System.CommandLine.Option<string?> SourceUrl { get; } = new(
            name: "sourceUrl")
        {
            Description = @"A link to the source code of the pipeline (e.g. to a GitHub repository).",
        };

        private global::System.CommandLine.Option<string?> DocumentationUrl { get; } = new(
            name: "documentationUrl")
        {
            Description = @"A link to any extra information.",
        };

        private global::System.CommandLine.Option<string?> License { get; } = new(
            name: "license")
        {
            Description = @"License under which the pipeline is distributed.",
        };

        private global::System.CommandLine.Option<string?> ProfileImage { get; } = new(
            name: "profileImage")
        {
            Description = @"Pipeline profile image in base64 format.",
        };
        public PipelinePublicServiceUpdateNamespacePipelineCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "pipeline",
            description: @"Udpates a pipeline, accessing it by its resource name, which is defined by
the parent namespace and the ID of the pipeline. The authenticated namespace must be
the parent of the pipeline in order to modify it.

In REST requests, only the supplied pipeline fields will be taken into
account when updating the resource.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

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