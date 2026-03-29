//HintName: G.Models.AddSessionRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddSessionRequest
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
        /// Initializes a new instance of the <see cref="AddSessionRequest" /> class.
        /// </summary>
        /// <param name="sessionUUID"></param>
        public AddSessionRequest(
            string sessionUUID)
        {
            this.SessionUUID = sessionUUID ?? throw new global::System.ArgumentNullException(nameof(sessionUUID));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddSessionRequest" /> class.
        /// </summary>
        public AddSessionRequest()
        {
        }
    }
}