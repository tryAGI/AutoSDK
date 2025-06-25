//HintName: G.Commands.ModelPublicServiceCreateNamespaceModelCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ModelPublicServiceCreateNamespaceModelCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string namespaceId,
            string id,
            string? description,
            string modelDefinition,
            object configuration,
            global::G.AITask task,
            global::G.ModelVisibility visibility,
            string region,
            string hardware,
            string? readme,
            string? sourceUrl,
            string? documentationUrl,
            string? license,
            string? profileImage,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.CreateNamespaceModelResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> NamespaceId { get; } = new(
            name: "namespaceId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Id { get; } = new(
            name: "id")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> ModelDefinition { get; } = new(
            name: "modelDefinition")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<object> Configuration { get; } = new(
            name: "configuration")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::G.AITask> Task { get; } = new(
            name: "task")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::G.ModelVisibility> Visibility { get; } = new(
            name: "visibility")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Region { get; } = new(
            name: "region")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Hardware { get; } = new(
            name: "hardware")
        {
            Description = "",
        };

        private new global::System.CommandLine.Option<string?> Description { get; } = new(
            name: "description")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Readme { get; } = new(
            name: "readme")
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
        public ModelPublicServiceCreateNamespaceModelCommand(G.IApi client) : base(
            name: "model",
            description: @"Creates a new model under the parenthood of a namespace. This is an
asynchronous endpoint, i.e., the server will not wait for the model to be
created in order to respond. Instead, it will return a response with the
necessary information to access the result and status of the creation
operation.")
        {
            _client = client;

            Arguments.Add(NamespaceId);
            Arguments.Add(Id);
            Arguments.Add(ModelDefinition);
            Arguments.Add(Configuration);
            Arguments.Add(Task);
            Arguments.Add(Visibility);
            Arguments.Add(Region);
            Arguments.Add(Hardware);
            Options.Add(Description);
            Options.Add(Readme);
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
            var id = parseResult.GetRequiredValue(Id);
            var description = parseResult.GetRequiredValue(Description);
            var modelDefinition = parseResult.GetRequiredValue(ModelDefinition);
            var configuration = parseResult.GetRequiredValue(Configuration);
            var task = parseResult.GetRequiredValue(Task);
            var visibility = parseResult.GetRequiredValue(Visibility);
            var region = parseResult.GetRequiredValue(Region);
            var hardware = parseResult.GetRequiredValue(Hardware);
            var readme = parseResult.GetRequiredValue(Readme);
            var sourceUrl = parseResult.GetRequiredValue(SourceUrl);
            var documentationUrl = parseResult.GetRequiredValue(DocumentationUrl);
            var license = parseResult.GetRequiredValue(License);
            var profileImage = parseResult.GetRequiredValue(ProfileImage);

            Validate(
                parseResult: parseResult,
                namespaceId: namespaceId,
                id: id,
                description: description,
                modelDefinition: modelDefinition,
                configuration: configuration,
                task: task,
                visibility: visibility,
                region: region,
                hardware: hardware,
                readme: readme,
                sourceUrl: sourceUrl,
                documentationUrl: documentationUrl,
                license: license,
                profileImage: profileImage,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Model.ModelPublicServiceCreateNamespaceModelAsync(
                namespaceId: namespaceId,
                id: id,
                description: description,
                modelDefinition: modelDefinition,
                configuration: configuration,
                task: task,
                visibility: visibility,
                region: region,
                hardware: hardware,
                readme: readme,
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