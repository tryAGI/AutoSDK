//HintName: G.Commands.OrgsCreateOrUpdateCustomPropertiesValuesForReposCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class OrgsCreateOrUpdateCustomPropertiesValuesForReposCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            global::System.Collections.Generic.IList<string> repositoryNames,
            global::System.Collections.Generic.IList<global::G.CustomPropertyValue> properties,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Org { get; } = new(
            name: "org")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<string>> RepositoryNames { get; } = new(
            name: "repositoryNames")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<global::G.CustomPropertyValue>> Properties { get; } = new(
            name: "properties")
        {
            Description = "",
        };

        public OrgsCreateOrUpdateCustomPropertiesValuesForReposCommand(G.IApi client) : base(
            name: "orgs",
            description: @"Create new or update existing custom property values for repositories in a batch that belong to an organization.
Each target repository will have its custom property values updated to match the values provided in the request.

A maximum of 30 repositories can be updated in a single request.

Using a value of `null` for a custom property will remove or 'unset' the property value from the repository.

To use this endpoint, the authenticated user must be one of:
  - An administrator for the organization.
  - A user, or a user on a team, with the fine-grained permission of `custom_properties_org_values_editor` in the organization.")
        {
            _client = client;

            Arguments.Add(Org);
            Arguments.Add(RepositoryNames);
            Arguments.Add(Properties);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var org = parseResult.GetRequiredValue(Org);
            var repositoryNames = parseResult.GetRequiredValue(RepositoryNames);
            var properties = parseResult.GetRequiredValue(Properties);

            Validate(
                parseResult: parseResult,
                org: org,
                repositoryNames: repositoryNames,
                properties: properties,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Orgs.OrgsCreateOrUpdateCustomPropertiesValuesForReposAsync(
                org: org,
                repositoryNames: repositoryNames,
                properties: properties,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}