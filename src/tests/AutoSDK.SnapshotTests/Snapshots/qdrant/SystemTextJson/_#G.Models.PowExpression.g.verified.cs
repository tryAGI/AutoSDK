//HintName: G.Models.PowExpression.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PowExpression
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pow")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PowParams Pow { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PowExpression" /> class.
        /// </summary>
        /// <param name="pow"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PowExpression(
            global::G.PowParams pow)
        {
            this.Pow = pow ?? throw new global::System.ArgumentNullException(nameof(pow));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PowExpression" /> class.
        /// </summary>
        public PowExpression()
        {
        }
    }
}