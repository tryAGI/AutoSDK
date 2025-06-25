//HintName: G.Commands.ModelPublicServiceDeleteNamespaceModelVersionCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ModelPublicServiceDeleteNamespaceModelVersionCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string namespaceId,
            string modelId,
            string version,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            string response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> NamespaceId { get; } = new(
            name: "namespaceId")
        {
            Description = @"Namespace ID",
        };

        private global::System.CommandLine.Argument<string> ModelId { get; } = new(
            name: "modelId")
        {
            Description = @"Model ID",
        };

        private global::System.CommandLine.Argument<string> Version { get; } = new(
            name: "version")
        {
            Description = @"Model version",
        };

        public ModelPublicServiceDeleteNamespaceModelVersionCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "model",
            description: @"Deletes a model version, accesing it by its resource name, which is defined by the
parent namespace and the ID of the model, and version.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(NamespaceId);
            Arguments.Add(ModelId);
            Arguments.Add(Version);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var namespaceId = parseResult.GetRequiredValue(NamespaceId);
            var modelId = parseResult.GetRequiredValue(ModelId);
            var version = parseResult.GetRequiredValue(Version);

            Validate(
                parseResult: parseResult,
                namespaceId: namespaceId,
                modelId: modelId,
                version: version,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Model.ModelPublicServiceDeleteNamespaceModelVersionAsync(
                namespaceId: namespaceId,
                modelId: modelId,
                version: version,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}