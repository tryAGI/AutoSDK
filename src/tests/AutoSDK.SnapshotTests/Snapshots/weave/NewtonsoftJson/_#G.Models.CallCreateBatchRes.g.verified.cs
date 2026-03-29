//HintName: G.Models.CallCreateBatchRes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CallCreateBatchRes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("res", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.AnyOf<global::G.CallStartRes, global::G.CallEndRes>> Res { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallCreateBatchRes" /> class.
        /// </summary>
        /// <param name="res"></param>
        public CallCreateBatchRes(
            global::System.Collections.Generic.IList<global::G.AnyOf<global::G.CallStartRes, global::G.CallEndRes>> res)
        {
            this.Res = res ?? throw new global::System.ArgumentNullException(nameof(res));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallCreateBatchRes" /> class.
        /// </summary>
        public CallCreateBatchRes()
        {
        }
    }
}