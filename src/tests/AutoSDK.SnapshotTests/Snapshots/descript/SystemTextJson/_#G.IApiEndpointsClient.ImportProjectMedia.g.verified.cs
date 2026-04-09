//HintName: G.IApiEndpointsClient.ImportProjectMedia.g.cs
#nullable enable

namespace G
{
    public partial interface IApiEndpointsClient
    {
        /// <summary>
        /// Import media and sequences<br/>
        /// Import media files into a new or existing project and create compositions.<br/>
        /// This endpoint can:<br/>
        /// - Create a new project if `project_id` is not provided<br/>
        /// - Import media files from URLs<br/>
        /// - Create multitrack sequences<br/>
        /// - Create compositions (timelines) from existing or new media in the project<br/>
        /// - Trigger transcription and other background processing tasks<br/>
        /// ### Media URL requirements<br/>
        /// - URLs must be accessible by Descript servers<br/>
        /// - URLs must support HTTP Range requests<br/>
        /// - Recommended to sign URLs for 12-48 hours to reduce chance of failure<br/>
        /// - [Supported file types](https://help.descript.com/hc/en-us/articles/10164098416909-Supported-file-types)<br/>
        /// ### Async Operations<br/>
        /// Imports run in the background and return a `job_id`. Monitor progress via the [GET /jobs/{job_id}](#operation/getJob) endpoint.<br/>
        /// ### Dynamic webhook<br/>
        /// If `callback_url` is provided, Descript will POST the job status to that URL when the job finishes (successfully or not).<br/>
        /// The payload will match the format returned by [GET /jobs/{job_id}](#operation/getJob).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ImportProjectMediaResponse> ImportProjectMediaAsync(

            global::G.ImportProjectMediaRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Import media and sequences<br/>
        /// Import media files into a new or existing project and create compositions.<br/>
        /// This endpoint can:<br/>
        /// - Create a new project if `project_id` is not provided<br/>
        /// - Import media files from URLs<br/>
        /// - Create multitrack sequences<br/>
        /// - Create compositions (timelines) from existing or new media in the project<br/>
        /// - Trigger transcription and other background processing tasks<br/>
        /// ### Media URL requirements<br/>
        /// - URLs must be accessible by Descript servers<br/>
        /// - URLs must support HTTP Range requests<br/>
        /// - Recommended to sign URLs for 12-48 hours to reduce chance of failure<br/>
        /// - [Supported file types](https://help.descript.com/hc/en-us/articles/10164098416909-Supported-file-types)<br/>
        /// ### Async Operations<br/>
        /// Imports run in the background and return a `job_id`. Monitor progress via the [GET /jobs/{job_id}](#operation/getJob) endpoint.<br/>
        /// ### Dynamic webhook<br/>
        /// If `callback_url` is provided, Descript will POST the job status to that URL when the job finishes (successfully or not).<br/>
        /// The payload will match the format returned by [GET /jobs/{job_id}](#operation/getJob).
        /// </summary>
        /// <param name="projectId">
        /// **[Work in progress]** Importing into an existing project is not yet supported. Currently, a new project is always created.<br/>
        /// Existing project ID to import media into. If not provided, a new project will be created.<br/>
        /// When importing into an existing project, media filenames must not conflict with existing files.<br/>
        /// Example: 9f36ee32-5a2c-47e7-b1a3-94991d3e3ddb
        /// </param>
        /// <param name="projectName">
        /// Name for the new project. Only used when project_id is not provided.<br/>
        /// Example: Marketing Video
        /// </param>
        /// <param name="teamAccess">
        /// Access level for drive members. Only applicable when creating a new project<br/>
        /// (when project_id is not provided). Defaults to `none` if not specified.<br/>
        /// - edit: Users can edit the project<br/>
        /// - comment: Users can view and comment but not edit<br/>
        /// - view: Users can view but not comment or edit<br/>
        /// - none: No shared access (private to owner)<br/>
        /// Default Value: none<br/>
        /// Example: edit
        /// </param>
        /// <param name="addMedia">
        /// Map of media reference IDs (display names with optional folder paths) to media import items.<br/>
        /// Keys are the display names that will appear in the project (e.g., "Misc/intro.mp4" or "demo.mp4").<br/>
        /// Values define how to import each media item (URL import or multitrack sequence).<br/>
        /// Example: {"Misc/intro.mp4":{"url":"https://example.com/intro.mp4"},"demo.mp4":{"url":"https://example.com/demo.mp4"},"Multicam_Track":{"tracks":[{"media":"Recordings/camera1.mp4","offset":0},{"media":"Recordings/camera2.mp4","offset":50}]}}
        /// </param>
        /// <param name="addCompositions">
        /// Optional list of compositions to create in the project
        /// </param>
        /// <param name="callbackUrl">
        /// Optional webhook URL to call when the job completes or fails.<br/>
        /// Descript will POST the job status (same format as [GET /jobs/{job_id}](#operation/getJob)) to this URL.<br/>
        /// Example: https://example.com/webhooks/descript/job_callback
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ImportProjectMediaResponse> ImportProjectMediaAsync(
            global::System.Guid? projectId = default,
            string? projectName = default,
            global::G.ImportProjectMediaRequestTeamAccess? teamAccess = default,
            global::System.Collections.Generic.Dictionary<string, global::G.OneOf<global::G.ImportProjectMediaRequestAddMediaUrlImport, global::G.ImportProjectMediaRequestAddMediaMultitrackSequence>>? addMedia = default,
            global::System.Collections.Generic.IList<global::G.ImportProjectMediaRequestAddComposition>? addCompositions = default,
            string? callbackUrl = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}