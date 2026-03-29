//HintName: G.Models.ServerMessageVoiceRequestType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the message. "voice-request" is sent when using `assistant.voice={ "type": "custom-voice" }`.<br/>
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
    public enum ServerMessageVoiceRequestType
    {
        /// <summary>
        /// "custom-voice" }`.
        /// </summary>
        VoiceRequest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServerMessageVoiceRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerMessageVoiceRequestType value)
        {
            return value switch
            {
                ServerMessageVoiceRequestType.VoiceRequest => "voice-request",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerMessageVoiceRequestType? ToEnum(string value)
        {
            return value switch
            {
                "voice-request" => ServerMessageVoiceRequestType.VoiceRequest,
                _ => null,
            };
        }
    }
}