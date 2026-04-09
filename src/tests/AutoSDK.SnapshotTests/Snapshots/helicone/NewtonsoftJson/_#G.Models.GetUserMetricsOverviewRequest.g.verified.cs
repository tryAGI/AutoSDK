//HintName: G.Models.GetUserMetricsOverviewRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetUserMetricsOverviewRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("useInterquartile", Required = global::Newtonsoft.Json.Required.Always)]
        public bool UseInterquartile { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pSize", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.PSizeJsonConverter))]
        public global::G.PSize PSize { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filter", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.UserFilterNode Filter { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUserMetricsOverviewRequest" /> class.
        /// </summary>
        /// <param name="useInterquartile"></param>
        /// <param name="pSize"></param>
        /// <param name="filter"></param>
        public GetUserMetricsOverviewRequest(
            bool useInterquartile,
            global::G.PSize pSize,
            global::G.UserFilterNode filter)
        {
            this.UseInterquartile = useInterquartile;
            this.PSize = pSize;
            this.Filter = filter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUserMetricsOverviewRequest" /> class.
        /// </summary>
        public GetUserMetricsOverviewRequest()
        {
        }
    }
}