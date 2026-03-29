//HintName: G.IManageGlossariesClient.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Please note that this is the spec for the (old) v2 glossary endpoint.<br/>
    /// We recommend users switch to the newer v3 glossary endpoints, which support editability and multilinguality.<br/>
    /// The *glossary* functions allow you to create, inspect, and delete glossaries.<br/>
    /// Glossaries created with the glossary function can be used in translate requests by specifying the<br/>
    /// `glossary_id` parameter.<br/>
    /// If you encounter issues, please let us know at support@DeepL.com.<br/>
    /// Currently you can create glossaries with any of the languages DeepL supports.<br/>
    /// The maximum size limit for a glossary is 10 MiB = 10485760 bytes and each source/target text,<br/>
    /// as well as the name of the glossary, is limited to 1024 UTF-8 bytes.<br/>
    /// A total of 1000 glossaries are allowed per account.<br/>
    /// When creating a glossary with target language `EN`, `PT`, or `ZH`, it's not necessary to specify a variant<br/>
    /// (e.g. `EN-US`, `EN-GB`, `PT-PT`, `PT-BR`, or `ZH-HANS`).<br/>
    /// Glossaries with target language `EN` can be used in translations with either English variant.<br/>
    /// Similarly `PT`, and `ZH` glossaries can be used in translations with their corresponding variants.<br/>
    /// Note that on the v2 API, glossaries are immutable: once created, the glossary entries for a given glossary ID cannot be modified.<br/>
    /// As a workaround for effectively editable glossaries, we suggest to identify glossaries by name instead of ID in your application<br/>
    /// and then use the following procedure for modifications:<br/>
    /// - [download](https://www.deepl.com/docs-api/glossaries/get-glossary-entries) and store the current glossary's entries,<br/>
    /// - locally modify the glossary entries,<br/>
    /// - [delete](https://www.deepl.com/docs-api/glossaries/delete-glossary) the existing glossary,<br/>
    /// - [create a new glossary](https://www.deepl.com/docs-api/glossaries/create-glossary) with the same name.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IManageGlossariesClient : global::System.IDisposable
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
        /// 
        /// </summary>
        global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; }


    }
}