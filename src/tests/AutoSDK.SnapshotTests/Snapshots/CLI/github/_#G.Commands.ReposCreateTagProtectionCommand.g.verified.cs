//HintName: G.Commands.ReposCreateTagProtectionCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ReposCreateTagProtectionCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            string pattern,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.TagProtection response,
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

        private global::System.CommandLine.Argument<string> Pattern { get; } = new(
            name: "pattern")
        {
            Description = "",
        };

        public ReposCreateTagProtectionCommand(G.IApi client) : base(
            name: "repos",
            description: @"> [!WARNING]
> **Deprecation notice:** This operation is deprecated and will be removed after August 30, 2024. Use the ""[Repository Rulesets](https://docs.github.com/rest/repos/rules#create-a-repository-ruleset)"" endpoint instead.

This creates a tag protection state for a repository.
This endpoint is only available to repository administrators.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(Pattern);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var pattern = parseResult.GetRequiredValue(Pattern);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                pattern: pattern,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Repos.ReposCreateTagProtectionAsync(
                owner: owner,
                repo: repo,
                pattern: pattern,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}