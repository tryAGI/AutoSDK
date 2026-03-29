//HintName: G.Models.ListMultilingualGlossariesResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListMultilingualGlossariesResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("glossaries")]
        public global::System.Collections.Generic.IList<global::G.MultilingualGlossary>? Glossaries { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListMultilingualGlossariesResponse" /> class.
        /// </summary>
        /// <param name="glossaries"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListMultilingualGlossariesResponse(
            global::System.Collections.Generic.IList<global::G.MultilingualGlossary>? glossaries)
        {
            this.Glossaries = glossaries;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListMultilingualGlossariesResponse" /> class.
        /// </summary>
        public ListMultilingualGlossariesResponse()
        {
        }
    }
}