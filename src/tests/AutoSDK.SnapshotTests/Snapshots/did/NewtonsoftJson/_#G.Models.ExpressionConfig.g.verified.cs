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
        [global::Newtonsoft.Json.JsonProperty("expressions", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ExpressionConfigExpression> Expressions { get; set; } = default!;

        /// <summary>
        /// Number of frames to use for the transition between expressions
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transition_frames")]
        public double? TransitionFrames { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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