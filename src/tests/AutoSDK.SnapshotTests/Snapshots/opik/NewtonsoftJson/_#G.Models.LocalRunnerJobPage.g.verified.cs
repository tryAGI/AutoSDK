//HintName: G.Models.LocalRunnerJobPage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LocalRunnerJobPage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page")]
        public int? Page { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("size")]
        public int? Size { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total")]
        public long? Total { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content")]
        public global::System.Collections.Generic.IList<global::G.LocalRunnerJob>? Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalRunnerJobPage" /> class.
        /// </summary>
        /// <param name="page"></param>
        /// <param name="size"></param>
        /// <param name="total"></param>
        /// <param name="content"></param>
        public LocalRunnerJobPage(
            int? page,
            int? size,
            long? total,
            global::System.Collections.Generic.IList<global::G.LocalRunnerJob>? content)
        {
            this.Page = page;
            this.Size = size;
            this.Total = total;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalRunnerJobPage" /> class.
        /// </summary>
        public LocalRunnerJobPage()
        {
        }
    }
}