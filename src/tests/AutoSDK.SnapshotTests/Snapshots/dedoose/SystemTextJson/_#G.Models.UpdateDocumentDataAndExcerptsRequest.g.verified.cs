//HintName: G.Models.UpdateDocumentDataAndExcerptsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateDocumentDataAndExcerptsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ResourceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedTextDataURI")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedTextDataURI { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedLength")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int UpdatedLength { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("excerpts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.Excerpt> Excerpts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDocumentDataAndExcerptsRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="resourceId"></param>
        /// <param name="updatedTextDataURI"></param>
        /// <param name="updatedLength"></param>
        /// <param name="excerpts"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateDocumentDataAndExcerptsRequest(
            global::System.Guid projectId,
            global::System.Guid userId,
            global::System.Guid resourceId,
            string updatedTextDataURI,
            int updatedLength,
            global::System.Collections.Generic.IList<global::G.Excerpt> excerpts)
        {
            this.ProjectId = projectId;
            this.UserId = userId;
            this.ResourceId = resourceId;
            this.UpdatedTextDataURI = updatedTextDataURI ?? throw new global::System.ArgumentNullException(nameof(updatedTextDataURI));
            this.UpdatedLength = updatedLength;
            this.Excerpts = excerpts ?? throw new global::System.ArgumentNullException(nameof(excerpts));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDocumentDataAndExcerptsRequest" /> class.
        /// </summary>
        public UpdateDocumentDataAndExcerptsRequest()
        {
        }
    }
}