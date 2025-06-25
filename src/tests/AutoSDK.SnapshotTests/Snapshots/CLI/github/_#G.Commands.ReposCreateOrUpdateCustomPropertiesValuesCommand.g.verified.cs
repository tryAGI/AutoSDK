//HintName: G.Commands.ReposCreateOrUpdateCustomPropertiesValuesCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ReposCreateOrUpdateCustomPropertiesValuesCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            global::System.Collections.Generic.IList<global::G.CustomPropertyValue> properties,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Owner { get; } = new(
            name: "owner")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Repo { get; } = new(
            name: "repo")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<global::G.CustomPropertyValue>> Properties { get; } = new(
            name: "properties")
        {
            Description = "",
        };

        public ReposCreateOrUpdateCustomPropertiesValuesCommand(G.IApi client) : base(
            name: "repos",
            description: @"Create new or update existing custom property values for a repository.
Using a value of `null` for a custom property will remove or 'unset' the property value from the repository.

Repository admins and other users with the repository-level ""edit custom property values"" fine-grained permission can use this endpoint.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(Properties);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var properties = parseResult.GetRequiredValue(Properties);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                properties: properties,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Repos.ReposCreateOrUpdateCustomPropertiesValuesAsync(
                owner: owner,
                repo: repo,
                properties: properties,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}