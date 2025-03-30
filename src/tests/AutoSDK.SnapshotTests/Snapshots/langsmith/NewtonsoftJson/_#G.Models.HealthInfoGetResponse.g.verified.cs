//HintName: G.Models.HealthInfoGetResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The LangSmith server info.
    /// </summary>
    public sealed partial class HealthInfoGetResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("clickhouse_disk_free_pct", Required = global::Newtonsoft.Json.Required.Always)]
        public double ClickhouseDiskFreePct { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HealthInfoGetResponse" /> class.
        /// </summary>
        /// <param name="clickhouseDiskFreePct"></param>
        public HealthInfoGetResponse(
            double clickhouseDiskFreePct)
        {
            this.ClickhouseDiskFreePct = clickhouseDiskFreePct;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HealthInfoGetResponse" /> class.
        /// </summary>
        public HealthInfoGetResponse()
        {
        }
    }
}