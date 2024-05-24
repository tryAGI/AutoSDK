//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// If no httpClient is provided, a new one will be created.
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class Api : global::System.IDisposable
    {
        private readonly global::System.Net.Http.HttpClient _httpClient;

        public AccountClient Account => new AccountClient(_httpClient);
        public AdminClient Admin => new AdminClient(_httpClient);
        public ChatClient Chat => new ChatClient(_httpClient);
        public DataSetClient DataSet => new DataSetClient(_httpClient);
        public DescriptorClient Descriptor => new DescriptorClient(_httpClient);
        public ErrorClient Error => new ErrorClient(_httpClient);
        public ExcerptClient Excerpt => new ExcerptClient(_httpClient);
        public ExportClient Export => new ExportClient(_httpClient);
        public FileClient File => new FileClient(_httpClient);
        public FileStorageClient FileStorage => new FileStorageClient(_httpClient);
        public LoginClient Login => new LoginClient(_httpClient);
        public UsersClient Users => new UsersClient(_httpClient);
        public MemoClient Memo => new MemoClient(_httpClient);
        public ProjectClient Project => new ProjectClient(_httpClient);
        public ResourceClient Resource => new ResourceClient(_httpClient);
        public SecurityClient Security => new SecurityClient(_httpClient);
        public SurveyImportClient SurveyImport => new SurveyImportClient(_httpClient);
        public TagClient Tag => new TagClient(_httpClient);
        public TrainingClient Training => new TrainingClient(_httpClient);
        public UserClient User => new UserClient(_httpClient);

        /// <summary>
        /// Creates a new instance of the Api.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient"></param>
        /// <param name="baseUri"></param>
        public Api(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null)
        {
            _httpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            _httpClient.BaseAddress ??= baseUri ?? new global::System.Uri("");
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            _httpClient.Dispose();
        }
    }
}