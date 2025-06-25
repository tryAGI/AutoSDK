﻿//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Welcome to the **HeyGen API** Postman Collection. This collection provides a convenient way to interact with the HeyGen API directly from Postman.<br/>
    /// **Documentation**: [https://docs.heygen.com](https://docs.heygen.com/)  <br/>
    /// **Guides**: [https://docs.heygen.com/docs](https://docs.heygen.com/docs/quick-start)**API Reference**: [https://docs.heygen.com/reference](https://docs.heygen.com/reference/authentication-1)<br/>
    /// ## Authorization<br/>
    /// To send requests to the API endpoints, you must use a valid API token. You can get your API token from the [Settings &amp;gt; API ](https://app.heygen.com/settings?nav=API) page in your HeyGen account.<br/>
    /// 1. In Postman, go to the **Environments** tab on the left panel.<br/>
    ///     <br/>
    /// 2. Select the **My HeyGen API Environment** environment provided by HeyGen.<br/>
    ///     <br/>
    /// 3. Update the `heygen-api-token` value with your current HeyGen API token.<br/>
    ///     <br/>
    /// 4. Ensure **My HeyGen API Environment** is selected as the active environment using the environment selector at the top right corner of Postman.<br/>
    ///     <br/>
    /// ### 400 response<br/>
    /// A 400 error response typically indicates that your request body is corrupted. To avoid this, ensure that your request body is correctly formatted and includes all necessary elements, such as closing parentheses.<br/>
    /// ### **Need some help?**<br/>
    /// If you need assistance, you can reach out to us through the following channels:<br/>
    /// - **Customer Support Chat:** Available in our web interface.<br/>
    ///     <br/>
    /// - **Emails:** api@heygen.com, [support@heygen.com](https://mailto:support@heygen.com)<br/>
    ///     <br/>
    /// - **Community Discussions:** Check out our [discussions channel](https://null) – there's a good chance our community has the answer you're looking for.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class Api : global::G.IApi, global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string DefaultBaseUrl = "https://api.heygen.com";

        private bool _disposeHttpClient = true;

        /// <inheritdoc/>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <inheritdoc/>
        public System.Uri? BaseUri => HttpClient.BaseAddress;

        /// <inheritdoc/>
        public global::System.Collections.Generic.List<global::G.EndPointAuthorization> Authorizations { get; }

        /// <inheritdoc/>
        public bool ReadResponseAsString { get; set; }
#if DEBUG
            = true;
#endif
        /// <summary>
        /// 
        /// </summary>
        public global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; } = new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new global::G.JsonConverters.UnixTimestampJsonConverter(),
                }
            };


        /// <summary>
        /// 
        /// </summary>
        public ListsClient Lists => new ListsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Create personalized avatar videos with ease using the **HeyGen API**. By selecting an avatar and a voice, you can create engaging videos for various purposes. 🌟<br/>
        /// **Guide**: [https://docs.heygen.com/docs/create-video](https://docs.heygen.com/docs/create-video)**Reference**: [https://docs.heygen.com/reference/create-an-avatar-video-v2](https://docs.heygen.com/reference/create-an-avatar-video-v2)
        /// </summary>
        public CreateVideoAPIClient CreateVideoAPI => new CreateVideoAPIClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Templates enable you to add and customize existing text, images, videos, audios (coming soon), voices and avatars, while avatar videos consist only of avatars without these elements. If you plan to use it within a workflow and need richer content, templates are likely a better fit for your use case compared to simple talking avatar videos. 🌟<br/>
        /// **Quick Comparison:**<br/>
        /// - **Avatar Videos:** Avatar videos are centered around avatars delivering content without any additional elements. They are ideal for straightforward, avatar-focused communication.<br/>
        ///     <br/>
        /// - **Template Videos:** In contrast, template videos offer a wide canvas for creativity. They enable you to customize existing text, images, videos, audios, voices and avatars seamlessly. If you need a richer, more versatile content format for your workflow, templates are the perfect choice.<br/>
        ///     <br/>
        /// **Guide**: [https://docs.heygen.com/docs/generate-video-from-template-v2](https://docs.heygen.com/docs/generate-video-from-template-v2)  <br/>
        /// **Reference**: [https://docs.heygen.com/reference/generate-from-template-v2](https://docs.heygen.com/reference/generate-from-template-v2)[](https://docs.heygen.com/reference/create-an-avatar-video-v2)
        /// </summary>
        public TemplateAPIClient TemplateAPI => new TemplateAPIClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// The [Video Translate](https://labs.heygen.com/video-translate) by HeyGen provides a powerful solution for effortlessly translating videos, integrating natural voice cloning and authentic speaking styles seamlessly. Now, you can harness its capabilities programmatically through the **Video Translate API**!<br/>
        /// **Guide**: [https://docs.heygen.com/docs/video-translate-api](https://docs.heygen.com/docs/video-translate-api)**Reference**: [https://docs.heygen.com/reference/video-translate](https://docs.heygen.com/reference/video-translate)
        /// </summary>
        public VideoTranslateAPIClient VideoTranslateAPI => new VideoTranslateAPIClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// HeyGen's **Streaming API** allows developers to seamlessly integrate dynamic digital avatars into their applications for immersive and interactive user experiences. With this API, you can create _virtual assistants, real-time training simulations,_ and more, with a focus on real-time, low-latency communication between _users_ and _avatars_ with power of WebRTC.<br/>
        /// **Guide**: [https://docs.heygen.com/docs/streaming-api](https://docs.heygen.com/docs/streaming-api)**Reference**: [https://docs.heygen.com/reference/new-session](https://docs.heygen.com/reference/new-session)
        /// </summary>
        public StreamingAPIClient StreamingAPI => new StreamingAPIClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Webhook events are how the **HeyGen** notifies your _endpoints_ when a variety of interactions or events happen, including when avatar video processing _succeeds_ or _fails_. Webhook events are sent by HeyGen as POST requests to your webhook endpoint.<br/>
        /// **Guide**: [https://docs.heygen.com/docs/using-heygens-webhook-events](https://docs.heygen.com/docs/using-heygens-webhook-events)**Reference**: [https://docs.heygen.com/reference/add-a-webhook-endpoint](https://docs.heygen.com/reference/add-a-webhook-endpoint)
        /// </summary>
        public WebhooksClient Webhooks => new WebhooksClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// These API endpoints allow you to manage photo avatars in your account.<br/>
        /// **Reference**: [https://docs.heygen.com/reference/upload-talking-photo](https://docs.heygen.com/reference/upload-talking-photo)
        /// </summary>
        public TalkingPhotoClient TalkingPhoto => new TalkingPhotoClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Import contacts into your HeyGen **Personalized Video** campaign. <br/>
        /// **Guide**: [https://docs.heygen.com/docs/import-contacts-via-api](https://docs.heygen.com/docs/import-contacts-via-api)  <br/>
        /// Reference: [https://docs.heygen.com/reference/add-contact](https://docs.heygen.com/reference/add-contact)
        /// </summary>
        public PersonalizedVideoClient PersonalizedVideo => new PersonalizedVideoClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Obtain information about your account.<br/>
        /// **Reference**: [https://docs.heygen.com/reference/get-remaining-quota-v2](https://docs.heygen.com/reference/get-remaining-quota-v2)
        /// </summary>
        public UserClient User => new UserClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Upload an image or video asset to your account.<br/>
        /// **Reference**: [https://docs.heygen.com/reference/upload-asset-1](https://docs.heygen.com/reference/upload-asset-1)
        /// </summary>
        public AssetsClient Assets => new AssetsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Creates a new instance of the Api.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public Api(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::G.EndPointAuthorization>? authorizations = null,
            bool disposeHttpClient = true)
        {
            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::G.EndPointAuthorization>();
            _disposeHttpClient = disposeHttpClient;

            Initialized(HttpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            if (_disposeHttpClient)
            {
                HttpClient.Dispose();
            }
        }

        partial void Initialized(
            global::System.Net.Http.HttpClient client);
        partial void PrepareArguments(
            global::System.Net.Http.HttpClient client);
        partial void PrepareRequest(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);
    }
}