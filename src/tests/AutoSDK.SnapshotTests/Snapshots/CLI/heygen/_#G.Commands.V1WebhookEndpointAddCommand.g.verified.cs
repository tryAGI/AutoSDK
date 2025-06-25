//HintName: G.Commands.V1WebhookEndpointAddCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class V1WebhookEndpointAddCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<object>? events,
            string? url,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<object>?> Events { get; } = new(
            name: "events")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Url { get; } = new(
            name: "url")
        {
            Description = @"",
        };
        public V1WebhookEndpointAddCommand(G.IApi client) : base(
            name: "v1webhook",
            description: @"v1/webhook/endpoint.add")
        {
            _client = client;

            Options.Add(Events);
            Options.Add(Url);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var events = parseResult.GetRequiredValue(Events);
            var url = parseResult.GetRequiredValue(Url);

            Validate(
                parseResult: parseResult,
                events: events,
                url: url,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Webhooks.V1WebhookEndpointAddAsync(
                events: events,
                url: url,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}