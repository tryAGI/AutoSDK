//HintName: G.Models.MultExpression.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MultExpression
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mult")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.Expression> Mult { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MultExpression" /> class.
        /// </summary>
        /// <param name="mult"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MultExpression(
            global::System.Collections.Generic.IList<global::G.Expression> mult)
        {
            this.Mult = mult ?? throw new global::System.ArgumentNullException(nameof(mult));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultExpression" /> class.
        /// </summary>
        public MultExpression()
        {
        }
    }
}