//HintName: G.Models.OrderForListByUserIdResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrderForListByUserIdResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        public int? Index { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public long? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datePlaced")]
        public global::System.DateTime? DatePlaced { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        public long? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lineItems")]
        public global::System.Collections.Generic.IList<global::G.OrderLineItemDto>? LineItems { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appPurchase")]
        public bool? AppPurchase { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderForListByUserIdResponseDto" /> class.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="id"></param>
        /// <param name="datePlaced"></param>
        /// <param name="userId"></param>
        /// <param name="lineItems"></param>
        /// <param name="appPurchase"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrderForListByUserIdResponseDto(
            int? index,
            long? id,
            global::System.DateTime? datePlaced,
            long? userId,
            global::System.Collections.Generic.IList<global::G.OrderLineItemDto>? lineItems,
            bool? appPurchase)
        {
            this.Index = index;
            this.Id = id;
            this.DatePlaced = datePlaced;
            this.UserId = userId;
            this.LineItems = lineItems;
            this.AppPurchase = appPurchase;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderForListByUserIdResponseDto" /> class.
        /// </summary>
        public OrderForListByUserIdResponseDto()
        {
        }
    }
}