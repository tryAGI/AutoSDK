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
        [global::Newtonsoft.Json.JsonProperty("vals", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<object> Vals { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RefsReadBatchRes" /> class.
        /// </summary>
        /// <param name="vals"></param>
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