//HintName: G.Models.ExcerptExportOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExcerptExportOptions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fileExtension")]
        public string? FileExtension { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exCopyMode")]
        public int? ExCopyMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sortMode")]
        public int? SortMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exRange")]
        public bool? ExRange { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exCreator")]
        public bool? ExCreator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exDate")]
        public bool? ExDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("desInfo")]
        public bool? DesInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("docTitle")]
        public bool? DocTitle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("docCreator")]
        public bool? DocCreator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("docDate")]
        public bool? DocDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tagApplied")]
        public bool? TagApplied { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tagWeight")]
        public bool? TagWeight { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tagRange")]
        public bool? TagRange { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("memos")]
        public bool? Memos { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExcerptExportOptions" /> class.
        /// </summary>
        /// <param name="fileExtension"></param>
        /// <param name="exCopyMode"></param>
        /// <param name="sortMode"></param>
        /// <param name="exRange"></param>
        /// <param name="exCreator"></param>
        /// <param name="exDate"></param>
        /// <param name="desInfo"></param>
        /// <param name="docTitle"></param>
        /// <param name="docCreator"></param>
        /// <param name="docDate"></param>
        /// <param name="tagApplied"></param>
        /// <param name="tagWeight"></param>
        /// <param name="tagRange"></param>
        /// <param name="memos"></param>
        public ExcerptExportOptions(
            string? fileExtension,
            int? exCopyMode,
            int? sortMode,
            bool? exRange,
            bool? exCreator,
            bool? exDate,
            bool? desInfo,
            bool? docTitle,
            bool? docCreator,
            bool? docDate,
            bool? tagApplied,
            bool? tagWeight,
            bool? tagRange,
            bool? memos)
        {
            this.FileExtension = fileExtension;
            this.ExCopyMode = exCopyMode;
            this.SortMode = sortMode;
            this.ExRange = exRange;
            this.ExCreator = exCreator;
            this.ExDate = exDate;
            this.DesInfo = desInfo;
            this.DocTitle = docTitle;
            this.DocCreator = docCreator;
            this.DocDate = docDate;
            this.TagApplied = tagApplied;
            this.TagWeight = tagWeight;
            this.TagRange = tagRange;
            this.Memos = memos;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExcerptExportOptions" /> class.
        /// </summary>
        public ExcerptExportOptions()
        {
        }
    }
}