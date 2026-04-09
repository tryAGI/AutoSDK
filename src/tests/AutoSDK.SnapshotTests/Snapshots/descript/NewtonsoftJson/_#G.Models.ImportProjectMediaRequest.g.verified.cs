//HintName: G.Models.ImportProjectMediaRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request to import media into a project and optionally create compositions.<br/>
    /// This operation will:<br/>
    /// - Create a new project if project_id is not provided (using the drive associated with the personal token)<br/>
    /// - Import media files from URLs or create multitrack sequences<br/>
    /// - Optionally create one or more compositions<br/>
    /// - Trigger transcription and other background processing
    /// </summary>
    public sealed partial class ImportProjectMediaRequest
    {
        /// <summary>
        /// **[Work in progress]** Importing into an existing project is not yet supported. Currently, a new project is always created.<br/>
        /// Existing project ID to import media into. If not provided, a new project will be created.<br/>
        /// When importing into an existing project, media filenames must not conflict with existing files.<br/>
        /// Example: 9f36ee32-5a2c-47e7-b1a3-94991d3e3ddb
        /// </summary>
        /// <example>9f36ee32-5a2c-47e7-b1a3-94991d3e3ddb</example>
        [global::Newtonsoft.Json.JsonProperty("project_id")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// Name for the new project. Only used when project_id is not provided.<br/>
        /// Example: Marketing Video
        /// </summary>
        /// <example>Marketing Video</example>
        [global::Newtonsoft.Json.JsonProperty("project_name")]
        public string? ProjectName { get; set; }

        /// <summary>
        /// Access level for drive members. Only applicable when creating a new project<br/>
        /// (when project_id is not provided). Defaults to `none` if not specified.<br/>
        /// - edit: Users can edit the project<br/>
        /// - comment: Users can view and comment but not edit<br/>
        /// - view: Users can view but not comment or edit<br/>
        /// - none: No shared access (private to owner)<br/>
        /// Default Value: none<br/>
        /// Example: edit
        /// </summary>
        /// <example>edit</example>
        [global::Newtonsoft.Json.JsonProperty("team_access")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ImportProjectMediaRequestTeamAccessJsonConverter))]
        public global::G.ImportProjectMediaRequestTeamAccess? TeamAccess { get; set; }

        /// <summary>
        /// Map of media reference IDs (display names with optional folder paths) to media import items.<br/>
        /// Keys are the display names that will appear in the project (e.g., "Misc/intro.mp4" or "demo.mp4").<br/>
        /// Values define how to import each media item (URL import or multitrack sequence).<br/>
        /// Example: {"Misc/intro.mp4":{"url":"https://example.com/intro.mp4"},"demo.mp4":{"url":"https://example.com/demo.mp4"},"Multicam_Track":{"tracks":[{"media":"Recordings/camera1.mp4","offset":0},{"media":"Recordings/camera2.mp4","offset":50}]}}
        /// </summary>
        /// <example>{"Misc/intro.mp4":{"url":"https://example.com/intro.mp4"},"demo.mp4":{"url":"https://example.com/demo.mp4"},"Multicam_Track":{"tracks":[{"media":"Recordings/camera1.mp4","offset":0},{"media":"Recordings/camera2.mp4","offset":50}]}}</example>
        [global::Newtonsoft.Json.JsonProperty("add_media")]
        public global::System.Collections.Generic.Dictionary<string, global::G.OneOf<global::G.ImportProjectMediaRequestAddMediaUrlImport, global::G.ImportProjectMediaRequestAddMediaMultitrackSequence>>? AddMedia { get; set; }

        /// <summary>
        /// Optional list of compositions to create in the project
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("add_compositions")]
        public global::System.Collections.Generic.IList<global::G.ImportProjectMediaRequestAddComposition>? AddCompositions { get; set; }

        /// <summary>
        /// Optional webhook URL to call when the job completes or fails.<br/>
        /// Descript will POST the job status (same format as [GET /jobs/{job_id}](#operation/getJob)) to this URL.<br/>
        /// Example: https://example.com/webhooks/descript/job_callback
        /// </summary>
        /// <example>https://example.com/webhooks/descript/job_callback</example>
        [global::Newtonsoft.Json.JsonProperty("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportProjectMediaRequest" /> class.
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
        public ImportProjectMediaRequest(
            global::System.Guid? projectId,
            string? projectName,
            global::G.ImportProjectMediaRequestTeamAccess? teamAccess,
            global::System.Collections.Generic.Dictionary<string, global::G.OneOf<global::G.ImportProjectMediaRequestAddMediaUrlImport, global::G.ImportProjectMediaRequestAddMediaMultitrackSequence>>? addMedia,
            global::System.Collections.Generic.IList<global::G.ImportProjectMediaRequestAddComposition>? addCompositions,
            string? callbackUrl)
        {
            this.ProjectId = projectId;
            this.ProjectName = projectName;
            this.TeamAccess = teamAccess;
            this.AddMedia = addMedia;
            this.AddCompositions = addCompositions;
            this.CallbackUrl = callbackUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportProjectMediaRequest" /> class.
        /// </summary>
        public ImportProjectMediaRequest()
        {
        }
    }
}