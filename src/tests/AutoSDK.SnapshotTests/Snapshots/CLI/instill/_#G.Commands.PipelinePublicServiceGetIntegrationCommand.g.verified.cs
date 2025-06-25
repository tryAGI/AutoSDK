//HintName: G.Commands.PipelinePublicServiceGetIntegrationCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PipelinePublicServiceGetIntegrationCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string integrationId,
            global::G.PipelinePublicServiceGetIntegrationView? view,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GetIntegrationResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> IntegrationId { get; } = new(
            name: "integrationId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.PipelinePublicServiceGetIntegrationView?> View { get; } = new(
            name: "view")
        {
            Description = "",
        };
        public PipelinePublicServiceGetIntegrationCommand(G.IApi client) : base(
            name: "pipeline",
            description: @"Returns the details of an integration.")
        {
            _client = client;

            Arguments.Add(IntegrationId);
            Options.Add(View);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var integrationId = parseResult.GetRequiredValue(IntegrationId);
            var view = parseResult.GetRequiredValue(View);

            Validate(
                parseResult: parseResult,
                integrationId: integrationId,
                view: view,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.VDP.PipelinePublicServiceGetIntegrationAsync(
                integrationId: integrationId,
                view: view,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}