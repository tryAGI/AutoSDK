//HintName: G.Models.ProjectsUpdateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectsUpdateRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Optional metadata for the project
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Number of days to retain data.<br/>
        /// Must be 0 or at least 3 days.<br/>
        /// Requires data-retention entitlement for non-zero values.<br/>
        /// Optional. Will retain existing retention setting if omitted.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("retention")]
        public int? Retention { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsUpdateRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="metadata">
        /// Optional metadata for the project
        /// </param>
        /// <param name="retention">
        /// Number of days to retain data.<br/>
        /// Must be 0 or at least 3 days.<br/>
        /// Requires data-retention entitlement for non-zero values.<br/>
        /// Optional. Will retain existing retention setting if omitted.
        /// </param>
        public ProjectsUpdateRequest(
            string name,
            object? metadata,
            int? retention)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Metadata = metadata;
            this.Retention = retention;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsUpdateRequest" /> class.
        /// </summary>
        public ProjectsUpdateRequest()
        {
        }
    }
}