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
        [global::Newtonsoft.Json.JsonProperty("refs", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Refs { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RefsReadBatchReq" /> class.
        /// </summary>
        /// <param name="refs"></param>
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