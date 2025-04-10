//HintName: G.Models.ProductForUpdateRequestDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProductForUpdateRequestDto
    {
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
        [global::System.Text.Json.Serialization.JsonPropertyName("price")]
        public double? Price { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("productTypeEnumId")]
        public int? ProductTypeEnumId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("directSaleCommissionPercentage")]
        public double? DirectSaleCommissionPercentage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dailyRewardPercentage")]
        public double? DailyRewardPercentage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permitsRankQualification")]
        public bool? PermitsRankQualification { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permitsRankDirectActiveQualification")]
        public bool? PermitsRankDirectActiveQualification { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validityMonths")]
        public byte? ValidityMonths { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("countsTowardsCommissions")]
        public bool? CountsTowardsCommissions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("networkVolumePercentage")]
        public double? NetworkVolumePercentage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("educationPointsPercentage")]
        public double? EducationPointsPercentage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductForUpdateRequestDto" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <param name="productTypeEnumId"></param>
        /// <param name="directSaleCommissionPercentage"></param>
        /// <param name="dailyRewardPercentage"></param>
        /// <param name="permitsRankQualification"></param>
        /// <param name="permitsRankDirectActiveQualification"></param>
        /// <param name="validityMonths"></param>
        /// <param name="countsTowardsCommissions"></param>
        /// <param name="networkVolumePercentage"></param>
        /// <param name="educationPointsPercentage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProductForUpdateRequestDto(
            long? id,
            string? name,
            double? price,
            int? productTypeEnumId,
            double? directSaleCommissionPercentage,
            double? dailyRewardPercentage,
            bool? permitsRankQualification,
            bool? permitsRankDirectActiveQualification,
            byte? validityMonths,
            bool? countsTowardsCommissions,
            double? networkVolumePercentage,
            double? educationPointsPercentage)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.ProductTypeEnumId = productTypeEnumId;
            this.DirectSaleCommissionPercentage = directSaleCommissionPercentage;
            this.DailyRewardPercentage = dailyRewardPercentage;
            this.PermitsRankQualification = permitsRankQualification;
            this.PermitsRankDirectActiveQualification = permitsRankDirectActiveQualification;
            this.ValidityMonths = validityMonths;
            this.CountsTowardsCommissions = countsTowardsCommissions;
            this.NetworkVolumePercentage = networkVolumePercentage;
            this.EducationPointsPercentage = educationPointsPercentage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductForUpdateRequestDto" /> class.
        /// </summary>
        public ProductForUpdateRequestDto()
        {
        }
    }
}