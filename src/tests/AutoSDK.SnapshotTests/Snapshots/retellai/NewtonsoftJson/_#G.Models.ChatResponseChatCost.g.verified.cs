//HintName: G.Models.ChatResponseChatCost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatResponseChatCost
    {
        /// <summary>
        /// List of products with their unit prices and costs in cents
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("product_costs")]
        public global::System.Collections.Generic.IList<global::G.ProductCost>? ProductCosts { get; set; }

        /// <summary>
        /// Combined cost of all individual costs in cents<br/>
        /// Example: 70
        /// </summary>
        /// <example>70</example>
        [global::Newtonsoft.Json.JsonProperty("combined_cost")]
        public double? CombinedCost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatResponseChatCost" /> class.
        /// </summary>
        /// <param name="productCosts">
        /// List of products with their unit prices and costs in cents
        /// </param>
        /// <param name="combinedCost">
        /// Combined cost of all individual costs in cents<br/>
        /// Example: 70
        /// </param>
        public ChatResponseChatCost(
            global::System.Collections.Generic.IList<global::G.ProductCost>? productCosts,
            double? combinedCost)
        {
            this.ProductCosts = productCosts;
            this.CombinedCost = combinedCost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatResponseChatCost" /> class.
        /// </summary>
        public ChatResponseChatCost()
        {
        }
    }
}