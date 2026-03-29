//HintName: G.Models.GetApiKeyRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetApiKeyRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sessionUUID", Required = global::Newtonsoft.Json.Required.Always)]
        public string SessionUUID { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetApiKeyRequest" /> class.
        /// </summary>
        /// <param name="sessionUUID"></param>
        public GetApiKeyRequest(
            string sessionUUID)
        {
            this.SessionUUID = sessionUUID ?? throw new global::System.ArgumentNullException(nameof(sessionUUID));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetApiKeyRequest" /> class.
        /// </summary>
        public GetApiKeyRequest()
        {
        }
    }
}