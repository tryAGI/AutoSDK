//HintName: G.Models.VapiCost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VapiCost
    {
        /// <summary>
        /// This is the type of cost, always 'vapi' for this class.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.VapiCostTypeJsonConverter))]
        public global::G.VapiCostType Type { get; set; }

        /// <summary>
        /// This is the sub type of the cost.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("subType", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.VapiCostSubTypeJsonConverter))]
        public global::G.VapiCostSubType SubType { get; set; } = default!;

        /// <summary>
        /// This is the minutes of Vapi usage. This should match `call.endedAt` - `call.startedAt`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("minutes", Required = global::Newtonsoft.Json.Required.Always)]
        public double Minutes { get; set; } = default!;

        /// <summary>
        /// This is the cost of the component in USD.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cost", Required = global::Newtonsoft.Json.Required.Always)]
        public double Cost { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VapiCost" /> class.
        /// </summary>
        /// <param name="subType">
        /// This is the sub type of the cost.
        /// </param>
        /// <param name="minutes">
        /// This is the minutes of Vapi usage. This should match `call.endedAt` - `call.startedAt`.
        /// </param>
        /// <param name="cost">
        /// This is the cost of the component in USD.
        /// </param>
        /// <param name="type">
        /// This is the type of cost, always 'vapi' for this class.
        /// </param>
        public VapiCost(
            global::G.VapiCostSubType subType,
            double minutes,
            double cost,
            global::G.VapiCostType type)
        {
            this.Type = type;
            this.SubType = subType;
            this.Minutes = minutes;
            this.Cost = cost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VapiCost" /> class.
        /// </summary>
        public VapiCost()
        {
        }
    }
}