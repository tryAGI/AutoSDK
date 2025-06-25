//HintName: G.Commands.V1WebhookEndpointDeleteCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class V1WebhookEndpointDeleteCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? endpointId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<string?> EndpointId { get; } = new(
            name: "endpointId")
        {
            Description = @"",
        };
        public V1WebhookEndpointDeleteCommand(G.IApi client) : base(
            name: "v1webhook",
            description: @"v1/webhook/endpoint.delete")
        {
            _client = client;

            Options.Add(EndpointId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var endpointId = parseResult.GetRequiredValue(EndpointId);

            Validate(
                parseResult: parseResult,
                endpointId: endpointId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Webhooks.V1WebhookEndpointDeleteAsync(
                endpointId: endpointId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}