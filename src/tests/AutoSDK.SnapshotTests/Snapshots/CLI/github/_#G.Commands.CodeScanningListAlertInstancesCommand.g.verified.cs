//HintName: G.Commands.CodeScanningListAlertInstancesCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CodeScanningListAlertInstancesCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            int alertNumber,
            int? page,
            int? perPage,
            string? @ref,
            int? pr,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::G.CodeScanningAlertInstance> response,
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

        private global::System.CommandLine.Argument<int> AlertNumber { get; } = new(
            name: "alertNumber")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> Page { get; } = new(
            name: "page")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> PerPage { get; } = new(
            name: "perPage")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Ref { get; } = new(
            name: "@ref")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> Pr { get; } = new(
            name: "pr")
        {
            Description = "",
        };
        public CodeScanningListAlertInstancesCommand(G.IApi client) : base(
            name: "code",
            description: @"Lists all instances of the specified code scanning alert.

OAuth app tokens and personal access tokens (classic) need the `security_events` scope to use this endpoint with private or public repositories, or the `public_repo` scope to use this endpoint with only public repositories.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(AlertNumber);
            Options.Add(Page);
            Options.Add(PerPage);
            Options.Add(Ref);
            Options.Add(Pr);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var alertNumber = parseResult.GetRequiredValue(AlertNumber);
            var page = parseResult.GetRequiredValue(Page);
            var perPage = parseResult.GetRequiredValue(PerPage);
            var @ref = parseResult.GetRequiredValue(Ref);
            var pr = parseResult.GetRequiredValue(Pr);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                alertNumber: alertNumber,
                page: page,
                perPage: perPage,
                @ref: @ref,
                pr: pr,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.CodeScanning.CodeScanningListAlertInstancesAsync(
                owner: owner,
                repo: repo,
                alertNumber: alertNumber,
                page: page,
                perPage: perPage,
                @ref: @ref,
                pr: pr,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}