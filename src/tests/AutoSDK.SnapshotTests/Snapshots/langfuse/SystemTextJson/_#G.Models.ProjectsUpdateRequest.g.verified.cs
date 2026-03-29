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
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Optional metadata for the project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Number of days to retain data.<br/>
        /// Must be 0 or at least 3 days.<br/>
        /// Requires data-retention entitlement for non-zero values.<br/>
        /// Optional. Will retain existing retention setting if omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retention")]
        public int? Retention { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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