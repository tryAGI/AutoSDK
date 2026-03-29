//HintName: G.Models.CallBatchStartMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CallBatchStartMode
    {
        /// <summary>
        /// Default Value: start
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mode")]
        public string? Mode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("req", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CallStartReq Req { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallBatchStartMode" /> class.
        /// </summary>
        /// <param name="req"></param>
        /// <param name="mode">
        /// Default Value: start
        /// </param>
        public CallBatchStartMode(
            global::G.CallStartReq req,
            string? mode)
        {
            this.Mode = mode;
            this.Req = req ?? throw new global::System.ArgumentNullException(nameof(req));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallBatchStartMode" /> class.
        /// </summary>
        public CallBatchStartMode()
        {
        }
    }
}