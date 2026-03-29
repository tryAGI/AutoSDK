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
        [global::Newtonsoft.Json.JsonProperty("score_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ScoreId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScoreCreateRes" /> class.
        /// </summary>
        /// <param name="scoreId">
        /// The score ID
        /// </param>
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