//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class Api : global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string BaseUrl = "https://www.mystic.ai";

        private readonly global::System.Net.Http.HttpClient _httpClient;

        /// <summary>
        /// 
        /// </summary>
        public global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; } = new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new global::G.JsonConverters.AcceleratorJsonConverter(),
                    new global::G.JsonConverters.AcceleratorNullableJsonConverter(),
                    new global::G.JsonConverters.AccountTierJsonConverter(),
                    new global::G.JsonConverters.AccountTierNullableJsonConverter(),
                    new global::G.JsonConverters.RunIOTypeJsonConverter(),
                    new global::G.JsonConverters.RunIOTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ContainerRunErrorTypeJsonConverter(),
                    new global::G.JsonConverters.ContainerRunErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.RunStateJsonConverter(),
                    new global::G.JsonConverters.RunStateNullableJsonConverter(),
                    new global::G.JsonConverters.DurationUnitJsonConverter(),
                    new global::G.JsonConverters.DurationUnitNullableJsonConverter(),
                    new global::G.JsonConverters.PipelineStateJsonConverter(),
                    new global::G.JsonConverters.PipelineStateNullableJsonConverter(),
                    new global::G.JsonConverters.OrderByJsonConverter(),
                    new global::G.JsonConverters.OrderByNullableJsonConverter(),
                    new global::G.JsonConverters.ScalingConfigTypeJsonConverter(),
                    new global::G.JsonConverters.ScalingConfigTypeNullableJsonConverter(),
                    new global::G.JsonConverters.AnyOfJsonConverterFactory2(),
                    new global::G.JsonConverters.AllOfJsonConverterFactory1(),
                }
            };


        /// <summary>
        /// 
        /// </summary>
        public PipelinesClient Pipelines => new PipelinesClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public UsersClient Users => new UsersClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public TokensClient Tokens => new TokensClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public RunsClient Runs => new RunsClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public BillingClient Billing => new BillingClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PointersClient Pointers => new PointersClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PipelineFamiliesClient PipelineFamilies => new PipelineFamiliesClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public FilesClient Files => new FilesClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public MetricsClient Metrics => new MetricsClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public LogsClient Logs => new LogsClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public CloudClient Cloud => new CloudClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public CredentialsClient Credentials => new CredentialsClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public GCPClient GCP => new GCPClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public AWSClient AWS => new AWSClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public AzureClient Azure => new AzureClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ClusterClient Cluster => new ClusterClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ResourcesClient Resources => new ResourcesClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ScalingConfigurationsClient ScalingConfigurations => new ScalingConfigurationsClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Creates a new instance of the Api.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient"></param>
        /// <param name="baseUri"></param>
        /// <param name="jsonSerializerOptions"></param>
        public Api(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null)
        {
            _httpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            _httpClient.BaseAddress ??= baseUri ?? new global::System.Uri(BaseUrl);

            Initialized(_httpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            _httpClient.Dispose();
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