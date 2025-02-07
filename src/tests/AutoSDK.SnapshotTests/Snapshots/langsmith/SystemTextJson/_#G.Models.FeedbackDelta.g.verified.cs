//HintName: G.Models.FeedbackDelta.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Feedback key with number of improvements and regressions.
    /// </summary>
    public sealed partial class FeedbackDelta
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("improved_examples")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> ImprovedExamples { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("regressed_examples")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> RegressedExamples { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackDelta" /> class.
        /// </summary>
        /// <param name="improvedExamples"></param>
        /// <param name="regressedExamples"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FeedbackDelta(
            global::System.Collections.Generic.IList<global::System.Guid> improvedExamples,
            global::System.Collections.Generic.IList<global::System.Guid> regressedExamples)
        {
            this.ImprovedExamples = improvedExamples ?? throw new global::System.ArgumentNullException(nameof(improvedExamples));
            this.RegressedExamples = regressedExamples ?? throw new global::System.ArgumentNullException(nameof(regressedExamples));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackDelta" /> class.
        /// </summary>
        public FeedbackDelta()
        {
        }
    }
}