//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Welcome to [NanoNets](https://nanonets.com)' API Reference!<br/>
    /// &lt;br /&gt;<br/>
    /// &lt;br /&gt;<br/>
    /// &lt;br /&gt;<br/>
    /// Use Postman to quickly test the API.<br/>
    /// &lt;br /&gt;<br/>
    /// &lt;br /&gt;<br/>
    /// &lt;a href="https://www.postman.com/run-collection/2fcb1195d85e7a98ad74" rel="noreferrer" target="_blank"&gt;<br/>
    ///   &lt;img src="https://run.pstmn.io/button.svg" alt="Run in Postman" /&gt;<br/>
    /// &lt;/a&gt;<br/>
    /// &lt;br /&gt;<br/>
    /// &lt;br /&gt;<br/>
    /// &lt;br /&gt;<br/>
    /// [Get an API Key](https://app.nanonets.com/#/keys)<br/>
    /// # SDKs<br/>
    /// We have Node.js SDKs that can be used to make predictions after [creating and training models on our web app](https://app.nanonets.com).<br/>
    /// - Optical Character Recognition<br/>
    ///   - [NPM Package](https://www.npmjs.com/package/@nanonets/optical-character-recognition)<br/>
    ///   - NPM: `npm install @nanonets/optical-character-recognition`<br/>
    ///   - Yarn: `yarn add @nanonets/optical-character-recognition`<br/>
    /// - Image Classification<br/>
    ///   - [NPM Package](https://www.npmjs.com/package/@nanonets/image-classification)<br/>
    ///   - NPM: `npm install @nanonets/image-classification`<br/>
    ///   - Yarn: `yarn add @nanonets/image-classification`<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class Api : global::G.IApi, global::System.IDisposable
    {
        /// <summary>
        /// NanoNets API v2
        /// </summary>
        public const string DefaultBaseUrl = "https://app.nanonets.com/api/v2";

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
        #pragma warning disable CS0618 // Type or member is obsolete
        public global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; } = new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new global::G.JsonConverters.UnixTimestampJsonConverter(),
                }
            };
        #pragma warning restore CS0618 // Type or member is obsolete


        /// <summary>
        /// IC Model Details. Get the details of an existing Image Classification (IC) model.<br/>
        /// &lt;br /&gt;<br/>
        /// ([Create a model](https://app.nanonets.com) on the NanoNets web app.).
        /// </summary>
        public IcModelDetailsClient IcModelDetails => new IcModelDetailsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// IC Predict. Upload a file to an existing Image Classification (IC) model and get the predicted classification result.<br/>
        /// &lt;br /&gt;<br/>
        /// ([Create a model](https://app.nanonets.com) on the NanoNets web app.).
        /// </summary>
        public IcPredictClient IcPredict => new IcPredictClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// IC Train. Train an existing Image Classification (IC) model.<br/>
        /// &lt;br /&gt;<br/>
        /// ([Create a model](https://app.nanonets.com) on the NanoNets web app.).
        /// </summary>
        public IcTrainClient IcTrain => new IcTrainClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// IC Upload. Upload training images to an existing Image Classification (IC) model.<br/>
        /// &lt;br /&gt;<br/>
        /// ([Create a model](https://app.nanonets.com) on the NanoNets web app.)<br/>
        /// &lt;br /&gt;<br/>
        /// &lt;br /&gt;<br/>
        /// **NOTE**: These end points are only for uploading **training files** for the model and the same files cannot be directly used for prediction. (They need to be uploaded again through the [prediction end points](#tag/icPredict) for prediction.).
        /// </summary>
        public IcUploadClient IcUpload => new IcUploadClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// OCR Model Details. Get the details of an existing Optical Character Recognition (OCR) model.<br/>
        /// &lt;br /&gt;<br/>
        /// ([Create a model](https://app.nanonets.com) on the NanoNets web app.).
        /// </summary>
        public OcrModelDetailsClient OcrModelDetails => new OcrModelDetailsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// OCR Predict. Upload a file to an existing Optical Character Recognition (OCR) model and get the extracted data.<br/>
        /// &lt;br /&gt;<br/>
        /// ([Create a model](https://app.nanonets.com) on the NanoNets web app.).
        /// </summary>
        public OcrPredictClient OcrPredict => new OcrPredictClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// OCR Train. Train an existing Optical Character Recognition (OCR) model.<br/>
        /// &lt;br /&gt;<br/>
        /// ([Create a model](https://app.nanonets.com) on the NanoNets web app.).
        /// </summary>
        public OcrTrainClient OcrTrain => new OcrTrainClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// OCR Upload. Upload training images to an existing Optical Character Recognition (OCR) model.<br/>
        /// &lt;br /&gt;<br/>
        /// ([Create a model](https://app.nanonets.com) on the NanoNets web app.)<br/>
        /// &lt;br /&gt;<br/>
        /// &lt;br /&gt;<br/>
        /// **NOTE**: These end points are only for uploading **training files** for the model and the same files cannot be directly used for prediction. (They need to be uploaded again through the [prediction end points](#tag/ocrPredict) for prediction.).
        /// </summary>
        public OcrUploadClient OcrUpload => new OcrUploadClient(HttpClient, authorizations: Authorizations)
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