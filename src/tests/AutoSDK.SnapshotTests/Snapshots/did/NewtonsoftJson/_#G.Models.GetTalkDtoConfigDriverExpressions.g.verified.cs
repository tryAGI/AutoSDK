//HintName: G.Models.GetTalkDtoConfigDriverExpressions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// timed expressions for animation, the current expression is not cleared until a new expression is defined.<br/>
    /// Possible expressions include `happy`, `neutral` and more.
    /// </summary>
    public sealed partial class GetTalkDtoConfigDriverExpressions
    {
        /// <summary>
        /// List of TimedExpression to use
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expressions", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.GetTalkDtoConfigDriverExpressionsExpression> Expressions { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="GetTalkDtoConfigDriverExpressions" /> class.
        /// </summary>
        /// <param name="expressions">
        /// List of TimedExpression to use
        /// </param>
        /// <param name="transitionFrames">
        /// Number of frames to use for the transition between expressions
        /// </param>
        public GetTalkDtoConfigDriverExpressions(
            global::System.Collections.Generic.IList<global::G.GetTalkDtoConfigDriverExpressionsExpression> expressions,
            double? transitionFrames)
        {
            this.Expressions = expressions ?? throw new global::System.ArgumentNullException(nameof(expressions));
            this.TransitionFrames = transitionFrames;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTalkDtoConfigDriverExpressions" /> class.
        /// </summary>
        public GetTalkDtoConfigDriverExpressions()
        {
        }
    }
}