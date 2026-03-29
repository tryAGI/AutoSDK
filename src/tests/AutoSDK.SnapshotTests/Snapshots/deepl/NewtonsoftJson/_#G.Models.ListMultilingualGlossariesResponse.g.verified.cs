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
        [global::Newtonsoft.Json.JsonProperty("glossaries")]
        public global::System.Collections.Generic.IList<global::G.MultilingualGlossary>? Glossaries { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListMultilingualGlossariesResponse" /> class.
        /// </summary>
        /// <param name="glossaries"></param>
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