//HintName: G.Commands.ModelPublicServiceGetNamespaceLatestModelOperationCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ModelPublicServiceGetNamespaceLatestModelOperationCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string namespaceId,
            string modelId,
            global::G.ModelPublicServiceGetNamespaceLatestModelOperationView? view,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GetNamespaceLatestModelOperationResponse response,
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

        private global::System.CommandLine.Option<global::G.ModelPublicServiceGetNamespaceLatestModelOperationView?> View { get; } = new(
            name: "view")
        {
            Description = @"View allows clients to specify the desired operation result in the response.

 - VIEW_BASIC: Default view, only includes basic information (omits `model_spec`).
 - VIEW_FULL: Full representation.",
        };
        public ModelPublicServiceGetNamespaceLatestModelOperationCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "model",
            description: @"This method allows requesters to request the status and outcome of
long-running operations in a model, such as trigger.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(NamespaceId);
            Arguments.Add(ModelId);
            Options.Add(View);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var namespaceId = parseResult.GetRequiredValue(NamespaceId);
            var modelId = parseResult.GetRequiredValue(ModelId);
            var view = parseResult.GetRequiredValue(View);

            Validate(
                parseResult: parseResult,
                namespaceId: namespaceId,
                modelId: modelId,
                view: view,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Model.ModelPublicServiceGetNamespaceLatestModelOperationAsync(
                namespaceId: namespaceId,
                modelId: modelId,
                view: view,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}