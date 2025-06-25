//HintName: G.Commands.ReposCreateReleaseCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ReposCreateReleaseCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            string tagName,
            string? targetCommitish,
            string? name,
            string? body,
            bool? draft,
            bool? prerelease,
            string? discussionCategoryName,
            bool? generateReleaseNotes,
            global::G.ReposCreateReleaseRequestMakeLatest? makeLatest,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.Release response,
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

        private global::System.CommandLine.Argument<string> TagName { get; } = new(
            name: "tagName")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> TargetCommitish { get; } = new(
            name: "targetCommitish")
        {
            Description = "",
        };

        private new global::System.CommandLine.Option<string?> Name { get; } = new(
            name: "name")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Body { get; } = new(
            name: "body")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> Draft { get; } = new(
            name: "draft")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> Prerelease { get; } = new(
            name: "prerelease")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> DiscussionCategoryName { get; } = new(
            name: "discussionCategoryName")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> GenerateReleaseNotes { get; } = new(
            name: "generateReleaseNotes")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ReposCreateReleaseRequestMakeLatest?> MakeLatest { get; } = new(
            name: "makeLatest")
        {
            Description = "",
        };
        public ReposCreateReleaseCommand(G.IApi client) : base(
            name: "repos",
            description: @"Users with push access to the repository can create a release.

This endpoint triggers [notifications](https://docs.github.com/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. For more information, see ""[Rate limits for the API](https://docs.github.com/rest/using-the-rest-api/rate-limits-for-the-rest-api#about-secondary-rate-limits)"" and ""[Best practices for using the REST API](https://docs.github.com/rest/guides/best-practices-for-using-the-rest-api).""")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(TagName);
            Options.Add(TargetCommitish);
            Options.Add(Name);
            Options.Add(Body);
            Options.Add(Draft);
            Options.Add(Prerelease);
            Options.Add(DiscussionCategoryName);
            Options.Add(GenerateReleaseNotes);
            Options.Add(MakeLatest);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var tagName = parseResult.GetRequiredValue(TagName);
            var targetCommitish = parseResult.GetRequiredValue(TargetCommitish);
            var name = parseResult.GetRequiredValue(Name);
            var body = parseResult.GetRequiredValue(Body);
            var draft = parseResult.GetRequiredValue(Draft);
            var prerelease = parseResult.GetRequiredValue(Prerelease);
            var discussionCategoryName = parseResult.GetRequiredValue(DiscussionCategoryName);
            var generateReleaseNotes = parseResult.GetRequiredValue(GenerateReleaseNotes);
            var makeLatest = parseResult.GetRequiredValue(MakeLatest);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                tagName: tagName,
                targetCommitish: targetCommitish,
                name: name,
                body: body,
                draft: draft,
                prerelease: prerelease,
                discussionCategoryName: discussionCategoryName,
                generateReleaseNotes: generateReleaseNotes,
                makeLatest: makeLatest,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Repos.ReposCreateReleaseAsync(
                owner: owner,
                repo: repo,
                tagName: tagName,
                targetCommitish: targetCommitish,
                name: name,
                body: body,
                draft: draft,
                prerelease: prerelease,
                discussionCategoryName: discussionCategoryName,
                generateReleaseNotes: generateReleaseNotes,
                makeLatest: makeLatest,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}