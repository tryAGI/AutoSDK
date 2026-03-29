//HintName: G.Models.TypedProviderRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TypedProviderRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Construct a type with a set of properties K of type T
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("json")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RecordStringUnknown Json { get; set; }

        /// <summary>
        /// Construct a type with a set of properties K of type T
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Meta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TypedProviderRequest" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="json">
        /// Construct a type with a set of properties K of type T
        /// </param>
        /// <param name="meta">
        /// Construct a type with a set of properties K of type T
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TypedProviderRequest(
            string url,
            global::G.RecordStringUnknown json,
            global::System.Collections.Generic.Dictionary<string, string> meta)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Json = json ?? throw new global::System.ArgumentNullException(nameof(json));
            this.Meta = meta ?? throw new global::System.ArgumentNullException(nameof(meta));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TypedProviderRequest" /> class.
        /// </summary>
        public TypedProviderRequest()
        {
        }
    }
}