//HintName: G.Models.ProductDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProductDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("price")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Price { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("productType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ProductTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ProductType ProductType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("directSaleCommissionPercentage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double DirectSaleCommissionPercentage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dailyRewardPercentage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double DailyRewardPercentage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permitsRankQualification")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool PermitsRankQualification { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permitsRankDirectActiveQualification")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool PermitsRankDirectActiveQualification { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validityMonths")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte ValidityMonths { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("countsTowardsCommissions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CountsTowardsCommissions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("networkVolumePercentage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double NetworkVolumePercentage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("educationPointsPercentage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double EducationPointsPercentage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductDto" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <param name="productType"></param>
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
        public ProductDto(
            long id,
            string name,
            double price,
            global::G.ProductType productType,
            double directSaleCommissionPercentage,
            double dailyRewardPercentage,
            bool permitsRankQualification,
            bool permitsRankDirectActiveQualification,
            byte validityMonths,
            bool countsTowardsCommissions,
            double networkVolumePercentage,
            double educationPointsPercentage)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Price = price;
            this.ProductType = productType;
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
        /// Initializes a new instance of the <see cref="ProductDto" /> class.
        /// </summary>
        public ProductDto()
        {
        }
    }
}