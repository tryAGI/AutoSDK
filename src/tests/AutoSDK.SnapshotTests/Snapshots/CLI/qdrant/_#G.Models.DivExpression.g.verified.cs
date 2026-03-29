//HintName: G.Models.DivExpression.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DivExpression
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("div")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.DivParams Div { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DivExpression" /> class.
        /// </summary>
        /// <param name="div"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DivExpression(
            global::G.DivParams div)
        {
            this.Div = div ?? throw new global::System.ArgumentNullException(nameof(div));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DivExpression" /> class.
        /// </summary>
        public DivExpression()
        {
        }
    }
}