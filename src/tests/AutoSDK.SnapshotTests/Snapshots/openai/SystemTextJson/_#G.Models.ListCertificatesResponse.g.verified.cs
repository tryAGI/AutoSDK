//HintName: G.Models.ListCertificatesResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListCertificatesResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.Certificate> Data { get; set; }

        /// <summary>
        /// Example: cert_abc
        /// </summary>
        /// <example>cert_abc</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_id")]
        public string? FirstId { get; set; }

        /// <summary>
        /// Example: cert_abc
        /// </summary>
        /// <example>cert_abc</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_id")]
        public string? LastId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ListCertificatesResponseObjectJsonConverter))]
        public global::G.ListCertificatesResponseObject Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListCertificatesResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="firstId">
        /// Example: cert_abc
        /// </param>
        /// <param name="lastId">
        /// Example: cert_abc
        /// </param>
        /// <param name="hasMore"></param>
        /// <param name="object"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListCertificatesResponse(
            global::System.Collections.Generic.IList<global::G.Certificate> data,
            bool hasMore,
            string? firstId,
            string? lastId,
            global::G.ListCertificatesResponseObject @object)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.HasMore = hasMore;
            this.FirstId = firstId;
            this.LastId = lastId;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListCertificatesResponse" /> class.
        /// </summary>
        public ListCertificatesResponse()
        {
        }
    }
}