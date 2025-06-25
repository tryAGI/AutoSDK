//HintName: G.Commands.OrgsCreateOrUpdateCustomPropertiesCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class OrgsCreateOrUpdateCustomPropertiesCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            global::System.Collections.Generic.IList<global::G.CustomProperty> properties,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::G.CustomProperty> response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Org { get; } = new(
            name: "org")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<global::G.CustomProperty>> Properties { get; } = new(
            name: "properties")
        {
            Description = "",
        };

        public OrgsCreateOrUpdateCustomPropertiesCommand(G.IApi client) : base(
            name: "orgs",
            description: @"Creates new or updates existing custom properties defined for an organization in a batch.

To use this endpoint, the authenticated user must be one of:
  - An administrator for the organization.
  - A user, or a user on a team, with the fine-grained permission of `custom_properties_org_definitions_manager` in the organization.")
        {
            _client = client;

            Arguments.Add(Org);
            Arguments.Add(Properties);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var org = parseResult.GetRequiredValue(Org);
            var properties = parseResult.GetRequiredValue(Properties);

            Validate(
                parseResult: parseResult,
                org: org,
                properties: properties,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Orgs.OrgsCreateOrUpdateCustomPropertiesAsync(
                org: org,
                properties: properties,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}