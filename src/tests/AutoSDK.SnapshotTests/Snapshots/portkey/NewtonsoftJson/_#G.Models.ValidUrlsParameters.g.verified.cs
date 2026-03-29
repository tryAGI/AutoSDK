//HintName: G.Models.ValidUrlsParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ValidUrlsParameters
    {
        /// <summary>
        /// Only check if URL domains resolve (10x faster)<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("onlyDNS")]
        public bool? OnlyDNS { get; set; }

        /// <summary>
        /// If true, the verdict will be inverted<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("not")]
        public bool? Not { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidUrlsParameters" /> class.
        /// </summary>
        /// <param name="onlyDNS">
        /// Only check if URL domains resolve (10x faster)<br/>
        /// Default Value: false
        /// </param>
        /// <param name="not">
        /// If true, the verdict will be inverted<br/>
        /// Default Value: false
        /// </param>
        public ValidUrlsParameters(
            bool? onlyDNS,
            bool? not)
        {
            this.OnlyDNS = onlyDNS;
            this.Not = not;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidUrlsParameters" /> class.
        /// </summary>
        public ValidUrlsParameters()
        {
        }
    }
}