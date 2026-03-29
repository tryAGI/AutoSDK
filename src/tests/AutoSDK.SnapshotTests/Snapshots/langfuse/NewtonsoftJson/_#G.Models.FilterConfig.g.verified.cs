//HintName: G.Models.FilterConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FilterConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("supported", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Supported { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("maxResults", Required = global::Newtonsoft.Json.Required.Always)]
        public int MaxResults { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterConfig" /> class.
        /// </summary>
        /// <param name="supported"></param>
        /// <param name="maxResults"></param>
        public FilterConfig(
            bool supported,
            int maxResults)
        {
            this.Supported = supported;
            this.MaxResults = maxResults;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterConfig" /> class.
        /// </summary>
        public FilterConfig()
        {
        }
    }
}