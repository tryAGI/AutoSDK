//HintName: G.Models.ClassificationTargetResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClassificationTargetResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scores")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, double> Scores { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassificationTargetResult" /> class.
        /// </summary>
        /// <param name="scores"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClassificationTargetResult(
            global::System.Collections.Generic.Dictionary<string, double> scores)
        {
            this.Scores = scores ?? throw new global::System.ArgumentNullException(nameof(scores));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassificationTargetResult" /> class.
        /// </summary>
        public ClassificationTargetResult()
        {
        }
    }
}