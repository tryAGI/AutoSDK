//HintName: G.Models.SumExpression.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SumExpression
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sum")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.Expression> Sum { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SumExpression" /> class.
        /// </summary>
        /// <param name="sum"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SumExpression(
            global::System.Collections.Generic.IList<global::G.Expression> sum)
        {
            this.Sum = sum ?? throw new global::System.ArgumentNullException(nameof(sum));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SumExpression" /> class.
        /// </summary>
        public SumExpression()
        {
        }
    }
}