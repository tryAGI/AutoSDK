//HintName: G.Models.AgentEditJobRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request to run Agent edit.<br/>
    /// The agent will interpret the prompt and either edit an existing project or create a new one.<br/>
    /// You must provide exactly one of `project_id` or `project_name`.
    /// </summary>
    public sealed partial class AgentEditJobRequest
    {
        /// <summary>
        /// The ID of an existing project to edit. Mutually exclusive with `project_name`.<br/>
        /// Example: 9f36ee32-5a2c-47e7-b1a3-94991d3e3ddb
        /// </summary>
        /// <example>9f36ee32-5a2c-47e7-b1a3-94991d3e3ddb</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// Name for creating a new project. Mutually exclusive with `project_id`.<br/>
        /// Example: My New Project
        /// </summary>
        /// <example>My New Project</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_name")]
        public string? ProjectName { get; set; }

        /// <summary>
        /// **[Work in progress]** This property is accepted but not yet functional. It will be ignored.<br/>
        /// Optional composition ID within the project to edit.<br/>
        /// Example: 39677a40-1c43-4c36-8449-46cfbc4de2b5
        /// </summary>
        /// <example>39677a40-1c43-4c36-8449-46cfbc4de2b5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("composition_id")]
        public global::System.Guid? CompositionId { get; set; }

        /// <summary>
        /// AI model to use for editing. Defaults to the default model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Natural language instruction for the agent to execute.<br/>
        /// Examples: "add studio sound to every clip", "remove all filler words", "create a 30-second highlight reel"<br/>
        /// Example: add studio sound to every clip
        /// </summary>
        /// <example>add studio sound to every clip</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Access level for team members when creating a new project.<br/>
        /// Only applicable when `project_name` is provided (not when using `project_id`).<br/>
        /// Defaults to `none` if not specified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_access")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AgentEditJobRequestTeamAccessJsonConverter))]
        public global::G.AgentEditJobRequestTeamAccess? TeamAccess { get; set; }

        /// <summary>
        /// Optional webhook URL to call when the job completes or fails.<br/>
        /// Descript will POST the job status (same format as [GET /jobs/{job_id}](#operation/getJob)) to this URL.<br/>
        /// Example: https://example.com/webhooks/descript/job_callback
        /// </summary>
        /// <example>https://example.com/webhooks/descript/job_callback</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentEditJobRequest" /> class.
        /// </summary>
        /// <param name="prompt">
        /// Natural language instruction for the agent to execute.<br/>
        /// Examples: "add studio sound to every clip", "remove all filler words", "create a 30-second highlight reel"<br/>
        /// Example: add studio sound to every clip
        /// </param>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentEditJobRequest(
            string prompt,
            global::System.Guid? projectId,
            string? projectName,
            global::System.Guid? compositionId,
            string? model,
            global::G.AgentEditJobRequestTeamAccess? teamAccess,
            string? callbackUrl)
        {
            this.ProjectId = projectId;
            this.ProjectName = projectName;
            this.CompositionId = compositionId;
            this.Model = model;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.TeamAccess = teamAccess;
            this.CallbackUrl = callbackUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentEditJobRequest" /> class.
        /// </summary>
        public AgentEditJobRequest()
        {
        }
    }
}