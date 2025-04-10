//HintName: G.Models.MembersDownlineForDashboardResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MembersDownlineForDashboardResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("downLineLeft")]
        public int? DownLineLeft { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("downLineRight")]
        public int? DownLineRight { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MembersDownlineForDashboardResponseDto" /> class.
        /// </summary>
        /// <param name="downLineLeft"></param>
        /// <param name="downLineRight"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MembersDownlineForDashboardResponseDto(
            int? downLineLeft,
            int? downLineRight)
        {
            this.DownLineLeft = downLineLeft;
            this.DownLineRight = downLineRight;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MembersDownlineForDashboardResponseDto" /> class.
        /// </summary>
        public MembersDownlineForDashboardResponseDto()
        {
        }
    }
}