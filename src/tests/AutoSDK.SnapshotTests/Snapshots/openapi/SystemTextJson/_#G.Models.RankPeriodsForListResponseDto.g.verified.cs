//HintName: G.Models.RankPeriodsForListResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RankPeriodsForListResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public long? Id { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RankPeriodsForListResponseDto" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RankPeriodsForListResponseDto(
            long? id,
            global::System.DateTime? startDate,
            global::System.DateTime? endDate)
        {
            this.Id = id;
            this.StartDate = startDate;
            this.EndDate = endDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RankPeriodsForListResponseDto" /> class.
        /// </summary>
        public RankPeriodsForListResponseDto()
        {
        }
    }
}