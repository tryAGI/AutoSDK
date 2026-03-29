//HintName: G.Models.RefsReadBatchReq.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RefsReadBatchReq
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Refs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RefsReadBatchReq" /> class.
        /// </summary>
        /// <param name="refs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RefsReadBatchReq(
            global::System.Collections.Generic.IList<string> refs)
        {
            this.Refs = refs ?? throw new global::System.ArgumentNullException(nameof(refs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RefsReadBatchReq" /> class.
        /// </summary>
        public RefsReadBatchReq()
        {
        }
    }
}