//HintName: G.Models.MostRightOrLeftResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MostRightOrLeftResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MostRightOrLeftResponseDto" /> class.
        /// </summary>
        /// <param name="userId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MostRightOrLeftResponseDto(
            long userId)
        {
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MostRightOrLeftResponseDto" /> class.
        /// </summary>
        public MostRightOrLeftResponseDto()
        {
        }
    }
}