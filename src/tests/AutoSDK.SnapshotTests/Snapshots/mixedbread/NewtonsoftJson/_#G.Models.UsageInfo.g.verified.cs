//HintName: G.Models.UsageInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Resource usage information.
    /// </summary>
    public sealed partial class UsageInfo
    {
        /// <summary>
        /// The current usage of the resource<br/>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("current")]
        public string? Current { get; set; }

        /// <summary>
        /// The limit of the resource
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit")]
        public string? Limit { get; set; }

        /// <summary>
        /// The unit of the resource
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("unit")]
        public string? Unit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageInfo" /> class.
        /// </summary>
        /// <param name="current">
        /// The current usage of the resource<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// The limit of the resource
        /// </param>
        /// <param name="unit">
        /// The unit of the resource
        /// </param>
        public UsageInfo(
            string? current,
            string? limit,
            string? unit)
        {
            this.Current = current;
            this.Limit = limit;
            this.Unit = unit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageInfo" /> class.
        /// </summary>
        public UsageInfo()
        {
        }
    }
}