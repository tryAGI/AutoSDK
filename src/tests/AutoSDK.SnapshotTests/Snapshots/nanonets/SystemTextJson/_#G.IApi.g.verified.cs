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
        /// Client-wide request defaults such as headers, query parameters, retries, and timeout.
        /// </summary>
        public global::G.AutoSDKClientOptions Options { get; }

        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; }


        /// <summary>
        /// IC Model Details. Get the details of an existing Image Classification (IC) model.<br/>
        /// &lt;br /&gt;<br/>
        /// ([Create a model](https://app.nanonets.com) on the NanoNets web app.).
        /// </summary>
        public IcModelDetailsClient IcModelDetails { get; }

        /// <summary>
        /// IC Predict. Upload a file to an existing Image Classification (IC) model and get the predicted classification result.<br/>
        /// &lt;br /&gt;<br/>
        /// ([Create a model](https://app.nanonets.com) on the NanoNets web app.).
        /// </summary>
        public IcPredictClient IcPredict { get; }

        /// <summary>
        /// IC Train. Train an existing Image Classification (IC) model.<br/>
        /// &lt;br /&gt;<br/>
        /// ([Create a model](https://app.nanonets.com) on the NanoNets web app.).
        /// </summary>
        public IcTrainClient IcTrain { get; }

        /// <summary>
        /// IC Upload. Upload training images to an existing Image Classification (IC) model.<br/>
        /// &lt;br /&gt;<br/>
        /// ([Create a model](https://app.nanonets.com) on the NanoNets web app.)<br/>
        /// &lt;br /&gt;<br/>
        /// &lt;br /&gt;<br/>
        /// **NOTE**: These end points are only for uploading **training files** for the model and the same files cannot be directly used for prediction. (They need to be uploaded again through the [prediction end points](#tag/icPredict) for prediction.).
        /// </summary>
        public IcUploadClient IcUpload { get; }

        /// <summary>
        /// OCR Model Details. Get the details of an existing Optical Character Recognition (OCR) model.<br/>
        /// &lt;br /&gt;<br/>
        /// ([Create a model](https://app.nanonets.com) on the NanoNets web app.).
        /// </summary>
        public OcrModelDetailsClient OcrModelDetails { get; }

        /// <summary>
        /// OCR Predict. Upload a file to an existing Optical Character Recognition (OCR) model and get the extracted data.<br/>
        /// &lt;br /&gt;<br/>
        /// ([Create a model](https://app.nanonets.com) on the NanoNets web app.).
        /// </summary>
        public OcrPredictClient OcrPredict { get; }

        /// <summary>
        /// OCR Train. Train an existing Optical Character Recognition (OCR) model.<br/>
        /// &lt;br /&gt;<br/>
        /// ([Create a model](https://app.nanonets.com) on the NanoNets web app.).
        /// </summary>
        public OcrTrainClient OcrTrain { get; }

        /// <summary>
        /// OCR Upload. Upload training images to an existing Optical Character Recognition (OCR) model.<br/>
        /// &lt;br /&gt;<br/>
        /// ([Create a model](https://app.nanonets.com) on the NanoNets web app.)<br/>
        /// &lt;br /&gt;<br/>
        /// &lt;br /&gt;<br/>
        /// **NOTE**: These end points are only for uploading **training files** for the model and the same files cannot be directly used for prediction. (They need to be uploaded again through the [prediction end points](#tag/ocrPredict) for prediction.).
        /// </summary>
        public OcrUploadClient OcrUpload { get; }

    }
}