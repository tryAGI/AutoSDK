//HintName: G.Models.ChapterResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChapterResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chapter_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ChapterId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_conversion_date_unix", Required = global::Newtonsoft.Json.Required.Always)]
        public int LastConversionDateUnix { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_block_conversion_unix_ms", Required = global::Newtonsoft.Json.Required.Always)]
        public int LastBlockConversionUnixMs { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conversion_progress", Required = global::Newtonsoft.Json.Required.Always)]
        public double ConversionProgress { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("can_be_downloaded", Required = global::Newtonsoft.Json.Required.Always)]
        public bool CanBeDownloaded { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ChapterResponseModelState State { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("statistics", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ChapterStatisticsResponseModel Statistics { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChapterResponseModel" /> class.
        /// </summary>
        /// <param name="chapterId"></param>
        /// <param name="name"></param>
        /// <param name="lastConversionDateUnix"></param>
        /// <param name="lastBlockConversionUnixMs"></param>
        /// <param name="conversionProgress"></param>
        /// <param name="canBeDownloaded"></param>
        /// <param name="state"></param>
        /// <param name="statistics"></param>
        public ChapterResponseModel(
            string chapterId,
            string name,
            int lastConversionDateUnix,
            int lastBlockConversionUnixMs,
            double conversionProgress,
            bool canBeDownloaded,
            global::G.ChapterResponseModelState state,
            global::G.ChapterStatisticsResponseModel statistics)
        {
            this.ChapterId = chapterId ?? throw new global::System.ArgumentNullException(nameof(chapterId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.LastConversionDateUnix = lastConversionDateUnix;
            this.LastBlockConversionUnixMs = lastBlockConversionUnixMs;
            this.ConversionProgress = conversionProgress;
            this.CanBeDownloaded = canBeDownloaded;
            this.State = state;
            this.Statistics = statistics ?? throw new global::System.ArgumentNullException(nameof(statistics));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChapterResponseModel" /> class.
        /// </summary>
        public ChapterResponseModel()
        {
        }
    }
}