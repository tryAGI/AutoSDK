//HintName: G.Models.RefsReadBatchRes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RefsReadBatchRes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vals")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> Vals { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RefsReadBatchRes" /> class.
        /// </summary>
        /// <param name="vals"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RefsReadBatchRes(
            global::System.Collections.Generic.IList<object> vals)
        {
            this.Vals = vals ?? throw new global::System.ArgumentNullException(nameof(vals));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RefsReadBatchRes" /> class.
        /// </summary>
        public RefsReadBatchRes()
        {
        }
    }
}