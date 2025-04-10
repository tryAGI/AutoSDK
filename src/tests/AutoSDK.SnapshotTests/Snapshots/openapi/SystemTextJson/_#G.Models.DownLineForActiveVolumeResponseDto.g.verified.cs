//HintName: G.Models.DownLineForActiveVolumeResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DownLineForActiveVolumeResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("legNo")]
        public long? LegNo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userName")]
        public string? UserName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dateOfProductSubscription")]
        public global::System.DateTime? DateOfProductSubscription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("productName")]
        public string? ProductName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volume")]
        public double? Volume { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("leg")]
        public string? Leg { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DownLineForActiveVolumeResponseDto" /> class.
        /// </summary>
        /// <param name="legNo"></param>
        /// <param name="userName"></param>
        /// <param name="dateOfProductSubscription"></param>
        /// <param name="productName"></param>
        /// <param name="volume"></param>
        /// <param name="leg"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DownLineForActiveVolumeResponseDto(
            long? legNo,
            string? userName,
            global::System.DateTime? dateOfProductSubscription,
            string? productName,
            double? volume,
            string? leg)
        {
            this.LegNo = legNo;
            this.UserName = userName;
            this.DateOfProductSubscription = dateOfProductSubscription;
            this.ProductName = productName;
            this.Volume = volume;
            this.Leg = leg;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DownLineForActiveVolumeResponseDto" /> class.
        /// </summary>
        public DownLineForActiveVolumeResponseDto()
        {
        }
    }
}