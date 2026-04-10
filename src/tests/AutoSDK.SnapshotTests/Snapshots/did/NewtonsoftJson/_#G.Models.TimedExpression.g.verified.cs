//HintName: G.Models.TimedExpression.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TimedExpression
    {
        /// <summary>
        /// The frame number for the expression start point.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_frame", Required = global::Newtonsoft.Json.Required.Always)]
        public double StartFrame { get; set; } = default!;

        /// <summary>
        /// The expression to use
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expression", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TimedExpressionExpressionJsonConverter))]
        public global::G.TimedExpressionExpression Expression { get; set; } = default!;

        /// <summary>
        /// Controls the intensity you want for this expression (between 0 no expression, 1 maximum)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("intensity", Required = global::Newtonsoft.Json.Required.Always)]
        public double Intensity { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TimedExpression" /> class.
        /// </summary>
        /// <param name="startFrame">
        /// The frame number for the expression start point.
        /// </param>
        /// <param name="expression">
        /// The expression to use
        /// </param>
        /// <param name="intensity">
        /// Controls the intensity you want for this expression (between 0 no expression, 1 maximum)
        /// </param>
        public TimedExpression(
            double startFrame,
            global::G.TimedExpressionExpression expression,
            double intensity)
        {
            this.StartFrame = startFrame;
            this.Expression = expression;
            this.Intensity = intensity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TimedExpression" /> class.
        /// </summary>
        public TimedExpression()
        {
        }
    }
}