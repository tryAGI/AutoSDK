//HintName: G.Commands.OrgsRemoveCustomPropertyCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class OrgsRemoveCustomPropertyCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            string customPropertyName,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Org { get; } = new(
            name: "org")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> CustomPropertyName { get; } = new(
            name: "customPropertyName")
        {
            Description = "",
        };

        public OrgsRemoveCustomPropertyCommand(G.IApi client) : base(
            name: "orgs",
            description: @"Removes a custom property that is defined for an organization.

To use this endpoint, the authenticated user must be one of:
  - An administrator for the organization.
  - A user, or a user on a team, with the fine-grained permission of `custom_properties_org_definitions_manager` in the organization.")
        {
            _client = client;

            Arguments.Add(Org);
            Arguments.Add(CustomPropertyName);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var org = parseResult.GetRequiredValue(Org);
            var customPropertyName = parseResult.GetRequiredValue(CustomPropertyName);

            Validate(
                parseResult: parseResult,
                org: org,
                customPropertyName: customPropertyName,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Orgs.OrgsRemoveCustomPropertyAsync(
                org: org,
                customPropertyName: customPropertyName,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}