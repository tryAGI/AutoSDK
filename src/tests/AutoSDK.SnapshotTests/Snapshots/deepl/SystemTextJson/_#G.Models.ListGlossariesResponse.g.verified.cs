//HintName: G.Models.ListGlossariesResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListGlossariesResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("glossaries")]
        public global::System.Collections.Generic.IList<global::G.MonolingualGlossary>? Glossaries { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListGlossariesResponse" /> class.
        /// </summary>
        /// <param name="glossaries"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListGlossariesResponse(
            global::System.Collections.Generic.IList<global::G.MonolingualGlossary>? glossaries)
        {
            this.Glossaries = glossaries;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListGlossariesResponse" /> class.
        /// </summary>
        public ListGlossariesResponse()
        {
        }
    }
}