//HintName: G.Models.DecayParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Additional parameters for the Decay operator.
    /// </summary>
    public sealed partial class DecayParams
    {
        /// <summary>
        /// The midpoint of the Decay operator.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("midpoint")]
        public object? Midpoint { get; set; }

        /// <summary>
        /// An exponent that helps further control the shape of the Decay function.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exponent")]
        public double? Exponent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DecayParams" /> class.
        /// </summary>
        /// <param name="midpoint">
        /// The midpoint of the Decay operator.
        /// </param>
        /// <param name="exponent">
        /// An exponent that helps further control the shape of the Decay function.
        /// </param>
        public DecayParams(
            object? midpoint,
            double? exponent)
        {
            this.Midpoint = midpoint;
            this.Exponent = exponent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DecayParams" /> class.
        /// </summary>
        public DecayParams()
        {
        }
    }
}