//HintName: G.Models.EnvironmentsRegisterResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EnvironmentsRegisterResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("connectionId", Required = global::Newtonsoft.Json.Required.Always)]
        public string ConnectionId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("wsUrl", Required = global::Newtonsoft.Json.Required.Always)]
        public string WsUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentsRegisterResponse" /> class.
        /// </summary>
        /// <param name="connectionId"></param>
        /// <param name="wsUrl"></param>
        public EnvironmentsRegisterResponse(
            string connectionId,
            string wsUrl)
        {
            this.ConnectionId = connectionId ?? throw new global::System.ArgumentNullException(nameof(connectionId));
            this.WsUrl = wsUrl ?? throw new global::System.ArgumentNullException(nameof(wsUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentsRegisterResponse" /> class.
        /// </summary>
        public EnvironmentsRegisterResponse()
        {
        }
    }
}