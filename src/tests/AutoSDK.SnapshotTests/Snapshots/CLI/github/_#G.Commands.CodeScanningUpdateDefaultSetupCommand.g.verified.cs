//HintName: G.Commands.CodeScanningUpdateDefaultSetupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CodeScanningUpdateDefaultSetupCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            global::G.CodeScanningDefaultSetupUpdateState? state,
            global::G.CodeScanningDefaultSetupUpdateQuerySuite? querySuite,
            global::System.Collections.Generic.IList<global::G.CodeScanningDefaultSetupUpdateLanguage>? languages,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.EmptyObject response,
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

        private global::System.CommandLine.Option<global::G.CodeScanningDefaultSetupUpdateState?> State { get; } = new(
            name: "state")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.CodeScanningDefaultSetupUpdateQuerySuite?> QuerySuite { get; } = new(
            name: "querySuite")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.CodeScanningDefaultSetupUpdateLanguage>?> Languages { get; } = new(
            name: "languages")
        {
            Description = "",
        };
        public CodeScanningUpdateDefaultSetupCommand(G.IApi client) : base(
            name: "code",
            description: @"Updates a code scanning default setup configuration.

OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint with private or public repositories, or the `public_repo` scope to use this endpoint with only public repositories.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Options.Add(State);
            Options.Add(QuerySuite);
            Options.Add(Languages);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var state = parseResult.GetRequiredValue(State);
            var querySuite = parseResult.GetRequiredValue(QuerySuite);
            var languages = parseResult.GetRequiredValue(Languages);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                state: state,
                querySuite: querySuite,
                languages: languages,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.CodeScanning.CodeScanningUpdateDefaultSetupAsync(
                owner: owner,
                repo: repo,
                state: state,
                querySuite: querySuite,
                languages: languages,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}