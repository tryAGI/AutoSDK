//HintName: G.Models.SessionCost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SessionCost
    {
        /// <summary>
        /// This is the type of cost, always 'session' for this class.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.SessionCostTypeJsonConverter))]
        public global::G.SessionCostType Type { get; set; }

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
        /// Initializes a new instance of the <see cref="SessionCost" /> class.
        /// </summary>
        /// <param name="cost">
        /// This is the cost of the component in USD.
        /// </param>
        /// <param name="type">
        /// This is the type of cost, always 'session' for this class.
        /// </param>
        public SessionCost(
            double cost,
            global::G.SessionCostType type)
        {
            this.Type = type;
            this.Cost = cost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionCost" /> class.
        /// </summary>
        public SessionCost()
        {
        }
    }
}