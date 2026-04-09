//HintName: G.IApiEndpointsClient.AgentEditJob.g.cs
#nullable enable

namespace G
{
    public partial interface IApiEndpointsClient
    {
        /// <summary>
        /// Agent edit<br/>
        /// Use a background agent to create and edit projects using a natural language prompt.<br/>
        /// - **Edit existing project**: Provide a `project_id` to edit an existing project<br/>
        /// - **Create new project**: Provide a `project_name` instead of `project_id` to create a new project<br/>
        /// ### Common use cases<br/>
        /// - Create new content: "create a 30-second video about cooking tips"<br/>
        /// - Apply audio effects: "add studio sound to every clip"<br/>
        /// - Remove filler words: "remove all filler words from the transcript"<br/>
        /// - Create highlights: "create a 30-second highlight reel"<br/>
        /// - Content editing: "remove the section from 1:30 to 2:15"<br/>
        /// ### Async Operations<br/>
        /// Agent edits run in the background and return a `job_id`. Monitor progress via the [GET /jobs/{job_id}](#operation/getJob) endpoint.<br/>
        /// ### Dynamic webhook<br/>
        /// If `callback_url` is provided, Descript will POST the job status to that URL when the job completes or fails.<br/>
        /// The payload will match the format returned by [GET /jobs/{job_id}](#operation/getJob).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AgentEditJobResponse> AgentEditJobAsync(

            global::G.AgentEditJobRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Agent edit<br/>
        /// Use a background agent to create and edit projects using a natural language prompt.<br/>
        /// - **Edit existing project**: Provide a `project_id` to edit an existing project<br/>
        /// - **Create new project**: Provide a `project_name` instead of `project_id` to create a new project<br/>
        /// ### Common use cases<br/>
        /// - Create new content: "create a 30-second video about cooking tips"<br/>
        /// - Apply audio effects: "add studio sound to every clip"<br/>
        /// - Remove filler words: "remove all filler words from the transcript"<br/>
        /// - Create highlights: "create a 30-second highlight reel"<br/>
        /// - Content editing: "remove the section from 1:30 to 2:15"<br/>
        /// ### Async Operations<br/>
        /// Agent edits run in the background and return a `job_id`. Monitor progress via the [GET /jobs/{job_id}](#operation/getJob) endpoint.<br/>
        /// ### Dynamic webhook<br/>
        /// If `callback_url` is provided, Descript will POST the job status to that URL when the job completes or fails.<br/>
        /// The payload will match the format returned by [GET /jobs/{job_id}](#operation/getJob).
        /// </summary>
        /// <param name="projectId">
        /// The ID of an existing project to edit. Mutually exclusive with `project_name`.<br/>
        /// Example: 9f36ee32-5a2c-47e7-b1a3-94991d3e3ddb
        /// </param>
        /// <param name="projectName">
        /// Name for creating a new project. Mutually exclusive with `project_id`.<br/>
        /// Example: My New Project
        /// </param>
        /// <param name="compositionId">
        /// **[Work in progress]** This property is accepted but not yet functional. It will be ignored.<br/>
        /// Optional composition ID within the project to edit.<br/>
        /// Example: 39677a40-1c43-4c36-8449-46cfbc4de2b5
        /// </param>
        /// <param name="model">
        /// AI model to use for editing. Defaults to the default model.
        /// </param>
        /// <param name="prompt">
        /// Natural language instruction for the agent to execute.<br/>
        /// Examples: "add studio sound to every clip", "remove all filler words", "create a 30-second highlight reel"<br/>
        /// Example: add studio sound to every clip
        /// </param>
        /// <param name="teamAccess">
        /// Access level for team members when creating a new project.<br/>
        /// Only applicable when `project_name` is provided (not when using `project_id`).<br/>
        /// Defaults to `none` if not specified.
        /// </param>
        /// <param name="callbackUrl">
        /// Optional webhook URL to call when the job completes or fails.<br/>
        /// Descript will POST the job status (same format as [GET /jobs/{job_id}](#operation/getJob)) to this URL.<br/>
        /// Example: https://example.com/webhooks/descript/job_callback
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AgentEditJobResponse> AgentEditJobAsync(
            string prompt,
            global::System.Guid? projectId = default,
            string? projectName = default,
            global::System.Guid? compositionId = default,
            string? model = default,
            global::G.AgentEditJobRequestTeamAccess? teamAccess = default,
            string? callbackUrl = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}