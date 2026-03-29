//HintName: G.Models.AgentEditJobResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentEditJobResponse
    {
        /// <summary>
        /// Unique identifier for the Agent edit job<br/>
        /// Example: 6dc3f30a-58c2-4174-96a6-dc18cf3c7776
        /// </summary>
        /// <example>6dc3f30a-58c2-4174-96a6-dc18cf3c7776</example>
        [global::Newtonsoft.Json.JsonProperty("job_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid JobId { get; set; } = default!;

        /// <summary>
        /// Drive ID where the project is located<br/>
        /// Example: c9c5c47e-158a-49f7-846b-4f6ee2a229a2
        /// </summary>
        /// <example>c9c5c47e-158a-49f7-846b-4f6ee2a229a2</example>
        [global::Newtonsoft.Json.JsonProperty("drive_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid DriveId { get; set; } = default!;

        /// <summary>
        /// The project ID (existing or newly created)<br/>
        /// Example: 9f36ee32-5a2c-47e7-b1a3-94991d3e3ddb
        /// </summary>
        /// <example>9f36ee32-5a2c-47e7-b1a3-94991d3e3ddb</example>
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// URL to access the project in Descript web app<br/>
        /// Example: https://web.descript.com/9f36ee32-5a2c-47e7-b1a3-94991d3e3ddb
        /// </summary>
        /// <example>https://web.descript.com/9f36ee32-5a2c-47e7-b1a3-94991d3e3ddb</example>
        [global::Newtonsoft.Json.JsonProperty("project_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentEditJobResponse" /> class.
        /// </summary>
        /// <param name="jobId">
        /// Unique identifier for the Agent edit job<br/>
        /// Example: 6dc3f30a-58c2-4174-96a6-dc18cf3c7776
        /// </param>
        /// <param name="driveId">
        /// Drive ID where the project is located<br/>
        /// Example: c9c5c47e-158a-49f7-846b-4f6ee2a229a2
        /// </param>
        /// <param name="projectId">
        /// The project ID (existing or newly created)<br/>
        /// Example: 9f36ee32-5a2c-47e7-b1a3-94991d3e3ddb
        /// </param>
        /// <param name="projectUrl">
        /// URL to access the project in Descript web app<br/>
        /// Example: https://web.descript.com/9f36ee32-5a2c-47e7-b1a3-94991d3e3ddb
        /// </param>
        public AgentEditJobResponse(
            global::System.Guid jobId,
            global::System.Guid driveId,
            global::System.Guid projectId,
            string projectUrl)
        {
            this.JobId = jobId;
            this.DriveId = driveId;
            this.ProjectId = projectId;
            this.ProjectUrl = projectUrl ?? throw new global::System.ArgumentNullException(nameof(projectUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentEditJobResponse" /> class.
        /// </summary>
        public AgentEditJobResponse()
        {
        }
    }
}