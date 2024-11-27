//HintName: G.Models.DeleteTagByJobRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteTagByJobRequest
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
        [global::System.Text.Json.Serialization.JsonPropertyName("tag")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Tag Tag { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteTagByJobRequest" /> class.
        /// </summary>
        /// <param name="currentProjectId"></param>
        /// <param name="tag"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public DeleteTagByJobRequest(
            global::System.Guid currentProjectId,
            global::G.Tag tag)
        {
            this.CurrentProjectId = currentProjectId;
            this.Tag = tag ?? throw new global::System.ArgumentNullException(nameof(tag));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteTagByJobRequest" /> class.
        /// </summary>
        public DeleteTagByJobRequest()
        {
        }
    }
}