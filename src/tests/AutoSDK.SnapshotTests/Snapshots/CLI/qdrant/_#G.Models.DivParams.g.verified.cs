//HintName: G.Models.DivParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DivParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("left")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ExpressionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Expression Left { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("right")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ExpressionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Expression Right { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("by_zero_default")]
        public float? ByZeroDefault { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DivParams" /> class.
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <param name="byZeroDefault"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DivParams(
            global::G.Expression left,
            global::G.Expression right,
            float? byZeroDefault)
        {
            this.Left = left;
            this.Right = right;
            this.ByZeroDefault = byZeroDefault;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DivParams" /> class.
        /// </summary>
        public DivParams()
        {
        }
    }
}