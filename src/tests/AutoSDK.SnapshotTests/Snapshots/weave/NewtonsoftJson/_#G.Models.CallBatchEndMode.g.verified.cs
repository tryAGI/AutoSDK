//HintName: G.Models.CallBatchEndMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CallBatchEndMode
    {
        /// <summary>
        /// Default Value: end
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mode")]
        public string? Mode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("req", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CallEndReq Req { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallBatchEndMode" /> class.
        /// </summary>
        /// <param name="req"></param>
        /// <param name="mode">
        /// Default Value: end
        /// </param>
        public CallBatchEndMode(
            global::G.CallEndReq req,
            string? mode)
        {
            this.Mode = mode;
            this.Req = req ?? throw new global::System.ArgumentNullException(nameof(req));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallBatchEndMode" /> class.
        /// </summary>
        public CallBatchEndMode()
        {
        }
    }
}