//HintName: G.EditInDescriptClient.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// &gt; **Note:** The Edit in Descript integration requires contacting Descript for access. [Reach out to us](https://descript.com/api) to get started.<br/>
    /// Edit in Descript API enables partners to give their users the ability to transfer audio or video content to Descript for editing.<br/>
    /// Edit in Descript buttons work by generating one-time use, public Import URLs to the Descript import UI that users<br/>
    /// can be automatically sent to. On that page, they can make a few simple selections before kicking off a Partner cloud<br/>
    /// storage to Descript cloud storage transfer. This will redirect them to a Descript Project ready for editing.<br/>
    /// Partners can initiate the request by securely sending an information schema backend-to-backend to the Descript API<br/>
    /// using a token, in exchange for the Import URL to redirect the user. Partners do not need to store this schema, as<br/>
    /// Descript will do so and use it to start fetching the files when the user confirms the action<br/>
    /// 1. When a user clicks `Edit in Descript`, partner's backend service makes POST request to:<br/>
    ///     `https://descriptapi.com/v1/edit_in_descript/schema` with an authorization bearer token header and JSON schema body<br/>
    /// 2. Descript responds with either an Import URL or an error<br/>
    /// 3. Partner redirects the user's browser to the URL returned in step 2 or display an error message and link to help documentation<br/>
    /// ### Partner User Experience<br/>
    /// Some guidelines for partners as you consider this integration:<br/>
    /// * We recommend placing the `Edit in Descript` option next to your download options<br/>
    ///   * If you offer multiple download options, such as combined vs. split audio/video files, we recommend placing<br/>
    /// this integration clearly in context with each option, or only the supported option, to help users understand<br/>
    /// what will be exported.<br/>
    ///   * Each time you request an import link, a new one is generated. Import links expire after 3 hours. After using an<br/>
    /// import link, the only way to find an imported Project again is in Descript.<br/>
    ///   * If an import link has expired or the contents of the schema has changed, please request a new import link with<br/>
    /// the updated schema. This will create a new Descript Project when used.<br/>
    /// * We will provide Descript-branded assets to fit your proposed placement of the `Edit in Descript` CTA and ask<br/>
    /// that you don't edit the assets beyond what we provide. We are happy to work with you on getting you the right<br/>
    /// assets for your placement.<br/>
    /// * Partners should provide error-handling for the POST request, at minimum displaying a generic error message and<br/>
    /// linking to a help article (we can provide a link for this if you prefer).<br/>
    /// * Progress will be conveyed to the user in the Descript side of the user experience.<br/>
    /// ### Descript User Experience<br/>
    /// When users are directed to a Descript Import URL, they'll be asked to either create an account or login in order<br/>
    /// to proceed.<br/>
    /// Next, they will be presented with a few options about how they'd like to import the data, such as where the new<br/>
    /// Descript Project should be created.<br/>
    /// They'll then be redirected to the Project, where they can monitor the progress of the import and start editing.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class EditInDescriptClient : global::G.IEditInDescriptClient, global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string DefaultBaseUrl = "https://descriptapi.com/v1";

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
        public global::Newtonsoft.Json.JsonSerializerSettings JsonSerializerOptions { get; set; } = new global::Newtonsoft.Json.JsonSerializerSettings();


        /// <summary>
        /// Creates a new instance of the EditInDescriptClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public EditInDescriptClient(
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