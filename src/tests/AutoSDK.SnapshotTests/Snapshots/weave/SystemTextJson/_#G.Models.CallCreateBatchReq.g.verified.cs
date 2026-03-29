//HintName: G.Models.CallCreateBatchReq.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CallCreateBatchReq
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.AnyOf<global::G.CallBatchStartMode, global::G.CallBatchEndMode>> Batch { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallCreateBatchReq" /> class.
        /// </summary>
        /// <param name="batch"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallCreateBatchReq(
            global::System.Collections.Generic.IList<global::G.AnyOf<global::G.CallBatchStartMode, global::G.CallBatchEndMode>> batch)
        {
            this.Batch = batch ?? throw new global::System.ArgumentNullException(nameof(batch));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallCreateBatchReq" /> class.
        /// </summary>
        public CallCreateBatchReq()
        {
        }
    }
}