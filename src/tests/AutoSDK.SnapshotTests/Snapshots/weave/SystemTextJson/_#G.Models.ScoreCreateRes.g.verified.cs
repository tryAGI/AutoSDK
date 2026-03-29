//HintName: G.Models.ScoreCreateRes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScoreCreateRes
    {
        /// <summary>
        /// The score ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ScoreId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScoreCreateRes" /> class.
        /// </summary>
        /// <param name="scoreId">
        /// The score ID
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScoreCreateRes(
            string scoreId)
        {
            this.ScoreId = scoreId ?? throw new global::System.ArgumentNullException(nameof(scoreId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScoreCreateRes" /> class.
        /// </summary>
        public ScoreCreateRes()
        {
        }
    }
}