//HintName: G.Models.TableSheet.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TableSheet
    {
        /// <summary>
        /// 用户选择的表头行数，从 0 开始编号
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("header_line_idx")]
        public string? HeaderLineIdx { get; set; }

        /// <summary>
        /// 用户选择的 sheet id
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sheet_id")]
        public string? SheetId { get; set; }

        /// <summary>
        /// 用户选择的起始行号，从 0 开始编号
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_line_idx")]
        public string? StartLineIdx { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TableSheet" /> class.
        /// </summary>
        /// <param name="headerLineIdx">
        /// 用户选择的表头行数，从 0 开始编号
        /// </param>
        /// <param name="sheetId">
        /// 用户选择的 sheet id
        /// </param>
        /// <param name="startLineIdx">
        /// 用户选择的起始行号，从 0 开始编号
        /// </param>
        public TableSheet(
            string? headerLineIdx,
            string? sheetId,
            string? startLineIdx)
        {
            this.HeaderLineIdx = headerLineIdx;
            this.SheetId = sheetId;
            this.StartLineIdx = startLineIdx;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TableSheet" /> class.
        /// </summary>
        public TableSheet()
        {
        }
    }
}