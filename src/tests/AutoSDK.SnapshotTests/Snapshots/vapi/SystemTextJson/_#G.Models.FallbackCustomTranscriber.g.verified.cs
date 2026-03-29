//HintName: G.Models.FallbackCustomTranscriber.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FallbackCustomTranscriber
    {
        /// <summary>
        /// This is the transcription provider that will be used. Use `custom-transcriber` for providers that are not natively supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FallbackCustomTranscriberProviderJsonConverter))]
        public global::G.FallbackCustomTranscriberProvider Provider { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("server")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Server Server { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FallbackCustomTranscriber" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FallbackCustomTranscriber(
            global::G.Server server,
            global::G.FallbackCustomTranscriberProvider provider)
        {
            this.Provider = provider;
            this.Server = server ?? throw new global::System.ArgumentNullException(nameof(server));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FallbackCustomTranscriber" /> class.
        /// </summary>
        public FallbackCustomTranscriber()
        {
        }
    }
}