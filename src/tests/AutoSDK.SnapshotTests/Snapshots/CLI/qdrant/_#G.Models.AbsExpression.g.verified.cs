//HintName: G.Models.AbsExpression.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AbsExpression
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("abs")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ExpressionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Expression Abs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AbsExpression" /> class.
        /// </summary>
        /// <param name="abs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AbsExpression(
            global::G.Expression abs)
        {
            this.Abs = abs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AbsExpression" /> class.
        /// </summary>
        public AbsExpression()
        {
        }
    }
}