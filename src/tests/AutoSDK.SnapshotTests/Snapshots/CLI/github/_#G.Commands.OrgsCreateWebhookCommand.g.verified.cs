//HintName: G.Commands.OrgsCreateWebhookCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class OrgsCreateWebhookCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            string name,
            global::G.OrgsCreateWebhookRequestConfig config,
            global::System.Collections.Generic.IList<string>? events,
            bool? active,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.OrgHook response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Org { get; } = new(
            name: "org")
        {
            Description = "",
        };

        private new global::System.CommandLine.Argument<string> Name { get; } = new(
            name: "name")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::G.OrgsCreateWebhookRequestConfig> Config { get; } = new(
            name: "config")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> Events { get; } = new(
            name: "events")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> Active { get; } = new(
            name: "active")
        {
            Description = "",
        };
        public OrgsCreateWebhookCommand(G.IApi client) : base(
            name: "orgs",
            description: @"Create a hook that posts payloads in JSON format.

You must be an organization owner to use this endpoint.

OAuth app tokens and personal access tokens (classic) need `admin:org_hook` scope. OAuth apps cannot list, view, or
edit webhooks that they did not create and users cannot list, view, or edit webhooks that were created by OAuth apps.")
        {
            _client = client;

            Arguments.Add(Org);
            Arguments.Add(Name);
            Arguments.Add(Config);
            Options.Add(Events);
            Options.Add(Active);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var org = parseResult.GetRequiredValue(Org);
            var name = parseResult.GetRequiredValue(Name);
            var config = parseResult.GetRequiredValue(Config);
            var events = parseResult.GetRequiredValue(Events);
            var active = parseResult.GetRequiredValue(Active);

            Validate(
                parseResult: parseResult,
                org: org,
                name: name,
                config: config,
                events: events,
                active: active,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Orgs.OrgsCreateWebhookAsync(
                org: org,
                name: name,
                config: config,
                events: events,
                active: active,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}