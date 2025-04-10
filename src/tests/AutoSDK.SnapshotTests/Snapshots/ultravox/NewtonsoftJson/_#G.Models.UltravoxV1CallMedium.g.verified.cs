//HintName: G.Models.UltravoxV1CallMedium.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Details about a call's protocol. By default, calls occur over WebRTC using<br/>
    ///  the Ultravox client SDK. Setting a different call medium will prepare the<br/>
    ///  server for a call using a different protocol.<br/>
    ///  At most one call medium may be set.
    /// </summary>
    public sealed partial class UltravoxV1CallMedium
    {
        /// <summary>
        /// The call will use WebRTC with the Ultravox client SDK.<br/>
        ///  This is the default.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("webRtc")]
        public object? WebRtc { get; set; }

        /// <summary>
        /// The call will use Twilio's "Media Streams" protocol.<br/>
        ///  Once you have a join URL from starting a call, include it in your<br/>
        ///  TwiML like so:<br/>
        ///  &lt;Connect&gt;&lt;Stream url=${your-join-url} /&gt;&lt;/Connect&gt;<br/>
        ///  This works for both inbound and outbound calls.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("twilio")]
        public object? Twilio { get; set; }

        /// <summary>
        /// The call will use a plain websocket connection. This is unlikely to yield an acceptable user<br/>
        ///  experience if used from a browser or mobile client, but may be suitable for a<br/>
        ///  server-to-server connection. This option provides a simple way to connect your own server to<br/>
        ///  an Ultravox inference instance.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("serverWebSocket")]
        public global::G.UltravoxV1CallMediumWebSocketMedium? ServerWebSocket { get; set; }

        /// <summary>
        /// The call will use Telnyx's media streaming protocol.<br/>
        ///  Once you have a join URL from starting a call, include it in your<br/>
        ///  TexML like so:<br/>
        ///  &lt;Connect&gt;&lt;Stream url=${your-join-url} bidirectionalMode="rtp" /&gt;&lt;/Connect&gt;<br/>
        ///  This works for both inbound and outbound calls.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("telnyx")]
        public object? Telnyx { get; set; }

        /// <summary>
        /// The call will use Plivo's AudioStreams protocol.<br/>
        ///  Once you have a join URL from starting a call, include it in your<br/>
        ///  Plivo XML like so:<br/>
        ///  &lt;Stream keepCallAlive="true" bidirectional="true" contentType="audio/x-l16;rate=16000"&gt;${your-join-url}&lt;/Stream&gt;<br/>
        ///  This works for both inbound and outbound calls.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("plivo")]
        public object? Plivo { get; set; }

        /// <summary>
        /// The call will use Exotel's "Voicebot" protocol.<br/>
        ///  Once you have a join URL from starting a call, provide it to Exotel as the wss target URL<br/>
        ///  for your Voicebot (either directly or more likely dynamically from your own server).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exotel")]
        public object? Exotel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1CallMedium" /> class.
        /// </summary>
        /// <param name="webRtc">
        /// The call will use WebRTC with the Ultravox client SDK.<br/>
        ///  This is the default.
        /// </param>
        /// <param name="twilio">
        /// The call will use Twilio's "Media Streams" protocol.<br/>
        ///  Once you have a join URL from starting a call, include it in your<br/>
        ///  TwiML like so:<br/>
        ///  &lt;Connect&gt;&lt;Stream url=${your-join-url} /&gt;&lt;/Connect&gt;<br/>
        ///  This works for both inbound and outbound calls.
        /// </param>
        /// <param name="serverWebSocket">
        /// The call will use a plain websocket connection. This is unlikely to yield an acceptable user<br/>
        ///  experience if used from a browser or mobile client, but may be suitable for a<br/>
        ///  server-to-server connection. This option provides a simple way to connect your own server to<br/>
        ///  an Ultravox inference instance.
        /// </param>
        /// <param name="telnyx">
        /// The call will use Telnyx's media streaming protocol.<br/>
        ///  Once you have a join URL from starting a call, include it in your<br/>
        ///  TexML like so:<br/>
        ///  &lt;Connect&gt;&lt;Stream url=${your-join-url} bidirectionalMode="rtp" /&gt;&lt;/Connect&gt;<br/>
        ///  This works for both inbound and outbound calls.
        /// </param>
        /// <param name="plivo">
        /// The call will use Plivo's AudioStreams protocol.<br/>
        ///  Once you have a join URL from starting a call, include it in your<br/>
        ///  Plivo XML like so:<br/>
        ///  &lt;Stream keepCallAlive="true" bidirectional="true" contentType="audio/x-l16;rate=16000"&gt;${your-join-url}&lt;/Stream&gt;<br/>
        ///  This works for both inbound and outbound calls.
        /// </param>
        /// <param name="exotel">
        /// The call will use Exotel's "Voicebot" protocol.<br/>
        ///  Once you have a join URL from starting a call, provide it to Exotel as the wss target URL<br/>
        ///  for your Voicebot (either directly or more likely dynamically from your own server).
        /// </param>
        public UltravoxV1CallMedium(
            object? webRtc,
            object? twilio,
            global::G.UltravoxV1CallMediumWebSocketMedium? serverWebSocket,
            object? telnyx,
            object? plivo,
            object? exotel)
        {
            this.WebRtc = webRtc;
            this.Twilio = twilio;
            this.ServerWebSocket = serverWebSocket;
            this.Telnyx = telnyx;
            this.Plivo = plivo;
            this.Exotel = exotel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1CallMedium" /> class.
        /// </summary>
        public UltravoxV1CallMedium()
        {
        }
    }
}