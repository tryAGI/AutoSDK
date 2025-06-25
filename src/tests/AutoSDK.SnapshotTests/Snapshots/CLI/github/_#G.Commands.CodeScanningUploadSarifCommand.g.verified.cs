//HintName: G.Commands.CodeScanningUploadSarifCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CodeScanningUploadSarifCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            string commitSha,
            string @ref,
            string sarif,
            string? checkoutUri,
            global::System.DateTime? startedAt,
            string? toolName,
            bool? validate,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.CodeScanningSarifsReceipt response,
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

        private global::System.CommandLine.Argument<string> CommitSha { get; } = new(
            name: "commitSha")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Ref { get; } = new(
            name: "@ref")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Sarif { get; } = new(
            name: "sarif")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> CheckoutUri { get; } = new(
            name: "checkoutUri")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.DateTime?> StartedAt { get; } = new(
            name: "startedAt")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> ToolName { get; } = new(
            name: "toolName")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> Validate { get; } = new(
            name: "validate")
        {
            Description = "",
        };
        public CodeScanningUploadSarifCommand(G.IApi client) : base(
            name: "code",
            description: @"Uploads SARIF data containing the results of a code scanning analysis to make the results available in a repository. For troubleshooting information, see ""[Troubleshooting SARIF uploads](https://docs.github.com/code-security/code-scanning/troubleshooting-sarif).""

There are two places where you can upload code scanning results.
 - If you upload to a pull request, for example `--ref refs/pull/42/merge` or `--ref refs/pull/42/head`, then the results appear as alerts in a pull request check. For more information, see ""[Triaging code scanning alerts in pull requests](/code-security/secure-coding/triaging-code-scanning-alerts-in-pull-requests).""
 - If you upload to a branch, for example `--ref refs/heads/my-branch`, then the results appear in the **Security** tab for your repository. For more information, see ""[Managing code scanning alerts for your repository](/code-security/secure-coding/managing-code-scanning-alerts-for-your-repository#viewing-the-alerts-for-a-repository).""

You must compress the SARIF-formatted analysis data that you want to upload, using `gzip`, and then encode it as a Base64 format string. For example:

```
gzip -c analysis-data.sarif | base64 -w0
```

SARIF upload supports a maximum number of entries per the following data objects, and an analysis will be rejected if any of these objects is above its maximum value. For some objects, there are additional values over which the entries will be ignored while keeping the most important entries whenever applicable.
To get the most out of your analysis when it includes data above the supported limits, try to optimize the analysis configuration. For example, for the CodeQL tool, identify and remove the most noisy queries. For more information, see ""[SARIF results exceed one or more limits](https://docs.github.com/code-security/code-scanning/troubleshooting-sarif/results-exceed-limit).""


| **SARIF data**                   | **Maximum values** | **Additional limits**                                                            |
|----------------------------------|:------------------:|----------------------------------------------------------------------------------|
| Runs per file                    |         20         |                                                                                  |
| Results per run                  |       25,000       | Only the top 5,000 results will be included, prioritized by severity.            |
| Rules per run                    |       25,000       |                                                                                  |
| Tool extensions per run          |        100         |                                                                                  |
| Thread Flow Locations per result |       10,000       | Only the top 1,000 Thread Flow Locations will be included, using prioritization. |
| Location per result	             |       1,000        | Only 100 locations will be included.                                             |
| Tags per rule	                   |         20         | Only 10 tags will be included.                                                   |


The `202 Accepted` response includes an `id` value.
You can use this ID to check the status of the upload by using it in the `/sarifs/{sarif_id}` endpoint.
For more information, see ""[Get information about a SARIF upload](/rest/code-scanning/code-scanning#get-information-about-a-sarif-upload).""

OAuth app tokens and personal access tokens (classic) need the `security_events` scope to use this endpoint with private or public repositories, or the `public_repo` scope to use this endpoint with only public repositories.

This endpoint is limited to 1,000 requests per hour for each user or app installation calling it.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(CommitSha);
            Arguments.Add(Ref);
            Arguments.Add(Sarif);
            Options.Add(CheckoutUri);
            Options.Add(StartedAt);
            Options.Add(ToolName);
            Options.Add(Validate);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var commitSha = parseResult.GetRequiredValue(CommitSha);
            var @ref = parseResult.GetRequiredValue(Ref);
            var sarif = parseResult.GetRequiredValue(Sarif);
            var checkoutUri = parseResult.GetRequiredValue(CheckoutUri);
            var startedAt = parseResult.GetRequiredValue(StartedAt);
            var toolName = parseResult.GetRequiredValue(ToolName);
            var validate = parseResult.GetRequiredValue(Validate);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                commitSha: commitSha,
                @ref: @ref,
                sarif: sarif,
                checkoutUri: checkoutUri,
                startedAt: startedAt,
                toolName: toolName,
                validate: validate,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.CodeScanning.CodeScanningUploadSarifAsync(
                owner: owner,
                repo: repo,
                commitSha: commitSha,
                @ref: @ref,
                sarif: sarif,
                checkoutUri: checkoutUri,
                startedAt: startedAt,
                toolName: toolName,
                validate: validate,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}