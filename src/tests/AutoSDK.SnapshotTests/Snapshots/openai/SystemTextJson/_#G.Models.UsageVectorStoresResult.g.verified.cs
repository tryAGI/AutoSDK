//HintName: G.Models.UsageVectorStoresResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The aggregated vector stores usage details of the specific time bucket.
    /// </summary>
    public sealed partial class UsageVectorStoresResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UsageVectorStoresResultObjectJsonConverter))]
        public global::G.UsageVectorStoresResultObject Object { get; set; }

        /// <summary>
        /// When `group_by=project_id`, this field provides the project ID of the grouped usage result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// The vector stores usage in bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int UsageBytes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageVectorStoresResult" /> class.
        /// </summary>
        /// <param name="object"></param>
        /// <param name="projectId">
        /// When `group_by=project_id`, this field provides the project ID of the grouped usage result.
        /// </param>
        /// <param name="usageBytes">
        /// The vector stores usage in bytes.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageVectorStoresResult(
            int usageBytes,
            global::G.UsageVectorStoresResultObject @object,
            string? projectId)
        {
            this.UsageBytes = usageBytes;
            this.Object = @object;
            this.ProjectId = projectId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageVectorStoresResult" /> class.
        /// </summary>
        public UsageVectorStoresResult()
        {
        }
    }
}