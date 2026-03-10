//HintName: G.Models.KnowledgeBaseSourceFileUrlResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class KnowledgeBaseSourceFileUrlResponseModel
    {
        /// <summary>
        /// Signed URL to download the source file directly
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signed_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SignedUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBaseSourceFileUrlResponseModel" /> class.
        /// </summary>
        /// <param name="signedUrl">
        /// Signed URL to download the source file directly
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KnowledgeBaseSourceFileUrlResponseModel(
            string signedUrl)
        {
            this.SignedUrl = signedUrl ?? throw new global::System.ArgumentNullException(nameof(signedUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBaseSourceFileUrlResponseModel" /> class.
        /// </summary>
        public KnowledgeBaseSourceFileUrlResponseModel()
        {
        }
    }
}