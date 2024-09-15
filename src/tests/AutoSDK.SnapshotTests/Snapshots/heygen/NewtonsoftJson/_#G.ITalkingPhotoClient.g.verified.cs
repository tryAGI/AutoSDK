//HintName: G.ITalkingPhotoClient.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// These API endpoints allow you to manage photo avatars in your account.<br/>
    /// **Reference**: [https://docs.heygen.com/reference/upload-talking-photo](https://docs.heygen.com/reference/upload-talking-photo)<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface ITalkingPhotoClient : global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string BaseUrl = "https://api.heygen.com";

        /// <summary>
        /// 
        /// </summary>
        global::Newtonsoft.Json.JsonSerializerSettings JsonSerializerOptions { get; set; }


    }
}