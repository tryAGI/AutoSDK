//HintName: G.Models.SqrtExpression.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SqrtExpression
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sqrt")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ExpressionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Expression Sqrt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SqrtExpression" /> class.
        /// </summary>
        /// <param name="sqrt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SqrtExpression(
            global::G.Expression sqrt)
        {
            this.Sqrt = sqrt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqrtExpression" /> class.
        /// </summary>
        public SqrtExpression()
        {
        }
    }
}