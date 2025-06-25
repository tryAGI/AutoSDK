//HintName: G.Commands.ModelPublicServiceGetModelOperationCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ModelPublicServiceGetModelOperationCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string operationId,
            global::G.ModelPublicServiceGetModelOperationView? view,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GetModelOperationResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> OperationId { get; } = new(
            name: "operationId")
        {
            Description = @"The resource name of the model, which allows its access ID.",
        };

        private global::System.CommandLine.Option<global::G.ModelPublicServiceGetModelOperationView?> View { get; } = new(
            name: "view")
        {
            Description = @"View allows clients to specify the desired model view in the response.

 - VIEW_BASIC: Default view, only includes basic information (omits `model_spec`).
 - VIEW_FULL: Full representation.",
        };
        public ModelPublicServiceGetModelOperationCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "model",
            description: @"This method allows requesters to request the status and outcome of
long-running operations in a model, such as trigger.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(OperationId);
            Options.Add(View);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var operationId = parseResult.GetRequiredValue(OperationId);
            var view = parseResult.GetRequiredValue(View);

            Validate(
                parseResult: parseResult,
                operationId: operationId,
                view: view,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Model.ModelPublicServiceGetModelOperationAsync(
                operationId: operationId,
                view: view,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}