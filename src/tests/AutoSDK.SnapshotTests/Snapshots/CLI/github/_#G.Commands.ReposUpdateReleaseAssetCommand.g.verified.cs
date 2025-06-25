//HintName: G.Commands.ReposUpdateReleaseAssetCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ReposUpdateReleaseAssetCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            int assetId,
            string? name,
            string? label,
            string? state,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ReleaseAsset response,
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

        private global::System.CommandLine.Argument<int> AssetId { get; } = new(
            name: "assetId")
        {
            Description = "",
        };

        private new global::System.CommandLine.Option<string?> Name { get; } = new(
            name: "name")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Label { get; } = new(
            name: "label")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> State { get; } = new(
            name: "state")
        {
            Description = "",
        };
        public ReposUpdateReleaseAssetCommand(G.IApi client) : base(
            name: "repos",
            description: @"Users with push access to the repository can edit a release asset.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(AssetId);
            Options.Add(Name);
            Options.Add(Label);
            Options.Add(State);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var assetId = parseResult.GetRequiredValue(AssetId);
            var name = parseResult.GetRequiredValue(Name);
            var label = parseResult.GetRequiredValue(Label);
            var state = parseResult.GetRequiredValue(State);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                assetId: assetId,
                name: name,
                label: label,
                state: state,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Repos.ReposUpdateReleaseAssetAsync(
                owner: owner,
                repo: repo,
                assetId: assetId,
                name: name,
                label: label,
                state: state,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}