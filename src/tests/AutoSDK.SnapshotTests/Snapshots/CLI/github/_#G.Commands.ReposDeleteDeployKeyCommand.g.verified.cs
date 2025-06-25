//HintName: G.Commands.ReposDeleteDeployKeyCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ReposDeleteDeployKeyCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            int keyId,
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

        private global::System.CommandLine.Argument<int> KeyId { get; } = new(
            name: "keyId")
        {
            Description = "",
        };

        public ReposDeleteDeployKeyCommand(G.IApi client) : base(
            name: "repos",
            description: @"Deploy keys are immutable. If you need to update a key, remove the key and create a new one instead.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(KeyId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var keyId = parseResult.GetRequiredValue(KeyId);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                keyId: keyId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Repos.ReposDeleteDeployKeyAsync(
                owner: owner,
                repo: repo,
                keyId: keyId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}