//HintName: G.Models.PostToolsExecuteProxyRequestBinaryBodyVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostToolsExecuteProxyRequestBinaryBodyVariant2
    {
        /// <summary>
        /// Base64-encoded binary data
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base64")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Base64 { get; set; }

        /// <summary>
        /// Content-Type header to use for the request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_type")]
        public string? ContentType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolsExecuteProxyRequestBinaryBodyVariant2" /> class.
        /// </summary>
        /// <param name="base64">
        /// Base64-encoded binary data
        /// </param>
        /// <param name="contentType">
        /// Content-Type header to use for the request
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostToolsExecuteProxyRequestBinaryBodyVariant2(
            string base64,
            string? contentType)
        {
            this.Base64 = base64 ?? throw new global::System.ArgumentNullException(nameof(base64));
            this.ContentType = contentType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolsExecuteProxyRequestBinaryBodyVariant2" /> class.
        /// </summary>
        public PostToolsExecuteProxyRequestBinaryBodyVariant2()
        {
        }
    }
}