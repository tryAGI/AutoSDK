//HintName: G.IStreamingAPIClient.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// HeyGen's **Streaming API** allows developers to seamlessly integrate dynamic digital avatars into their applications for immersive and interactive user experiences. With this API, you can create _virtual assistants, real-time training simulations,_ and more, with a focus on real-time, low-latency communication between _users_ and _avatars_ with power of WebRTC.<br/>
    /// **Guide**: [https://docs.heygen.com/docs/streaming-api](https://docs.heygen.com/docs/streaming-api)**Reference**: [https://docs.heygen.com/reference/new-session](https://docs.heygen.com/reference/new-session)<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IStreamingAPIClient : global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string BaseUrl = "https://api.heygen.com";

        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; }


    }
}