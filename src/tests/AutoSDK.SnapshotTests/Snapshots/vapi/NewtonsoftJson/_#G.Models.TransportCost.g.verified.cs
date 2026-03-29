//HintName: G.Models.TransportCost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TransportCost
    {
        /// <summary>
        /// This is the type of cost, always 'transport' for this class.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.TransportCostType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        public global::G.TransportCostProvider? Provider { get; set; }

        /// <summary>
        /// This is the minutes of `transport` usage. This should match `call.endedAt` - `call.startedAt`.
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
        /// Initializes a new instance of the <see cref="TransportCost" /> class.
        /// </summary>
        /// <param name="minutes">
        /// This is the minutes of `transport` usage. This should match `call.endedAt` - `call.startedAt`.
        /// </param>
        /// <param name="cost">
        /// This is the cost of the component in USD.
        /// </param>
        /// <param name="type">
        /// This is the type of cost, always 'transport' for this class.
        /// </param>
        /// <param name="provider"></param>
        public TransportCost(
            double minutes,
            double cost,
            global::G.TransportCostType type,
            global::G.TransportCostProvider? provider)
        {
            this.Type = type;
            this.Provider = provider;
            this.Minutes = minutes;
            this.Cost = cost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransportCost" /> class.
        /// </summary>
        public TransportCost()
        {
        }
    }
}