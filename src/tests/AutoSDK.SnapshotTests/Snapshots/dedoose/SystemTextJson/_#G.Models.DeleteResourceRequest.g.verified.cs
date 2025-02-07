//HintName: G.Models.DeleteResourceRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteResourceRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currentProjectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid CurrentProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Resource Resource { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteResourceRequest" /> class.
        /// </summary>
        /// <param name="currentProjectId"></param>
        /// <param name="resource"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteResourceRequest(
            global::System.Guid currentProjectId,
            global::G.Resource resource)
        {
            this.CurrentProjectId = currentProjectId;
            this.Resource = resource ?? throw new global::System.ArgumentNullException(nameof(resource));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteResourceRequest" /> class.
        /// </summary>
        public DeleteResourceRequest()
        {
        }
    }
}