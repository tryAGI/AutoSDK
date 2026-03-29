//HintName: G.Models.MonitorResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MonitorResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("monitorId", Required = global::Newtonsoft.Json.Required.Always)]
        public string MonitorId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filterPassed", Required = global::Newtonsoft.Json.Required.Always)]
        public bool FilterPassed { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MonitorResult" /> class.
        /// </summary>
        /// <param name="monitorId"></param>
        /// <param name="filterPassed"></param>
        public MonitorResult(
            string monitorId,
            bool filterPassed)
        {
            this.MonitorId = monitorId ?? throw new global::System.ArgumentNullException(nameof(monitorId));
            this.FilterPassed = filterPassed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MonitorResult" /> class.
        /// </summary>
        public MonitorResult()
        {
        }
    }
}