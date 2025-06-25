﻿//HintName: G.IChecksClient.ChecksCreate.g.cs
#nullable enable

namespace G
{
    public partial interface IChecksClient
    {
        /// <summary>
        /// Create a check run<br/>
        /// Creates a new check run for a specific commit in a repository.<br/>
        /// To create a check run, you must use a GitHub App. OAuth apps and authenticated users are not able to create a check suite.<br/>
        /// In a check suite, GitHub limits the number of check runs with the same name to 1000. Once these check runs exceed 1000, GitHub will start to automatically delete older check runs.<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; The Checks API only looks for pushes in the repository where the check suite or check run were created. Pushes to a branch in a forked repository are not detected and return an empty `pull_requests` array.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CheckRun> ChecksCreateAsync(
            string owner,
            string repo,
            global::G.ChecksCreateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a check run<br/>
        /// Creates a new check run for a specific commit in a repository.<br/>
        /// To create a check run, you must use a GitHub App. OAuth apps and authenticated users are not able to create a check suite.<br/>
        /// In a check suite, GitHub limits the number of check runs with the same name to 1000. Once these check runs exceed 1000, GitHub will start to automatically delete older check runs.<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; The Checks API only looks for pushes in the repository where the check suite or check run were created. Pushes to a branch in a forked repository are not detected and return an empty `pull_requests` array.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="name">
        /// The name of the check. For example, "code-coverage".
        /// </param>
        /// <param name="headSha">
        /// The SHA of the commit.
        /// </param>
        /// <param name="detailsUrl">
        /// The URL of the integrator's site that has the full details of the check. If the integrator does not provide this, then the homepage of the GitHub app is used.
        /// </param>
        /// <param name="externalId">
        /// A reference for the run on the integrator's system.
        /// </param>
        /// <param name="status">
        /// The current status of the check run. Only GitHub Actions can set a status of `waiting`, `pending`, or `requested`.<br/>
        /// Default Value: queued
        /// </param>
        /// <param name="startedAt">
        /// The time that the check run began. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: `YYYY-MM-DDTHH:MM:SSZ`.
        /// </param>
        /// <param name="conclusion">
        /// **Required if you provide `completed_at` or a `status` of `completed`**. The final conclusion of the check. <br/>
        /// **Note:** Providing `conclusion` will automatically set the `status` parameter to `completed`. You cannot change a check run conclusion to `stale`, only GitHub can set this.
        /// </param>
        /// <param name="completedAt">
        /// The time the check completed. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: `YYYY-MM-DDTHH:MM:SSZ`.
        /// </param>
        /// <param name="output">
        /// Check runs can accept a variety of data in the `output` object, including a `title` and `summary` and can optionally provide descriptive details about the run.
        /// </param>
        /// <param name="actions">
        /// Displays a button on GitHub that can be clicked to alert your app to do additional tasks. For example, a code linting app can display a button that automatically fixes detected errors. The button created in this object is displayed after the check run completes. When a user clicks the button, GitHub sends the [`check_run.requested_action` webhook](https://docs.github.com/webhooks/event-payloads/#check_run) to your app. Each action includes a `label`, `identifier` and `description`. A maximum of three actions are accepted. To learn more about check runs and requested actions, see "[Check runs and requested actions](https://docs.github.com/rest/guides/using-the-rest-api-to-interact-with-checks#check-runs-and-requested-actions)."
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CheckRun> ChecksCreateAsync(
            string owner,
            string repo,
            string name,
            string headSha,
            string? detailsUrl = default,
            string? externalId = default,
            global::G.ChecksCreateRequestStatus? status = default,
            global::System.DateTime? startedAt = default,
            global::G.ChecksCreateRequestConclusion? conclusion = default,
            global::System.DateTime? completedAt = default,
            global::G.ChecksCreateRequestOutput? output = default,
            global::System.Collections.Generic.IList<global::G.ChecksCreateRequestAction>? actions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}