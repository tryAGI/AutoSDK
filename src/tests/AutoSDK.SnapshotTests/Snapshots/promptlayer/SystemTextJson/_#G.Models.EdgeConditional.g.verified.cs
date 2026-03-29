//HintName: G.Models.EdgeConditional.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EdgeConditional
    {
        /// <summary>
        /// Order of evaluation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Position { get; set; }

        /// <summary>
        /// Comparison operator.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EdgeConditionalOperatorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.EdgeConditionalOperator Operator { get; set; }

        /// <summary>
        /// Left side of comparison. Can be static_value or source.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("left_config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object LeftConfig { get; set; }

        /// <summary>
        /// Right side of comparison. Can be static_value or source.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("right_config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object RightConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EdgeConditional" /> class.
        /// </summary>
        /// <param name="position">
        /// Order of evaluation.
        /// </param>
        /// <param name="operator">
        /// Comparison operator.
        /// </param>
        /// <param name="leftConfig">
        /// Left side of comparison. Can be static_value or source.
        /// </param>
        /// <param name="rightConfig">
        /// Right side of comparison. Can be static_value or source.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EdgeConditional(
            int position,
            global::G.EdgeConditionalOperator @operator,
            object leftConfig,
            object rightConfig)
        {
            this.Position = position;
            this.Operator = @operator;
            this.LeftConfig = leftConfig ?? throw new global::System.ArgumentNullException(nameof(leftConfig));
            this.RightConfig = rightConfig ?? throw new global::System.ArgumentNullException(nameof(rightConfig));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EdgeConditional" /> class.
        /// </summary>
        public EdgeConditional()
        {
        }
    }
}