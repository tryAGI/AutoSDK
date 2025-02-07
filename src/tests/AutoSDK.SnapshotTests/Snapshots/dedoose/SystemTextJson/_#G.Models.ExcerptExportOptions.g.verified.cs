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
        [global::System.Text.Json.Serialization.JsonPropertyName("fileExtension")]
        public string? FileExtension { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exCopyMode")]
        public int? ExCopyMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sortMode")]
        public int? SortMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exRange")]
        public bool? ExRange { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exCreator")]
        public bool? ExCreator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exDate")]
        public bool? ExDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("desInfo")]
        public bool? DesInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("docTitle")]
        public bool? DocTitle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("docCreator")]
        public bool? DocCreator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("docDate")]
        public bool? DocDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tagApplied")]
        public bool? TagApplied { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tagWeight")]
        public bool? TagWeight { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tagRange")]
        public bool? TagRange { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memos")]
        public bool? Memos { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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