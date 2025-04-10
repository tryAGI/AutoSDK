//HintName: G.Models.ActivePackageValueByUserIdResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActivePackageValueByUserIdResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalActivePackageValue")]
        public double? TotalActivePackageValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivePackageValueByUserIdResponseDto" /> class.
        /// </summary>
        /// <param name="totalActivePackageValue"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActivePackageValueByUserIdResponseDto(
            double? totalActivePackageValue)
        {
            this.TotalActivePackageValue = totalActivePackageValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivePackageValueByUserIdResponseDto" /> class.
        /// </summary>
        public ActivePackageValueByUserIdResponseDto()
        {
        }
    }
}