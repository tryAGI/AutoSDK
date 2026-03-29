//HintName: G.IApi.g.cs

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
    public partial interface IApi : global::System.IDisposable
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
        global::Newtonsoft.Json.JsonSerializerSettings JsonSerializerOptions { get; set; }


        /// <summary>
        /// IC Model Details
        /// </summary>
        public IcModelDetailsClient IcModelDetails { get; }

        /// <summary>
        /// IC Predict
        /// </summary>
        public IcPredictClient IcPredict { get; }

        /// <summary>
        /// IC Train
        /// </summary>
        public IcTrainClient IcTrain { get; }

        /// <summary>
        /// IC Upload
        /// </summary>
        public IcUploadClient IcUpload { get; }

        /// <summary>
        /// OCR Model Details
        /// </summary>
        public OcrModelDetailsClient OcrModelDetails { get; }

        /// <summary>
        /// OCR Predict
        /// </summary>
        public OcrPredictClient OcrPredict { get; }

        /// <summary>
        /// OCR Train
        /// </summary>
        public OcrTrainClient OcrTrain { get; }

        /// <summary>
        /// OCR Upload
        /// </summary>
        public OcrUploadClient OcrUpload { get; }

    }
}