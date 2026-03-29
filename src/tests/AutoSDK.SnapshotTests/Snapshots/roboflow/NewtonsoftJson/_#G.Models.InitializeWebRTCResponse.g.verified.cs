//HintName: G.Models.InitializeWebRTCResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InitializeWebRTCResponse
    {
        /// <summary>
        /// Operation status
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public string Status { get; set; } = default!;

        /// <summary>
        /// Context of the command.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("context", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CommandContext Context { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sdp", Required = global::Newtonsoft.Json.Required.Always)]
        public string Sdp { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InitializeWebRTCResponse" /> class.
        /// </summary>
        /// <param name="status">
        /// Operation status
        /// </param>
        /// <param name="context">
        /// Context of the command.
        /// </param>
        /// <param name="sdp"></param>
        /// <param name="type"></param>
        public InitializeWebRTCResponse(
            string status,
            global::G.CommandContext context,
            string sdp,
            string type)
        {
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.Context = context ?? throw new global::System.ArgumentNullException(nameof(context));
            this.Sdp = sdp ?? throw new global::System.ArgumentNullException(nameof(sdp));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InitializeWebRTCResponse" /> class.
        /// </summary>
        public InitializeWebRTCResponse()
        {
        }
    }
}