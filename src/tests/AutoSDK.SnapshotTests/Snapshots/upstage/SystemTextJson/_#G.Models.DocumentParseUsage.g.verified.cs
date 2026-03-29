//HintName: G.Models.DocumentParseUsage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DocumentParseUsage
    {
        /// <summary>
        /// Number of pages processed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pages")]
        public int? Pages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentParseUsage" /> class.
        /// </summary>
        /// <param name="pages">
        /// Number of pages processed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DocumentParseUsage(
            int? pages)
        {
            this.Pages = pages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentParseUsage" /> class.
        /// </summary>
        public DocumentParseUsage()
        {
        }
    }
}