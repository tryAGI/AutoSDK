//HintName: G.Models.WebSearchData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebSearchData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sources", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.WebSearchDataSource> Sources { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchData" /> class.
        /// </summary>
        /// <param name="sources"></param>
        public WebSearchData(
            global::System.Collections.Generic.IList<global::G.WebSearchDataSource> sources)
        {
            this.Sources = sources ?? throw new global::System.ArgumentNullException(nameof(sources));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchData" /> class.
        /// </summary>
        public WebSearchData()
        {
        }
    }
}