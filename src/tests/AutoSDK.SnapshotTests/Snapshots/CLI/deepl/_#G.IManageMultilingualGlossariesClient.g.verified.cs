//HintName: G.IManageMultilingualGlossariesClient.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The *glossary* functions allow you to create, inspect, edit and delete glossaries.<br/>
    /// Glossaries created with the glossary function can be used in translate requests by specifying the<br/>
    /// `glossary_id` parameter. A glossary contains (several) dictionaries.<br/>
    /// A dictionary is a mapping of source phrases to target phrases for a single language pair.<br/>
    /// If you encounter issues, please let us know at support@DeepL.com.<br/>
    /// Currently you can create glossaries with any of the languages DeepL supports.<br/>
    /// The maximum size limit for a glossary is 10 MiB = 10485760 bytes and each source/target text,<br/>
    /// as well as the name of the glossary, is limited to 1024 UTF-8 bytes.<br/>
    /// A total of 1000 glossaries are allowed per account.<br/>
    /// When creating a dictionary with target language `EN`, `PT`, or `ZH`, it's not necessary to specify a variant<br/>
    /// (e.g. `EN-US`, `EN-GB`, `PT-PT`, `PT-BR`, or `ZH-HANS`).<br/>
    /// Dictionaries with target language `EN` can be used in translations with either English variant.<br/>
    /// Similarly `PT`, and `ZH` dictionaries can be used in translations with their corresponding variants.<br/>
    /// (When you provide the ID of a glossary to a translation, the appropriate dictionary is automatically applied. Currently glossaries can not yet be used with source language detection.)<br/>
    /// Glossaries created via the DeepL API are now unified with glossaries created via the DeepL website and DeepL apps.<br/>
    /// Please only use the v3 glossary API in conjunction with multilingual or edited glossaries from the website.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IManageMultilingualGlossariesClient : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::G.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }

        /// <summary>
        /// Client-wide request defaults such as headers, query parameters, retries, and timeout.
        /// </summary>
        public global::G.AutoSDKClientOptions Options { get; }

        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; }


    }
}