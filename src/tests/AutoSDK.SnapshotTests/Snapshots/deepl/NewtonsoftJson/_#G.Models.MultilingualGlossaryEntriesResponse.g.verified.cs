//HintName: G.Models.MultilingualGlossaryEntriesResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MultilingualGlossaryEntriesResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dictionaries")]
        public global::System.Collections.Generic.IList<global::G.MultilingualGlossaryEntriesInformation>? Dictionaries { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MultilingualGlossaryEntriesResponse" /> class.
        /// </summary>
        /// <param name="dictionaries"></param>
        public MultilingualGlossaryEntriesResponse(
            global::System.Collections.Generic.IList<global::G.MultilingualGlossaryEntriesInformation>? dictionaries)
        {
            this.Dictionaries = dictionaries;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultilingualGlossaryEntriesResponse" /> class.
        /// </summary>
        public MultilingualGlossaryEntriesResponse()
        {
        }
    }
}