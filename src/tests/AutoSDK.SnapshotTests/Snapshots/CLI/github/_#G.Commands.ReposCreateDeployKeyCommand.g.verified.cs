//HintName: G.Commands.ReposCreateDeployKeyCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ReposCreateDeployKeyCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            string? title,
            string key,
            bool? readOnly,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.DeployKey response,
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

        private global::System.CommandLine.Argument<string> Key { get; } = new(
            name: "key")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Title { get; } = new(
            name: "title")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> ReadOnly { get; } = new(
            name: "readOnly")
        {
            Description = "",
        };
        public ReposCreateDeployKeyCommand(G.IApi client) : base(
            name: "repos",
            description: @"You can create a read-only deploy key.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(Key);
            Options.Add(Title);
            Options.Add(ReadOnly);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var title = parseResult.GetRequiredValue(Title);
            var key = parseResult.GetRequiredValue(Key);
            var readOnly = parseResult.GetRequiredValue(ReadOnly);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                title: title,
                key: key,
                readOnly: readOnly,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Repos.ReposCreateDeployKeyAsync(
                owner: owner,
                repo: repo,
                title: title,
                key: key,
                readOnly: readOnly,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}