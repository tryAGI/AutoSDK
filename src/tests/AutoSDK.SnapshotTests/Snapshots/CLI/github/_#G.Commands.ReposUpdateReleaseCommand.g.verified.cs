//HintName: G.Commands.ReposUpdateReleaseCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ReposUpdateReleaseCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            int releaseId,
            string? tagName,
            string? targetCommitish,
            string? name,
            string? body,
            bool? draft,
            bool? prerelease,
            global::G.ReposUpdateReleaseRequestMakeLatest? makeLatest,
            string? discussionCategoryName,
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

        private global::System.CommandLine.Argument<int> ReleaseId { get; } = new(
            name: "releaseId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> TagName { get; } = new(
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

        private global::System.CommandLine.Option<global::G.ReposUpdateReleaseRequestMakeLatest?> MakeLatest { get; } = new(
            name: "makeLatest")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> DiscussionCategoryName { get; } = new(
            name: "discussionCategoryName")
        {
            Description = "",
        };
        public ReposUpdateReleaseCommand(G.IApi client) : base(
            name: "repos",
            description: @"Users with push access to the repository can edit a release.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(ReleaseId);
            Options.Add(TagName);
            Options.Add(TargetCommitish);
            Options.Add(Name);
            Options.Add(Body);
            Options.Add(Draft);
            Options.Add(Prerelease);
            Options.Add(MakeLatest);
            Options.Add(DiscussionCategoryName);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var releaseId = parseResult.GetRequiredValue(ReleaseId);
            var tagName = parseResult.GetRequiredValue(TagName);
            var targetCommitish = parseResult.GetRequiredValue(TargetCommitish);
            var name = parseResult.GetRequiredValue(Name);
            var body = parseResult.GetRequiredValue(Body);
            var draft = parseResult.GetRequiredValue(Draft);
            var prerelease = parseResult.GetRequiredValue(Prerelease);
            var makeLatest = parseResult.GetRequiredValue(MakeLatest);
            var discussionCategoryName = parseResult.GetRequiredValue(DiscussionCategoryName);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                releaseId: releaseId,
                tagName: tagName,
                targetCommitish: targetCommitish,
                name: name,
                body: body,
                draft: draft,
                prerelease: prerelease,
                makeLatest: makeLatest,
                discussionCategoryName: discussionCategoryName,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Repos.ReposUpdateReleaseAsync(
                owner: owner,
                repo: repo,
                releaseId: releaseId,
                tagName: tagName,
                targetCommitish: targetCommitish,
                name: name,
                body: body,
                draft: draft,
                prerelease: prerelease,
                makeLatest: makeLatest,
                discussionCategoryName: discussionCategoryName,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}