//HintName: G.ICreateVideoAPIClient.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Create personalized avatar videos with ease using the **HeyGen API**. By selecting an avatar and a voice, you can create engaging videos for various purposes. 🌟<br/>
    /// **Guide**: [https://docs.heygen.com/docs/create-video](https://docs.heygen.com/docs/create-video)**Reference**: [https://docs.heygen.com/reference/create-an-avatar-video-v2](https://docs.heygen.com/reference/create-an-avatar-video-v2)<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface ICreateVideoAPIClient : global::System.IDisposable
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