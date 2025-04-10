//HintName: G.Models.PromotionalEventForListResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromotionalEventForListResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promotionalEventImages")]
        public global::System.Collections.Generic.IList<global::G.PromotionalEventForListPromotionalEventImageRequestDto>? PromotionalEventImages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public long? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startDate")]
        public global::System.DateTime? StartDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endDate")]
        public global::System.DateTime? EndDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promotionTypeEnumId")]
        public int? PromotionTypeEnumId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdDateUtc")]
        public global::System.DateTime? CreatedDateUtc { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isActive")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customField1")]
        public string? CustomField1 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customField2")]
        public string? CustomField2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customField3")]
        public string? CustomField3 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customField4")]
        public string? CustomField4 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customField5")]
        public string? CustomField5 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customField6")]
        public string? CustomField6 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customField7")]
        public string? CustomField7 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customField8")]
        public string? CustomField8 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customField9")]
        public string? CustomField9 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customField10")]
        public string? CustomField10 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customField11")]
        public string? CustomField11 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customField12")]
        public string? CustomField12 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customField13")]
        public string? CustomField13 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromotionalEventForListResponseDto" /> class.
        /// </summary>
        /// <param name="promotionalEventImages"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="promotionTypeEnumId"></param>
        /// <param name="createdDateUtc"></param>
        /// <param name="isActive"></param>
        /// <param name="customField1"></param>
        /// <param name="customField2"></param>
        /// <param name="customField3"></param>
        /// <param name="customField4"></param>
        /// <param name="customField5"></param>
        /// <param name="customField6"></param>
        /// <param name="customField7"></param>
        /// <param name="customField8"></param>
        /// <param name="customField9"></param>
        /// <param name="customField10"></param>
        /// <param name="customField11"></param>
        /// <param name="customField12"></param>
        /// <param name="customField13"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromotionalEventForListResponseDto(
            global::System.Collections.Generic.IList<global::G.PromotionalEventForListPromotionalEventImageRequestDto>? promotionalEventImages,
            long? id,
            string? name,
            global::System.DateTime? startDate,
            global::System.DateTime? endDate,
            int? promotionTypeEnumId,
            global::System.DateTime? createdDateUtc,
            bool? isActive,
            string? customField1,
            string? customField2,
            string? customField3,
            string? customField4,
            string? customField5,
            string? customField6,
            string? customField7,
            string? customField8,
            string? customField9,
            string? customField10,
            string? customField11,
            string? customField12,
            string? customField13)
        {
            this.PromotionalEventImages = promotionalEventImages;
            this.Id = id;
            this.Name = name;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.PromotionTypeEnumId = promotionTypeEnumId;
            this.CreatedDateUtc = createdDateUtc;
            this.IsActive = isActive;
            this.CustomField1 = customField1;
            this.CustomField2 = customField2;
            this.CustomField3 = customField3;
            this.CustomField4 = customField4;
            this.CustomField5 = customField5;
            this.CustomField6 = customField6;
            this.CustomField7 = customField7;
            this.CustomField8 = customField8;
            this.CustomField9 = customField9;
            this.CustomField10 = customField10;
            this.CustomField11 = customField11;
            this.CustomField12 = customField12;
            this.CustomField13 = customField13;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromotionalEventForListResponseDto" /> class.
        /// </summary>
        public PromotionalEventForListResponseDto()
        {
        }
    }
}