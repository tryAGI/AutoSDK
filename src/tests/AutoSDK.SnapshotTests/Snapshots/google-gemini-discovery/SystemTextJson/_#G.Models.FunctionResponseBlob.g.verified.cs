//HintName: G.Models.FunctionResponseBlob.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Raw media bytes for function response. Text should not be sent as raw bytes, use the 'FunctionResponse.response' field.
    /// </summary>
    public sealed partial class FunctionResponseBlob
    {
        /// <summary>
        /// The IANA standard MIME type of the source data. Examples: - image/png - image/jpeg If an unsupported MIME type is provided, an error will be returned. For a complete list of supported types, see [Supported file formats](https://ai.google.dev/gemini-api/docs/prompting_with_media#supported_file_formats).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mimeType")]
        public string? MimeType { get; set; }

        /// <summary>
        /// Raw bytes for media formats.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public byte[]? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionResponseBlob" /> class.
        /// </summary>
        /// <param name="mimeType">
        /// The IANA standard MIME type of the source data. Examples: - image/png - image/jpeg If an unsupported MIME type is provided, an error will be returned. For a complete list of supported types, see [Supported file formats](https://ai.google.dev/gemini-api/docs/prompting_with_media#supported_file_formats).
        /// </param>
        /// <param name="data">
        /// Raw bytes for media formats.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FunctionResponseBlob(
            string? mimeType,
            byte[]? data)
        {
            this.MimeType = mimeType;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionResponseBlob" /> class.
        /// </summary>
        public FunctionResponseBlob()
        {
        }
    }
}