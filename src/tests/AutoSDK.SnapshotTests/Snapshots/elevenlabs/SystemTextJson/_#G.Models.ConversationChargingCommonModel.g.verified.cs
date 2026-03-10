//HintName: G.Models.ConversationChargingCommonModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationChargingCommonModel
    {
        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dev_discount")]
        public bool? DevDiscount { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_burst")]
        public bool? IsBurst { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tier")]
        public string? Tier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_usage")]
        public global::G.LLMCategoryUsage? LlmUsage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_price")]
        public double? LlmPrice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_charge")]
        public int? LlmCharge { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_charge")]
        public int? CallCharge { get; set; }

        /// <summary>
        /// Default Value: 0F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("free_minutes_consumed")]
        public double? FreeMinutesConsumed { get; set; }

        /// <summary>
        /// Default Value: 0F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("free_llm_dollars_consumed")]
        public double? FreeLlmDollarsConsumed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationChargingCommonModel" /> class.
        /// </summary>
        /// <param name="devDiscount">
        /// Default Value: false
        /// </param>
        /// <param name="isBurst">
        /// Default Value: false
        /// </param>
        /// <param name="tier"></param>
        /// <param name="llmUsage"></param>
        /// <param name="llmPrice"></param>
        /// <param name="llmCharge"></param>
        /// <param name="callCharge"></param>
        /// <param name="freeMinutesConsumed">
        /// Default Value: 0F
        /// </param>
        /// <param name="freeLlmDollarsConsumed">
        /// Default Value: 0F
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationChargingCommonModel(
            bool? devDiscount,
            bool? isBurst,
            string? tier,
            global::G.LLMCategoryUsage? llmUsage,
            double? llmPrice,
            int? llmCharge,
            int? callCharge,
            double? freeMinutesConsumed,
            double? freeLlmDollarsConsumed)
        {
            this.DevDiscount = devDiscount;
            this.IsBurst = isBurst;
            this.Tier = tier;
            this.LlmUsage = llmUsage;
            this.LlmPrice = llmPrice;
            this.LlmCharge = llmCharge;
            this.CallCharge = callCharge;
            this.FreeMinutesConsumed = freeMinutesConsumed;
            this.FreeLlmDollarsConsumed = freeLlmDollarsConsumed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationChargingCommonModel" /> class.
        /// </summary>
        public ConversationChargingCommonModel()
        {
        }
    }
}