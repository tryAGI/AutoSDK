//HintName: G.Commands.ModelPublicServiceGetModelDefinitionCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ModelPublicServiceGetModelDefinitionCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string modelDefinitionId,
            global::G.ModelPublicServiceGetModelDefinitionView? view,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GetModelDefinitionResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ModelDefinitionId { get; } = new(
            name: "modelDefinitionId")
        {
            Description = @"The resource name of the model definition, which allows its access by ID.
- Format: `model-definitions/{id}`.",
        };

        private global::System.CommandLine.Option<global::G.ModelPublicServiceGetModelDefinitionView?> View { get; } = new(
            name: "view")
        {
            Description = @"View allows clients to specify the desired resource view in the response.

 - VIEW_BASIC: Default view, only includes basic information (omits `model_spec`).
 - VIEW_FULL: Full representation.",
        };
        public ModelPublicServiceGetModelDefinitionCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "model",
            description: @"Returns the details of a model definition.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(ModelDefinitionId);
            Options.Add(View);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var modelDefinitionId = parseResult.GetRequiredValue(ModelDefinitionId);
            var view = parseResult.GetRequiredValue(View);

            Validate(
                parseResult: parseResult,
                modelDefinitionId: modelDefinitionId,
                view: view,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Model.ModelPublicServiceGetModelDefinitionAsync(
                modelDefinitionId: modelDefinitionId,
                view: view,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}