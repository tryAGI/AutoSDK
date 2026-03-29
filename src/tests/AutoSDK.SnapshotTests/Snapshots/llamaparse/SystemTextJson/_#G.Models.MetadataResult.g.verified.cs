//HintName: G.Models.MetadataResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Result containing metadata (page level and general) for the parsed document.
    /// </summary>
    public sealed partial class MetadataResult
    {
        /// <summary>
        /// List of page metadata entries
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.MetadataResultPage> Pages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataResult" /> class.
        /// </summary>
        /// <param name="pages">
        /// List of page metadata entries
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MetadataResult(
            global::System.Collections.Generic.IList<global::G.MetadataResultPage> pages)
        {
            this.Pages = pages ?? throw new global::System.ArgumentNullException(nameof(pages));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataResult" /> class.
        /// </summary>
        public MetadataResult()
        {
        }
    }
}