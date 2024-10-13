//HintName: G.Models.StreamingStartRequestSdp.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StreamingStartRequestSdp
    {
        /// <summary>
        /// Example: v=0<br/>
        /// o=- 865306769317114273 1711711067 IN IP4 0.0.0.0<br/>
        /// s=-<br/>
        /// t=0 0<br/>
        /// a=fingerprint:sha-256 5B:57:56:56:47:37:A2:76:46:2B:FA:72:6D:61:1D:70:98:8A:4B:8D:BD:E9:54:7E:0E:8D:86:7B:13:BD:5B:B3<br/>
        /// a=extmap-allow-mixed<br/>
        /// a=group:BUNDLE 0 1 2<br/>
        /// m=video 9 UDP/TLS/RTP/SAVPF 96<br/>
        /// c=IN IP4 0.0.0.0<br/>
        /// a=setup:actpass<br/>
        /// a=mid:0<br/>
        /// a=ice-ufrag:WGLlXrCpTGFDczaD<br/>
        /// a=ice-pwd:ikkYSSwwcEqeapAGiibnhMltrcdcsDPE<br/>
        /// a=rtcp-mux<br/>
        /// a=rtcp-rsize<br/>
        /// a=rtpmap:96 VP8/90000<br/>
        /// a=ssrc:771866534 cname:pion<br/>
        /// a=ssrc:771866534 msid:pion video<br/>
        /// a=ssrc:771866534 mslabel:pion<br/>
        /// a=ssrc:771866534 label:video<br/>
        /// a=msid:pion video<br/>
        /// a=sendonly<br/>
        /// a=candidate:211536166 1 udp 2130706431 192.168.95.148 58919 typ host<br/>
        /// a=candidate:211536166 2 udp 2130706431 192.168.95.148 58919 typ host<br/>
        /// a=candidate:233762139 1 udp 2130706431 172.17.0.1 39783 typ host<br/>
        /// a=candidate:233762139 2 udp 2130706431 172.17.0.1 39783 typ host<br/>
        /// a=candidate:2409875042 1 udp 1694498815 3.145.204.238 33743 typ srflx raddr 0.0.0.0 rport 33743<br/>
        /// a=candidate:2409875042 2 udp 1694498815 3.145.204.238 33743 typ srflx raddr 0.0.0.0 rport 33743<br/>
        /// a=candidate:2409875042 1 udp 1694498815 3.145.204.238 52509 typ srflx raddr 0.0.0.0 rport 52509<br/>
        /// a=candidate:2409875042 2 udp 1694498815 3.145.204.238 52509 typ srflx raddr 0.0.0.0 rport 52509<br/>
        /// a=candidate:2409875042 1 udp 1694498815 3.145.204.238 48068 typ srflx raddr 0.0.0.0 rport 48068<br/>
        /// a=candidate:2409875042 2 udp 1694498815 3.145.204.238 48068 typ srflx raddr 0.0.0.0 rport 48068<br/>
        /// a=candidate:2409875042 1 udp 1694498815 3.145.204.238 39574 typ srflx raddr 0.0.0.0 rport 39574<br/>
        /// a=candidate:2409875042 2 udp 1694498815 3.145.204.238 39574 typ srflx raddr 0.0.0.0 rport 39574<br/>
        /// a=candidate:2409875042 1 udp 1694498815 3.145.204.238 60127 typ srflx raddr 0.0.0.0 rport 60127<br/>
        /// a=candidate:2409875042 2 udp 1694498815 3.145.204.238 60127 typ srflx raddr 0.0.0.0 rport 60127<br/>
        /// a=candidate:551173388 1 udp 16777215 34.203.251.67 55901 typ relay raddr 0.0.0.0 rport 38018<br/>
        /// a=candidate:551173388 2 udp 16777215 34.203.251.67 55901 typ relay raddr 0.0.0.0 rport 38018<br/>
        /// a=candidate:551173388 1 udp 16777215 34.203.251.67 26906 typ relay raddr 192.168.95.148 rport 37276<br/>
        /// a=candidate:551173388 2 udp 16777215 34.203.251.67 26906 typ relay raddr 192.168.95.148 rport 37276<br/>
        /// a=candidate:551173388 1 udp 16777215 34.203.251.67 48909 typ relay raddr 192.168.95.148 rport 51224<br/>
        /// a=candidate:551173388 2 udp 16777215 34.203.251.67 48909 typ relay raddr 192.168.95.148 rport 51224<br/>
        /// a=end-of-candidates<br/>
        /// m=audio 9 UDP/TLS/RTP/SAVPF 111<br/>
        /// c=IN IP4 0.0.0.0<br/>
        /// a=setup:actpass<br/>
        /// a=mid:1<br/>
        /// a=ice-ufrag:WGLlXrCpTGFDczaD<br/>
        /// a=ice-pwd:ikkYSSwwcEqeapAGiibnhMltrcdcsDPE<br/>
        /// a=rtcp-mux<br/>
        /// a=rtcp-rsize<br/>
        /// a=rtpmap:111 opus/48000/2<br/>
        /// a=fmtp:111 minptime=10;useinbandfec=1<br/>
        /// a=ssrc:4043859165 cname:pion<br/>
        /// a=ssrc:4043859165 msid:pion audio<br/>
        /// a=ssrc:4043859165 mslabel:pion<br/>
        /// a=ssrc:4043859165 label:audio<br/>
        /// a=msid:pion audio<br/>
        /// a=sendrecv<br/>
        /// m=application 9 UDP/DTLS/SCTP webrtc-datachannel<br/>
        /// c=IN IP4 0.0.0.0<br/>
        /// a=setup:actpass<br/>
        /// a=mid:2<br/>
        /// a=sendrecv<br/>
        /// a=sctp-port:5000<br/>
        /// a=ice-ufrag:WGLlXrCpTGFDczaD<br/>
        /// a=ice-pwd:ikkYSSwwcEqeapAGiibnhMltrcdcsDPE
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sdp")]
        public string? Sdp { get; set; }

        /// <summary>
        /// Example: offer
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
    #if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
    #endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::G.StreamingStartRequestSdp? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.StreamingStartRequestSdp),
                jsonSerializerContext) as global::G.StreamingStartRequestSdp;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.StreamingStartRequestSdp? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.StreamingStartRequestSdp>(
                json,
                jsonSerializerOptions);
        }

    }
}