//HintName: G.Commands.CodeScanningDeleteAnalysisCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CodeScanningDeleteAnalysisCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            int analysisId,
            string? confirmDelete,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.CodeScanningAnalysisDeletion response,
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

        private global::System.CommandLine.Argument<int> AnalysisId { get; } = new(
            name: "analysisId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> ConfirmDelete { get; } = new(
            name: "confirmDelete")
        {
            Description = "",
        };
        public CodeScanningDeleteAnalysisCommand(G.IApi client) : base(
            name: "code",
            description: @"Deletes a specified code scanning analysis from a repository.

You can delete one analysis at a time.
To delete a series of analyses, start with the most recent analysis and work backwards.
Conceptually, the process is similar to the undo function in a text editor.

When you list the analyses for a repository,
one or more will be identified as deletable in the response:

```
""deletable"": true
```

An analysis is deletable when it's the most recent in a set of analyses.
Typically, a repository will have multiple sets of analyses
for each enabled code scanning tool,
where a set is determined by a unique combination of analysis values:

* `ref`
* `tool`
* `category`

If you attempt to delete an analysis that is not the most recent in a set,
you'll get a 400 response with the message:

```
Analysis specified is not deletable.
```

The response from a successful `DELETE` operation provides you with
two alternative URLs for deleting the next analysis in the set:
`next_analysis_url` and `confirm_delete_url`.
Use the `next_analysis_url` URL if you want to avoid accidentally deleting the final analysis
in a set. This is a useful option if you want to preserve at least one analysis
for the specified tool in your repository.
Use the `confirm_delete_url` URL if you are content to remove all analyses for a tool.
When you delete the last analysis in a set, the value of `next_analysis_url` and `confirm_delete_url`
in the 200 response is `null`.

As an example of the deletion process,
let's imagine that you added a workflow that configured a particular code scanning tool
to analyze the code in a repository. This tool has added 15 analyses:
10 on the default branch, and another 5 on a topic branch.
You therefore have two separate sets of analyses for this tool.
You've now decided that you want to remove all of the analyses for the tool.
To do this you must make 15 separate deletion requests.
To start, you must find an analysis that's identified as deletable.
Each set of analyses always has one that's identified as deletable.
Having found the deletable analysis for one of the two sets,
delete this analysis and then continue deleting the next analysis in the set until they're all deleted.
Then repeat the process for the second set.
The procedure therefore consists of a nested loop:

**Outer loop**:
* List the analyses for the repository, filtered by tool.
* Parse this list to find a deletable analysis. If found:

  **Inner loop**:
  * Delete the identified analysis.
  * Parse the response for the value of `confirm_delete_url` and, if found, use this in the next iteration.

The above process assumes that you want to remove all trace of the tool's analyses from the GitHub user interface, for the specified repository, and it therefore uses the `confirm_delete_url` value. Alternatively, you could use the `next_analysis_url` value, which would leave the last analysis in each set undeleted to avoid removing a tool's analysis entirely.

OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint with private or public repositories, or the `public_repo` scope to use this endpoint with only public repositories.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(AnalysisId);
            Options.Add(ConfirmDelete);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var analysisId = parseResult.GetRequiredValue(AnalysisId);
            var confirmDelete = parseResult.GetRequiredValue(ConfirmDelete);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                analysisId: analysisId,
                confirmDelete: confirmDelete,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.CodeScanning.CodeScanningDeleteAnalysisAsync(
                owner: owner,
                repo: repo,
                analysisId: analysisId,
                confirmDelete: confirmDelete,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}