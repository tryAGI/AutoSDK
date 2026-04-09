//HintName: G.Models.CustomTranscriber.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomTranscriber
    {
        /// <summary>
        /// This is the transcription provider that will be used. Use `custom-transcriber` for providers that are not natively supported.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CustomTranscriberProviderJsonConverter))]
        public global::G.CustomTranscriberProvider Provider { get; set; }

        /// <summary>
        /// This is where the transcription request will be sent.<br/>
        /// Usage:<br/>
        /// 1. Vapi will initiate a websocket connection with `server.url`.<br/>
        /// 2. Vapi will send an initial text frame with the sample rate. Format:<br/>
        /// ```<br/>
        ///     {<br/>
        ///       "type": "start",<br/>
        ///       "encoding": "linear16", // 16-bit raw PCM format<br/>
        ///       "container": "raw",<br/>
        ///       "sampleRate": {{sampleRate}},<br/>
        ///       "channels": 2 // customer is channel 0, assistant is channel 1<br/>
        ///     }<br/>
        /// ```<br/>
        /// 3. Vapi will send the audio data in 16-bit raw PCM format as binary frames.<br/>
        /// 4. You can read the messages something like this:<br/>
        /// ```<br/>
        /// ws.on('message', (data, isBinary) =&gt; {<br/>
        ///   if (isBinary) {<br/>
        ///     pcmBuffer = Buffer.concat([pcmBuffer, data]);<br/>
        ///     console.log(`Received PCM data, buffer size: ${pcmBuffer.length}`);<br/>
        ///   } else {<br/>
        ///     console.log('Received message:', JSON.parse(data.toString()));<br/>
        ///   }<br/>
        /// });<br/>
        /// ```<br/>
        /// 5. You will respond with transcriptions as you have them. Format:<br/>
        /// ```<br/>
        ///  {<br/>
        ///     "type": "transcriber-response",<br/>
        ///     "transcription": "Hello, world!",<br/>
        ///     "channel": "customer" | "assistant"<br/>
        ///  }<br/>
        /// ```
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("server", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Server Server { get; set; } = default!;

        /// <summary>
        /// This is the plan for transcriber provider fallbacks in the event that the primary transcriber provider fails.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fallbackPlan")]
        public global::G.FallbackTranscriberPlan? FallbackPlan { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomTranscriber" /> class.
        /// </summary>
        /// <param name="server">
        /// This is where the transcription request will be sent.<br/>
        /// Usage:<br/>
        /// 1. Vapi will initiate a websocket connection with `server.url`.<br/>
        /// 2. Vapi will send an initial text frame with the sample rate. Format:<br/>
        /// ```<br/>
        ///     {<br/>
        ///       "type": "start",<br/>
        ///       "encoding": "linear16", // 16-bit raw PCM format<br/>
        ///       "container": "raw",<br/>
        ///       "sampleRate": {{sampleRate}},<br/>
        ///       "channels": 2 // customer is channel 0, assistant is channel 1<br/>
        ///     }<br/>
        /// ```<br/>
        /// 3. Vapi will send the audio data in 16-bit raw PCM format as binary frames.<br/>
        /// 4. You can read the messages something like this:<br/>
        /// ```<br/>
        /// ws.on('message', (data, isBinary) =&gt; {<br/>
        ///   if (isBinary) {<br/>
        ///     pcmBuffer = Buffer.concat([pcmBuffer, data]);<br/>
        ///     console.log(`Received PCM data, buffer size: ${pcmBuffer.length}`);<br/>
        ///   } else {<br/>
        ///     console.log('Received message:', JSON.parse(data.toString()));<br/>
        ///   }<br/>
        /// });<br/>
        /// ```<br/>
        /// 5. You will respond with transcriptions as you have them. Format:<br/>
        /// ```<br/>
        ///  {<br/>
        ///     "type": "transcriber-response",<br/>
        ///     "transcription": "Hello, world!",<br/>
        ///     "channel": "customer" | "assistant"<br/>
        ///  }<br/>
        /// ```
        /// </param>
        /// <param name="provider">
        /// This is the transcription provider that will be used. Use `custom-transcriber` for providers that are not natively supported.
        /// </param>
        /// <param name="fallbackPlan">
        /// This is the plan for transcriber provider fallbacks in the event that the primary transcriber provider fails.
        /// </param>
        public CustomTranscriber(
            global::G.Server server,
            global::G.CustomTranscriberProvider provider,
            global::G.FallbackTranscriberPlan? fallbackPlan)
        {
            this.Provider = provider;
            this.Server = server ?? throw new global::System.ArgumentNullException(nameof(server));
            this.FallbackPlan = fallbackPlan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomTranscriber" /> class.
        /// </summary>
        public CustomTranscriber()
        {
        }
    }
}