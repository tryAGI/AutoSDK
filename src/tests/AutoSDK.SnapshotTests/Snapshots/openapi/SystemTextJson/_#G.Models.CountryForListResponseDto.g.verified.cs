//HintName: G.Models.CountryForListResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CountryForListResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isoCode")]
        public string? IsoCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dialInCode")]
        public string? DialInCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        public string? Region { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CountryForListResponseDto" /> class.
        /// </summary>
        /// <param name="isoCode"></param>
        /// <param name="name"></param>
        /// <param name="dialInCode"></param>
        /// <param name="region"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CountryForListResponseDto(
            string? isoCode,
            string? name,
            string? dialInCode,
            string? region)
        {
            this.IsoCode = isoCode;
            this.Name = name;
            this.DialInCode = dialInCode;
            this.Region = region;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CountryForListResponseDto" /> class.
        /// </summary>
        public CountryForListResponseDto()
        {
        }
    }
}