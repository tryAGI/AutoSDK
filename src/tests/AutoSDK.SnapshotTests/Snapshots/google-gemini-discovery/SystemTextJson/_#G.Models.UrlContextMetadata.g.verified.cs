//HintName: G.Models.UrlContextMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Metadata related to url context retrieval tool.
    /// </summary>
    public sealed partial class UrlContextMetadata
    {
        /// <summary>
        /// List of url context.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("urlMetadata")]
        public global::System.Collections.Generic.IList<global::G.UrlMetadata>? UrlMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UrlContextMetadata" /> class.
        /// </summary>
        /// <param name="urlMetadata">
        /// List of url context.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UrlContextMetadata(
            global::System.Collections.Generic.IList<global::G.UrlMetadata>? urlMetadata)
        {
            this.UrlMetadata = urlMetadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UrlContextMetadata" /> class.
        /// </summary>
        public UrlContextMetadata()
        {
        }
    }
}