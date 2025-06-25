//HintName: G.Commands.ReposDeleteTagProtectionCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ReposDeleteTagProtectionCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            int tagProtectionId,
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

        private global::System.CommandLine.Argument<int> TagProtectionId { get; } = new(
            name: "tagProtectionId")
        {
            Description = "",
        };

        public ReposDeleteTagProtectionCommand(G.IApi client) : base(
            name: "repos",
            description: @"> [!WARNING]
> **Deprecation notice:** This operation is deprecated and will be removed after August 30, 2024. Use the ""[Repository Rulesets](https://docs.github.com/rest/repos/rules#delete-a-repository-ruleset)"" endpoint instead.

This deletes a tag protection state for a repository.
This endpoint is only available to repository administrators.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(TagProtectionId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var tagProtectionId = parseResult.GetRequiredValue(TagProtectionId);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                tagProtectionId: tagProtectionId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Repos.ReposDeleteTagProtectionAsync(
                owner: owner,
                repo: repo,
                tagProtectionId: tagProtectionId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}