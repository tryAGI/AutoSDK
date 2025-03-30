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
        [global::System.Text.Json.Serialization.JsonPropertyName("clickhouse_disk_free_pct")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ClickhouseDiskFreePct { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HealthInfoGetResponse" /> class.
        /// </summary>
        /// <param name="clickhouseDiskFreePct"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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