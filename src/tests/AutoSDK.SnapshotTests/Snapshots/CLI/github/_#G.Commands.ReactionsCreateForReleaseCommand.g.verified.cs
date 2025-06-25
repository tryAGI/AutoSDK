//HintName: G.Commands.ReactionsCreateForReleaseCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ReactionsCreateForReleaseCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            int releaseId,
            global::G.ReactionsCreateForReleaseRequestContent content,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.Reaction response,
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

        private global::System.CommandLine.Argument<global::G.ReactionsCreateForReleaseRequestContent> Content { get; } = new(
            name: "content")
        {
            Description = "",
        };

        public ReactionsCreateForReleaseCommand(G.IApi client) : base(
            name: "reactions",
            description: @"Create a reaction to a [release](https://docs.github.com/rest/releases/releases#get-a-release). A response with a `Status: 200 OK` means that you already added the reaction type to this release.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(ReleaseId);
            Arguments.Add(Content);

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
            var content = parseResult.GetRequiredValue(Content);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                releaseId: releaseId,
                content: content,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Reactions.ReactionsCreateForReleaseAsync(
                owner: owner,
                repo: repo,
                releaseId: releaseId,
                content: content,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}