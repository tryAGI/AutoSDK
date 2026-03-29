//HintName: G.Models.FallbackCustomVoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FallbackCustomVoice
    {
        /// <summary>
        /// This is the flag to toggle voice caching for the assistant.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cachingEnabled")]
        public bool? CachingEnabled { get; set; }

        /// <summary>
        /// This is the voice provider that will be used. Use `custom-voice` for providers that are not natively supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FallbackCustomVoiceProviderJsonConverter))]
        public global::G.FallbackCustomVoiceProvider Provider { get; set; }

        /// <summary>
        /// This is the provider-specific ID that will be used. This is passed in the voice request payload to identify the voice to use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voiceId")]
        public string? VoiceId { get; set; }

        /// <summary>
        /// This is where the voice request will be sent.<br/>
        /// Request Example:<br/>
        /// POST https://{server.url}<br/>
        /// Content-Type: application/json<br/>
        /// {<br/>
        ///   "message": {<br/>
        ///     "type": "voice-request",<br/>
        ///     "text": "Hello, world!",<br/>
        ///     "sampleRate": 24000,<br/>
        ///     ...other metadata about the call...<br/>
        ///   }<br/>
        /// }<br/>
        /// Response Expected: 1-channel 16-bit raw PCM audio at the sample rate specified in the request. Here is how the response will be piped to the transport:<br/>
        /// ```<br/>
        /// response.on('data', (chunk: Buffer) =&gt; {<br/>
        ///   outputStream.write(chunk);<br/>
        /// });<br/>
        /// ```
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Server Server { get; set; }

        /// <summary>
        /// This is the plan for chunking the model output before it is sent to the voice provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunkPlan")]
        public global::G.ChunkPlan? ChunkPlan { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FallbackCustomVoice" /> class.
        /// </summary>
        /// <param name="server">
        /// This is where the voice request will be sent.<br/>
        /// Request Example:<br/>
        /// POST https://{server.url}<br/>
        /// Content-Type: application/json<br/>
        /// {<br/>
        ///   "message": {<br/>
        ///     "type": "voice-request",<br/>
        ///     "text": "Hello, world!",<br/>
        ///     "sampleRate": 24000,<br/>
        ///     ...other metadata about the call...<br/>
        ///   }<br/>
        /// }<br/>
        /// Response Expected: 1-channel 16-bit raw PCM audio at the sample rate specified in the request. Here is how the response will be piped to the transport:<br/>
        /// ```<br/>
        /// response.on('data', (chunk: Buffer) =&gt; {<br/>
        ///   outputStream.write(chunk);<br/>
        /// });<br/>
        /// ```
        /// </param>
        /// <param name="cachingEnabled">
        /// This is the flag to toggle voice caching for the assistant.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </param>
        /// <param name="provider">
        /// This is the voice provider that will be used. Use `custom-voice` for providers that are not natively supported.
        /// </param>
        /// <param name="voiceId">
        /// This is the provider-specific ID that will be used. This is passed in the voice request payload to identify the voice to use.
        /// </param>
        /// <param name="chunkPlan">
        /// This is the plan for chunking the model output before it is sent to the voice provider.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FallbackCustomVoice(
            global::G.Server server,
            bool? cachingEnabled,
            global::G.FallbackCustomVoiceProvider provider,
            string? voiceId,
            global::G.ChunkPlan? chunkPlan)
        {
            this.CachingEnabled = cachingEnabled;
            this.Provider = provider;
            this.VoiceId = voiceId;
            this.Server = server ?? throw new global::System.ArgumentNullException(nameof(server));
            this.ChunkPlan = chunkPlan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FallbackCustomVoice" /> class.
        /// </summary>
        public FallbackCustomVoice()
        {
        }
    }
}