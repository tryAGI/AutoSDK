//HintName: G.Commands.GitCreateBlobCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GitCreateBlobCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            string content,
            string? encoding,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ShortBlob response,
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

        private global::System.CommandLine.Argument<string> Content { get; } = new(
            name: "content")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Encoding { get; } = new(
            name: "encoding")
        {
            Description = "",
        };
        public GitCreateBlobCommand(G.IApi client) : base(
            name: "git",
            description: @"")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(Content);
            Options.Add(Encoding);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var content = parseResult.GetRequiredValue(Content);
            var encoding = parseResult.GetRequiredValue(Encoding);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                content: content,
                encoding: encoding,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Git.GitCreateBlobAsync(
                owner: owner,
                repo: repo,
                content: content,
                encoding: encoding,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}