//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Roboflow inference server<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class Api : global::G.IApi, global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string DefaultBaseUrl = "";

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
                    new global::G.JsonConverters.SelectorTypeJsonConverter(),
                    new global::G.JsonConverters.SelectorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ValueTypeJsonConverter(),
                    new global::G.JsonConverters.ValueTypeNullableJsonConverter(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::G.InferenceRequestImage>, global::G.InferenceRequestImage>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::G.InferenceResponseImage>, global::G.InferenceResponseImage>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.InferenceRequestImage, string>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::G.InferenceRequestImage>, global::G.InferenceRequestImage, string, global::System.Collections.Generic.IList<string>, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.InferenceRequestImage, string>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.Dictionary<string, double>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::G.InferenceRequestImage>, global::G.InferenceRequestImage>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::G.InferenceRequestImage>, global::G.InferenceRequestImage>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::G.InferenceRequestImage>, global::G.InferenceRequestImage>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::G.InferenceRequestImage>, global::G.InferenceRequestImage>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::G.PointOutput>, global::System.Collections.Generic.IList<global::G.Point3D>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::G.InferenceRequestImage>, global::G.InferenceRequestImage>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::G.InferenceRequestImage>, global::G.InferenceRequestImage>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::G.InferenceRequestImage>, global::G.InferenceRequestImage>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::G.InferenceResponseImage>, global::G.InferenceResponseImage>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::G.InferenceRequestImage>, global::G.InferenceRequestImage>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::G.InferenceResponseImage>, global::G.InferenceResponseImage>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::G.InferenceRequestImage>, global::G.InferenceRequestImage>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::G.InferenceResponseImage>, global::G.InferenceResponseImage>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::G.InferenceResponseImage>, global::G.InferenceResponseImage>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::G.InferenceRequestImage>, global::G.InferenceRequestImage>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::G.InferenceResponseImage>, global::G.InferenceResponseImage>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.InferenceRequestImage, string>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::G.InferenceRequestImage>, global::G.InferenceRequestImage, string, global::System.Collections.Generic.IList<string>, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.InferenceRequestImage, string>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.Dictionary<string, double>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::G.InferenceRequestImage>, global::G.InferenceRequestImage>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.Box, global::G.BoxXYXY>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<int?, bool?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>>, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>>, object, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>, object, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::G.InferenceRequestImage>, global::G.InferenceRequestImage>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::G.InferenceResponseImage>, global::G.InferenceResponseImage>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::G.InferenceRequestImage>, global::G.InferenceRequestImage>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, int?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::G.InferenceRequestImage>, global::G.InferenceRequestImage>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.ObjectDetectionInferenceResponse, global::System.Collections.Generic.IList<global::G.ObjectDetectionInferenceResponse>, global::G.StubResponse>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.InstanceSegmentationInferenceResponse, global::G.StubResponse>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.SemanticSegmentationInferenceResponse, global::G.StubResponse>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.ClassificationInferenceResponse, global::G.MultiLabelClassificationInferenceResponse, global::G.StubResponse>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.KeypointsDetectionInferenceResponse, global::G.StubResponse>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.LMMInferenceResponse, global::System.Collections.Generic.IList<global::G.LMMInferenceResponse>, global::G.StubResponse>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.LMMInferenceResponse, global::System.Collections.Generic.IList<global::G.LMMInferenceResponse>, global::G.StubResponse>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.OCRInferenceResponse, global::System.Collections.Generic.IList<global::G.OCRInferenceResponse>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.OCRInferenceResponse, global::System.Collections.Generic.IList<global::G.OCRInferenceResponse>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.InstanceSegmentationInferenceResponse, global::G.KeypointsDetectionInferenceResponse, global::G.ObjectDetectionInferenceResponse, global::G.ClassificationInferenceResponse, global::G.MultiLabelClassificationInferenceResponse, global::G.SemanticSegmentationInferenceResponse, global::G.StubResponse, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.InstanceSegmentationInferenceResponse, global::G.KeypointsDetectionInferenceResponse, global::G.ObjectDetectionInferenceResponse, global::G.ClassificationInferenceResponse, global::G.MultiLabelClassificationInferenceResponse, global::G.SemanticSegmentationInferenceResponse, global::G.StubResponse, object>(),
                    new global::G.JsonConverters.UnixTimestampJsonConverter(),
                }
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