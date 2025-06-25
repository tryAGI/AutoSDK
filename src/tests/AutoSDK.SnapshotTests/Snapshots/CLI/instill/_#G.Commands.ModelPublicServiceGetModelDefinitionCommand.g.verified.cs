//HintName: G.Commands.ModelPublicServiceGetModelDefinitionCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ModelPublicServiceGetModelDefinitionCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

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
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.ModelPublicServiceGetModelDefinitionView?> View { get; } = new(
            name: "view")
        {
            Description = @"",
        };
        public ModelPublicServiceGetModelDefinitionCommand(G.IApi client) : base(
            name: "model",
            description: @"Returns the details of a model definition.")
        {
            _client = client;

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