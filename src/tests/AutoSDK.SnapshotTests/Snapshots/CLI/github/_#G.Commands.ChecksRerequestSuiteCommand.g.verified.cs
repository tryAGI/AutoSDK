//HintName: G.Commands.ChecksRerequestSuiteCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ChecksRerequestSuiteCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            int checkSuiteId,
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

        private global::System.CommandLine.Argument<int> CheckSuiteId { get; } = new(
            name: "checkSuiteId")
        {
            Description = "",
        };

        public ChecksRerequestSuiteCommand(G.IApi client) : base(
            name: "checks",
            description: @"Triggers GitHub to rerequest an existing check suite, without pushing new code to a repository. This endpoint will trigger the [`check_suite` webhook](https://docs.github.com/webhooks/event-payloads/#check_suite) event with the action `rerequested`. When a check suite is `rerequested`, its `status` is reset to `queued` and the `conclusion` is cleared.

OAuth apps and personal access tokens (classic) cannot use this endpoint.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(CheckSuiteId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var checkSuiteId = parseResult.GetRequiredValue(CheckSuiteId);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                checkSuiteId: checkSuiteId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Checks.ChecksRerequestSuiteAsync(
                owner: owner,
                repo: repo,
                checkSuiteId: checkSuiteId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}