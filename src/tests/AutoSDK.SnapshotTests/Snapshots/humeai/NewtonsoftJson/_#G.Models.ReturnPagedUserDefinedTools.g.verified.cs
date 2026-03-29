//HintName: G.Models.ReturnPagedUserDefinedTools.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReturnPagedUserDefinedTools
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page_number")]
        public int? PageNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page_size")]
        public int? PageSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_pages")]
        public int? TotalPages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tools_page")]
        public global::System.Collections.Generic.IList<global::G.ReturnUserDefinedTool>? ToolsPage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnPagedUserDefinedTools" /> class.
        /// </summary>
        /// <param name="pageNumber"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalPages"></param>
        /// <param name="toolsPage"></param>
        public ReturnPagedUserDefinedTools(
            int? pageNumber,
            int? pageSize,
            int? totalPages,
            global::System.Collections.Generic.IList<global::G.ReturnUserDefinedTool>? toolsPage)
        {
            this.PageNumber = pageNumber;
            this.PageSize = pageSize;
            this.TotalPages = totalPages;
            this.ToolsPage = toolsPage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnPagedUserDefinedTools" /> class.
        /// </summary>
        public ReturnPagedUserDefinedTools()
        {
        }
    }
}