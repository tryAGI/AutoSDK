//HintName: G.Models.CreateTalkRequestConfigDriverExpressionsExpression2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTalkRequestConfigDriverExpressionsExpression2
    {
        /// <summary>
        /// The frame number for the expression start point.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_frame")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double StartFrame { get; set; }

        /// <summary>
        /// The expression to use
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expression")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateTalkRequestConfigDriverExpressionsExpressionExpression2JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CreateTalkRequestConfigDriverExpressionsExpressionExpression2 Expression { get; set; }

        /// <summary>
        /// Controls the intensity you want for this expression (between 0 no expression, 1 maximum)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("intensity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Intensity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTalkRequestConfigDriverExpressionsExpression2" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTalkRequestConfigDriverExpressionsExpression2(
            double startFrame,
            global::G.CreateTalkRequestConfigDriverExpressionsExpressionExpression2 expression,
            double intensity)
        {
            this.StartFrame = startFrame;
            this.Expression = expression;
            this.Intensity = intensity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTalkRequestConfigDriverExpressionsExpression2" /> class.
        /// </summary>
        public CreateTalkRequestConfigDriverExpressionsExpression2()
        {
        }
    }
}