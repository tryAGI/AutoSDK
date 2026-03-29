//HintName: G.Models.WebSearchServerToolFilters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebSearchServerToolFilters
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allowed_domains")]
        public global::System.Collections.Generic.IList<string>? AllowedDomains { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("excluded_domains")]
        public global::System.Collections.Generic.IList<string>? ExcludedDomains { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchServerToolFilters" /> class.
        /// </summary>
        /// <param name="allowedDomains"></param>
        /// <param name="excludedDomains"></param>
        public WebSearchServerToolFilters(
            global::System.Collections.Generic.IList<string>? allowedDomains,
            global::System.Collections.Generic.IList<string>? excludedDomains)
        {
            this.AllowedDomains = allowedDomains;
            this.ExcludedDomains = excludedDomains;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchServerToolFilters" /> class.
        /// </summary>
        public WebSearchServerToolFilters()
        {
        }
    }
}