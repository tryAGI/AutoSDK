//HintName: G.IApi.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IApi : global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public AccountClient Account { get; }

        /// <summary>
        /// 
        /// </summary>
        public AdminClient Admin { get; }

        /// <summary>
        /// 
        /// </summary>
        public ChatClient Chat { get; }

        /// <summary>
        /// 
        /// </summary>
        public DataSetClient DataSet { get; }

        /// <summary>
        /// 
        /// </summary>
        public DescriptorClient Descriptor { get; }

        /// <summary>
        /// 
        /// </summary>
        public ErrorClient Error { get; }

        /// <summary>
        /// 
        /// </summary>
        public ExcerptClient Excerpt { get; }

        /// <summary>
        /// 
        /// </summary>
        public ExportClient Export { get; }

        /// <summary>
        /// 
        /// </summary>
        public FileClient File { get; }

        /// <summary>
        /// 
        /// </summary>
        public FileStorageClient FileStorage { get; }

        /// <summary>
        /// 
        /// </summary>
        public LoginClient Login { get; }

        /// <summary>
        /// 
        /// </summary>
        public UsersClient Users { get; }

        /// <summary>
        /// 
        /// </summary>
        public MemoClient Memo { get; }

        /// <summary>
        /// 
        /// </summary>
        public ProjectClient Project { get; }

        /// <summary>
        /// 
        /// </summary>
        public ResourceClient Resource { get; }

        /// <summary>
        /// 
        /// </summary>
        public SecurityClient Security { get; }

        /// <summary>
        /// 
        /// </summary>
        public SurveyImportClient SurveyImport { get; }

        /// <summary>
        /// 
        /// </summary>
        public TagClient Tag { get; }

        /// <summary>
        /// 
        /// </summary>
        public TrainingClient Training { get; }

        /// <summary>
        /// 
        /// </summary>
        public UserClient User { get; }

    }
}