//HintName: G.Models.DirectReferralForListResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DirectReferralForListResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userName")]
        public string? UserName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dateOfJoining")]
        public global::System.DateTime? DateOfJoining { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("leg")]
        public string? Leg { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dateOfActivation")]
        public global::System.DateTime? DateOfActivation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("activePackageValue")]
        public double? ActivePackageValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectReferralForListResponseDto" /> class.
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="dateOfJoining"></param>
        /// <param name="leg"></param>
        /// <param name="dateOfActivation"></param>
        /// <param name="activePackageValue"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DirectReferralForListResponseDto(
            string? userName,
            global::System.DateTime? dateOfJoining,
            string? leg,
            global::System.DateTime? dateOfActivation,
            double? activePackageValue)
        {
            this.UserName = userName;
            this.DateOfJoining = dateOfJoining;
            this.Leg = leg;
            this.DateOfActivation = dateOfActivation;
            this.ActivePackageValue = activePackageValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectReferralForListResponseDto" /> class.
        /// </summary>
        public DirectReferralForListResponseDto()
        {
        }
    }
}