//HintName: G.Models.DocumentStoreLoaderForPreview.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DocumentStoreLoaderForPreview
    {
        /// <summary>
        /// Unique identifier for the document store loader
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// ID of the loader
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("loaderId")]
        public string? LoaderId { get; set; }

        /// <summary>
        /// Name of the loader
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("loaderName")]
        public string? LoaderName { get; set; }

        /// <summary>
        /// Configuration for the loader
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("loaderConfig")]
        public object? LoaderConfig { get; set; }

        /// <summary>
        /// ID of the text splitter
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("splitterId")]
        public string? SplitterId { get; set; }

        /// <summary>
        /// Name of the text splitter
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("splitterName")]
        public string? SplitterName { get; set; }

        /// <summary>
        /// Configuration for the text splitter
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("splitterConfig")]
        public object? SplitterConfig { get; set; }

        /// <summary>
        /// Total number of chunks
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("totalChunks")]
        public double? TotalChunks { get; set; }

        /// <summary>
        /// Total number of characters
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("totalChars")]
        public double? TotalChars { get; set; }

        /// <summary>
        /// Status of the document store loader
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.DocumentStoreLoaderForPreviewStatusJsonConverter))]
        public global::G.DocumentStoreLoaderForPreviewStatus? Status { get; set; }

        /// <summary>
        /// ID of the document store
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("storeId")]
        public string? StoreId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("files")]
        public global::System.Collections.Generic.IList<global::G.DocumentStoreLoaderFile>? Files { get; set; }

        /// <summary>
        /// Source of the document store loader
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source")]
        public string? Source { get; set; }

        /// <summary>
        /// Credential associated with the document store loader
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("credential")]
        public string? Credential { get; set; }

        /// <summary>
        /// Whether the loader has been rehydrated
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rehydrated")]
        public bool? Rehydrated { get; set; }

        /// <summary>
        /// Whether the loader is in preview mode
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("preview")]
        public bool? Preview { get; set; }

        /// <summary>
        /// Number of chunks in preview mode
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("previewChunkCount")]
        public double? PreviewChunkCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentStoreLoaderForPreview" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the document store loader
        /// </param>
        /// <param name="loaderId">
        /// ID of the loader
        /// </param>
        /// <param name="loaderName">
        /// Name of the loader
        /// </param>
        /// <param name="loaderConfig">
        /// Configuration for the loader
        /// </param>
        /// <param name="splitterId">
        /// ID of the text splitter
        /// </param>
        /// <param name="splitterName">
        /// Name of the text splitter
        /// </param>
        /// <param name="splitterConfig">
        /// Configuration for the text splitter
        /// </param>
        /// <param name="totalChunks">
        /// Total number of chunks
        /// </param>
        /// <param name="totalChars">
        /// Total number of characters
        /// </param>
        /// <param name="status">
        /// Status of the document store loader
        /// </param>
        /// <param name="storeId">
        /// ID of the document store
        /// </param>
        /// <param name="files"></param>
        /// <param name="source">
        /// Source of the document store loader
        /// </param>
        /// <param name="credential">
        /// Credential associated with the document store loader
        /// </param>
        /// <param name="rehydrated">
        /// Whether the loader has been rehydrated
        /// </param>
        /// <param name="preview">
        /// Whether the loader is in preview mode
        /// </param>
        /// <param name="previewChunkCount">
        /// Number of chunks in preview mode
        /// </param>
        public DocumentStoreLoaderForPreview(
            global::System.Guid? id,
            string? loaderId,
            string? loaderName,
            object? loaderConfig,
            string? splitterId,
            string? splitterName,
            object? splitterConfig,
            double? totalChunks,
            double? totalChars,
            global::G.DocumentStoreLoaderForPreviewStatus? status,
            string? storeId,
            global::System.Collections.Generic.IList<global::G.DocumentStoreLoaderFile>? files,
            string? source,
            string? credential,
            bool? rehydrated,
            bool? preview,
            double? previewChunkCount)
        {
            this.Id = id;
            this.LoaderId = loaderId;
            this.LoaderName = loaderName;
            this.LoaderConfig = loaderConfig;
            this.SplitterId = splitterId;
            this.SplitterName = splitterName;
            this.SplitterConfig = splitterConfig;
            this.TotalChunks = totalChunks;
            this.TotalChars = totalChars;
            this.Status = status;
            this.StoreId = storeId;
            this.Files = files;
            this.Source = source;
            this.Credential = credential;
            this.Rehydrated = rehydrated;
            this.Preview = preview;
            this.PreviewChunkCount = previewChunkCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentStoreLoaderForPreview" /> class.
        /// </summary>
        public DocumentStoreLoaderForPreview()
        {
        }
    }
}