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
        [global::Newtonsoft.Json.JsonProperty("position", Required = global::Newtonsoft.Json.Required.Always)]
        public int Position { get; set; } = default!;

        /// <summary>
        /// Comparison operator.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("operator", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.EdgeConditionalOperatorJsonConverter))]
        public global::G.EdgeConditionalOperator Operator { get; set; } = default!;

        /// <summary>
        /// Left side of comparison. Can be static_value or source.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("left_config", Required = global::Newtonsoft.Json.Required.Always)]
        public object LeftConfig { get; set; } = default!;

        /// <summary>
        /// Right side of comparison. Can be static_value or source.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("right_config", Required = global::Newtonsoft.Json.Required.Always)]
        public object RightConfig { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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