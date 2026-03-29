//HintName: G.Models.ListPromptTemplates.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListPromptTemplates
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_next", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasNext { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_prev", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasPrev { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("items", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.GetPromptTemplateResponse> Items { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("next_num", Required = global::Newtonsoft.Json.Required.Always)]
        public int NextNum { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prev_num", Required = global::Newtonsoft.Json.Required.Always)]
        public int PrevNum { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page", Required = global::Newtonsoft.Json.Required.Always)]
        public int Page { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pages", Required = global::Newtonsoft.Json.Required.Always)]
        public int Pages { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total", Required = global::Newtonsoft.Json.Required.Always)]
        public int Total { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListPromptTemplates" /> class.
        /// </summary>
        /// <param name="hasNext"></param>
        /// <param name="hasPrev"></param>
        /// <param name="items"></param>
        /// <param name="nextNum"></param>
        /// <param name="prevNum"></param>
        /// <param name="page"></param>
        /// <param name="pages"></param>
        /// <param name="total"></param>
        public ListPromptTemplates(
            bool hasNext,
            bool hasPrev,
            global::System.Collections.Generic.IList<global::G.GetPromptTemplateResponse> items,
            int nextNum,
            int prevNum,
            int page,
            int pages,
            int total)
        {
            this.HasNext = hasNext;
            this.HasPrev = hasPrev;
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.NextNum = nextNum;
            this.PrevNum = prevNum;
            this.Page = page;
            this.Pages = pages;
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListPromptTemplates" /> class.
        /// </summary>
        public ListPromptTemplates()
        {
        }
    }
}