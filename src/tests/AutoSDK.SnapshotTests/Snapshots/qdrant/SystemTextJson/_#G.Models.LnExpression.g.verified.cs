//HintName: G.Models.LnExpression.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LnExpression
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ln")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ExpressionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Expression Ln { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LnExpression" /> class.
        /// </summary>
        /// <param name="ln"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LnExpression(
            global::G.Expression ln)
        {
            this.Ln = ln;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LnExpression" /> class.
        /// </summary>
        public LnExpression()
        {
        }
    }
}