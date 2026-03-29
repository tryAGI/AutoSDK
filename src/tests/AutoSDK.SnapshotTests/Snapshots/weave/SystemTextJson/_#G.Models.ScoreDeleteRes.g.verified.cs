//HintName: G.Models.ScoreDeleteRes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScoreDeleteRes
    {
        /// <summary>
        /// Number of scores deleted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_deleted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumDeleted { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScoreDeleteRes" /> class.
        /// </summary>
        /// <param name="numDeleted">
        /// Number of scores deleted
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScoreDeleteRes(
            int numDeleted)
        {
            this.NumDeleted = numDeleted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScoreDeleteRes" /> class.
        /// </summary>
        public ScoreDeleteRes()
        {
        }
    }
}