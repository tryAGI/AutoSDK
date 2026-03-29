//HintName: G.Models.PowParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PowParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ExpressionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Expression Base { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exponent")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ExpressionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Expression Exponent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PowParams" /> class.
        /// </summary>
        /// <param name="base"></param>
        /// <param name="exponent"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PowParams(
            global::G.Expression @base,
            global::G.Expression exponent)
        {
            this.Base = @base;
            this.Exponent = exponent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PowParams" /> class.
        /// </summary>
        public PowParams()
        {
        }
    }
}