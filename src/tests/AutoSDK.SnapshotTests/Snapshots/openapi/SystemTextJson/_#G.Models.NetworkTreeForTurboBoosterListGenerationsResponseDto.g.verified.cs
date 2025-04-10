//HintName: G.Models.NetworkTreeForTurboBoosterListGenerationsResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NetworkTreeForTurboBoosterListGenerationsResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation")]
        public int? Generation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userCount")]
        public int? UserCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bonus")]
        public double? Bonus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unlocked")]
        public bool? Unlocked { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkTreeForTurboBoosterListGenerationsResponseDto" /> class.
        /// </summary>
        /// <param name="generation"></param>
        /// <param name="userCount"></param>
        /// <param name="bonus"></param>
        /// <param name="unlocked"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NetworkTreeForTurboBoosterListGenerationsResponseDto(
            int? generation,
            int? userCount,
            double? bonus,
            bool? unlocked)
        {
            this.Generation = generation;
            this.UserCount = userCount;
            this.Bonus = bonus;
            this.Unlocked = unlocked;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkTreeForTurboBoosterListGenerationsResponseDto" /> class.
        /// </summary>
        public NetworkTreeForTurboBoosterListGenerationsResponseDto()
        {
        }
    }
}