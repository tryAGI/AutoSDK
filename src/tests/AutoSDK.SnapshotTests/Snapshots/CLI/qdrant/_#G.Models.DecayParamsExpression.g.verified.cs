//HintName: G.Models.DecayParamsExpression.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DecayParamsExpression
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("x")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ExpressionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Expression X { get; set; }

        /// <summary>
        /// The target value to start decaying from. Defaults to 0.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        public global::G.Expression? Target { get; set; }

        /// <summary>
        /// The scale factor of the decay, in terms of `x`. Defaults to 1.0. Must be a non-zero positive number.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scale")]
        public float? Scale { get; set; }

        /// <summary>
        /// The midpoint of the decay. Should be between 0 and 1.Defaults to 0.5. Output will be this value when `|x - target| == scale`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("midpoint")]
        public float? Midpoint { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DecayParamsExpression" /> class.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="target">
        /// The target value to start decaying from. Defaults to 0.
        /// </param>
        /// <param name="scale">
        /// The scale factor of the decay, in terms of `x`. Defaults to 1.0. Must be a non-zero positive number.
        /// </param>
        /// <param name="midpoint">
        /// The midpoint of the decay. Should be between 0 and 1.Defaults to 0.5. Output will be this value when `|x - target| == scale`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DecayParamsExpression(
            global::G.Expression x,
            global::G.Expression? target,
            float? scale,
            float? midpoint)
        {
            this.X = x;
            this.Target = target;
            this.Scale = scale;
            this.Midpoint = midpoint;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DecayParamsExpression" /> class.
        /// </summary>
        public DecayParamsExpression()
        {
        }
    }
}