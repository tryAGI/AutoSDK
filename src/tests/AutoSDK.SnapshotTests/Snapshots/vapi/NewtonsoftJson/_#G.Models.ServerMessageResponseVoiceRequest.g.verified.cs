//HintName: G.Models.ServerMessageResponseVoiceRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ServerMessageResponseVoiceRequest
    {
        /// <summary>
        /// DO NOT respond to a `voice-request` webhook with this schema of { data }. This schema just exists to document what the response should look like. Follow these instructions:<br/>
        /// Here is what the request will look like:<br/>
        /// POST https://{assistant.voice.server.url}<br/>
        /// Content-Type: application/json<br/>
        /// {<br/>
        ///   "messsage": {<br/>
        ///     "type": "voice-request",<br/>
        ///     "text": "Hello, world!",<br/>
        ///     "sampleRate": 24000,<br/>
        ///     ...other metadata about the call...<br/>
        ///   }<br/>
        /// }<br/>
        /// The expected response is 1-channel 16-bit raw PCM audio at the sample rate specified in the request. Here is how the response will be piped to the transport:<br/>
        /// ```<br/>
        /// response.on('data', (chunk: Buffer) =&gt; {<br/>
        ///   outputStream.write(chunk);<br/>
        /// });<br/>
        /// ```
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public string Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerMessageResponseVoiceRequest" /> class.
        /// </summary>
        /// <param name="data">
        /// DO NOT respond to a `voice-request` webhook with this schema of { data }. This schema just exists to document what the response should look like. Follow these instructions:<br/>
        /// Here is what the request will look like:<br/>
        /// POST https://{assistant.voice.server.url}<br/>
        /// Content-Type: application/json<br/>
        /// {<br/>
        ///   "messsage": {<br/>
        ///     "type": "voice-request",<br/>
        ///     "text": "Hello, world!",<br/>
        ///     "sampleRate": 24000,<br/>
        ///     ...other metadata about the call...<br/>
        ///   }<br/>
        /// }<br/>
        /// The expected response is 1-channel 16-bit raw PCM audio at the sample rate specified in the request. Here is how the response will be piped to the transport:<br/>
        /// ```<br/>
        /// response.on('data', (chunk: Buffer) =&gt; {<br/>
        ///   outputStream.write(chunk);<br/>
        /// });<br/>
        /// ```
        /// </param>
        public ServerMessageResponseVoiceRequest(
            string data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerMessageResponseVoiceRequest" /> class.
        /// </summary>
        public ServerMessageResponseVoiceRequest()
        {
        }
    }
}