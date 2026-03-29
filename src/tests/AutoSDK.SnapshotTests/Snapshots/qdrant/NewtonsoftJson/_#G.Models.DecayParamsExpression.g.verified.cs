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
        [global::Newtonsoft.Json.JsonProperty("x", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Expression X { get; set; } = default!;

        /// <summary>
        /// The target value to start decaying from. Defaults to 0.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target")]
        public global::G.Expression? Target { get; set; }

        /// <summary>
        /// The scale factor of the decay, in terms of `x`. Defaults to 1.0. Must be a non-zero positive number.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scale")]
        public float? Scale { get; set; }

        /// <summary>
        /// The midpoint of the decay. Should be between 0 and 1.Defaults to 0.5. Output will be this value when `|x - target| == scale`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("midpoint")]
        public float? Midpoint { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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