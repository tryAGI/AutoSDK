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
        [global::Newtonsoft.Json.JsonProperty("glossaries")]
        public global::System.Collections.Generic.IList<global::G.MonolingualGlossary>? Glossaries { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListGlossariesResponse" /> class.
        /// </summary>
        /// <param name="glossaries"></param>
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