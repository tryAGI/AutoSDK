//HintName: G.Models.DeleteTagLinkRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteTagLinkRequest
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
        [global::System.Text.Json.Serialization.JsonPropertyName("link")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TagLink Link { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteTagLinkRequest" /> class.
        /// </summary>
        /// <param name="currentProjectId"></param>
        /// <param name="link"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteTagLinkRequest(
            global::System.Guid currentProjectId,
            global::G.TagLink link)
        {
            this.CurrentProjectId = currentProjectId;
            this.Link = link ?? throw new global::System.ArgumentNullException(nameof(link));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteTagLinkRequest" /> class.
        /// </summary>
        public DeleteTagLinkRequest()
        {
        }
    }
}