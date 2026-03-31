//HintName: G.Models.ExpressionConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExpressionConfig
    {
        /// <summary>
        /// List of TimedExpression to use
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expressions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ExpressionConfigExpression> Expressions { get; set; }

        /// <summary>
        /// Number of frames to use for the transition between expressions
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transition_frames")]
        public double? TransitionFrames { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExpressionConfig" /> class.
        /// </summary>
        /// <param name="expressions">
        /// List of TimedExpression to use
        /// </param>
        /// <param name="transitionFrames">
        /// Number of frames to use for the transition between expressions
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExpressionConfig(
            global::System.Collections.Generic.IList<global::G.ExpressionConfigExpression> expressions,
            double? transitionFrames)
        {
            this.Expressions = expressions ?? throw new global::System.ArgumentNullException(nameof(expressions));
            this.TransitionFrames = transitionFrames;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExpressionConfig" /> class.
        /// </summary>
        public ExpressionConfig()
        {
        }
    }
}