//HintName: G.Models.NetworkBonusItemForListResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NetworkBonusItemForListResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public global::System.DateTime? Timestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("leg1BroughtForward")]
        public double? Leg1BroughtForward { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("leg2BroughtForward")]
        public double? Leg2BroughtForward { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("leg1New")]
        public double? Leg1New { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("leg2New")]
        public double? Leg2New { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("leg1Total")]
        public double? Leg1Total { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("leg2Total")]
        public double? Leg2Total { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weakLeg")]
        public double? WeakLeg { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("networkBonus")]
        public double? NetworkBonus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("leg1CarryForward")]
        public double? Leg1CarryForward { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("leg2CarryForward")]
        public double? Leg2CarryForward { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("productSubscriptionId")]
        public long? ProductSubscriptionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkBonusItemForListResponseDto" /> class.
        /// </summary>
        /// <param name="timestamp"></param>
        /// <param name="leg1BroughtForward"></param>
        /// <param name="leg2BroughtForward"></param>
        /// <param name="leg1New"></param>
        /// <param name="leg2New"></param>
        /// <param name="leg1Total"></param>
        /// <param name="leg2Total"></param>
        /// <param name="weakLeg"></param>
        /// <param name="networkBonus"></param>
        /// <param name="leg1CarryForward"></param>
        /// <param name="leg2CarryForward"></param>
        /// <param name="productSubscriptionId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NetworkBonusItemForListResponseDto(
            global::System.DateTime? timestamp,
            double? leg1BroughtForward,
            double? leg2BroughtForward,
            double? leg1New,
            double? leg2New,
            double? leg1Total,
            double? leg2Total,
            double? weakLeg,
            double? networkBonus,
            double? leg1CarryForward,
            double? leg2CarryForward,
            long? productSubscriptionId)
        {
            this.Timestamp = timestamp;
            this.Leg1BroughtForward = leg1BroughtForward;
            this.Leg2BroughtForward = leg2BroughtForward;
            this.Leg1New = leg1New;
            this.Leg2New = leg2New;
            this.Leg1Total = leg1Total;
            this.Leg2Total = leg2Total;
            this.WeakLeg = weakLeg;
            this.NetworkBonus = networkBonus;
            this.Leg1CarryForward = leg1CarryForward;
            this.Leg2CarryForward = leg2CarryForward;
            this.ProductSubscriptionId = productSubscriptionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkBonusItemForListResponseDto" /> class.
        /// </summary>
        public NetworkBonusItemForListResponseDto()
        {
        }
    }
}