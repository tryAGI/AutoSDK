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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TransportCostTypeJsonConverter))]
        public global::G.TransportCostType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TransportCostProviderJsonConverter))]
        public global::G.TransportCostProvider? Provider { get; set; }

        /// <summary>
        /// This is the minutes of `transport` usage. This should match `call.endedAt` - `call.startedAt`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minutes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Minutes { get; set; }

        /// <summary>
        /// This is the cost of the component in USD.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Cost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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