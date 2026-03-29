//HintName: G.Models.MetricsFilterBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MetricsFilterBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filter", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.FilterNode Filter { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timeFilter", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.MetricsFilterBodyTimeFilter TimeFilter { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MetricsFilterBody" /> class.
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="timeFilter"></param>
        public MetricsFilterBody(
            global::G.FilterNode filter,
            global::G.MetricsFilterBodyTimeFilter timeFilter)
        {
            this.Filter = filter;
            this.TimeFilter = timeFilter ?? throw new global::System.ArgumentNullException(nameof(timeFilter));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetricsFilterBody" /> class.
        /// </summary>
        public MetricsFilterBody()
        {
        }
    }
}