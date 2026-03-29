//HintName: G.Models.ProjectsCreateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectsCreateRequest
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
        /// Number of days to retain data. Must be 0 or at least 3 days. Requires data-retention entitlement for non-zero values. Optional.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retention")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Retention { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsCreateRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="retention">
        /// Number of days to retain data. Must be 0 or at least 3 days. Requires data-retention entitlement for non-zero values. Optional.
        /// </param>
        /// <param name="metadata">
        /// Optional metadata for the project
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectsCreateRequest(
            string name,
            int retention,
            object? metadata)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Metadata = metadata;
            this.Retention = retention;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsCreateRequest" /> class.
        /// </summary>
        public ProjectsCreateRequest()
        {
        }
    }
}