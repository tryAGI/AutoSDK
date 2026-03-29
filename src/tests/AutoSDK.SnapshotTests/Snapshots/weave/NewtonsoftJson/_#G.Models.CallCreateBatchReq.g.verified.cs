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
        [global::Newtonsoft.Json.JsonProperty("batch", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.AnyOf<global::G.CallBatchStartMode, global::G.CallBatchEndMode>> Batch { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallCreateBatchReq" /> class.
        /// </summary>
        /// <param name="batch"></param>
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