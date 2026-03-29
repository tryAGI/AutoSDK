//HintName: G.Models.ChatCost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCost
    {
        /// <summary>
        /// This is the type of cost, always 'chat' for this class.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChatCostTypeJsonConverter))]
        public global::G.ChatCostType Type { get; set; }

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
        /// Initializes a new instance of the <see cref="ChatCost" /> class.
        /// </summary>
        /// <param name="cost">
        /// This is the cost of the component in USD.
        /// </param>
        /// <param name="type">
        /// This is the type of cost, always 'chat' for this class.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCost(
            double cost,
            global::G.ChatCostType type)
        {
            this.Type = type;
            this.Cost = cost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCost" /> class.
        /// </summary>
        public ChatCost()
        {
        }
    }
}