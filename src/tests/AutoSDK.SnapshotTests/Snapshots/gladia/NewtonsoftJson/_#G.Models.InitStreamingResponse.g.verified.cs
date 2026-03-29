//HintName: G.Models.InitStreamingResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InitStreamingResponse
    {
        /// <summary>
        /// Id of the job<br/>
        /// Example: 45463597-20b7-4af7-b3b3-f5fb778203ab
        /// </summary>
        /// <example>45463597-20b7-4af7-b3b3-f5fb778203ab</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// Creation date<br/>
        /// Example: 2024-01-01T00:00:00.000Z
        /// </summary>
        /// <example>2024-01-01T00:00:00.000Z</example>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// The websocket url to connect to for sending audio data. The url will contain the temporary token to authenticate the session.<br/>
        /// Example: wss://api.gladia.io/v2/live?token=4a39145c-2844-4557-8f34-34883f7be7d9
        /// </summary>
        /// <example>wss://api.gladia.io/v2/live?token=4a39145c-2844-4557-8f34-34883f7be7d9</example>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InitStreamingResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Id of the job<br/>
        /// Example: 45463597-20b7-4af7-b3b3-f5fb778203ab
        /// </param>
        /// <param name="createdAt">
        /// Creation date<br/>
        /// Example: 2024-01-01T00:00:00.000Z
        /// </param>
        /// <param name="url">
        /// The websocket url to connect to for sending audio data. The url will contain the temporary token to authenticate the session.<br/>
        /// Example: wss://api.gladia.io/v2/live?token=4a39145c-2844-4557-8f34-34883f7be7d9
        /// </param>
        public InitStreamingResponse(
            global::System.Guid id,
            global::System.DateTime createdAt,
            string url)
        {
            this.Id = id;
            this.CreatedAt = createdAt;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InitStreamingResponse" /> class.
        /// </summary>
        public InitStreamingResponse()
        {
        }
    }
}