//HintName: G.Models.SearchRequestVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchRequestVariant2
    {
        /// <summary>
        /// Type of search to perform.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.SearchRequestVariant2Type? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRequestVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// Type of search to perform.
        /// </param>
        public SearchRequestVariant2(
            global::G.SearchRequestVariant2Type? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRequestVariant2" /> class.
        /// </summary>
        public SearchRequestVariant2()
        {
        }
    }
}