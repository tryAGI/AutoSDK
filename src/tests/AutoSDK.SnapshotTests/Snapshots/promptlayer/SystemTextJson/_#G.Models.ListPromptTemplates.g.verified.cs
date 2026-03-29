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
        [global::System.Text.Json.Serialization.JsonPropertyName("has_next")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasNext { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_prev")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasPrev { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.GetPromptTemplateResponse> Items { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_num")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NextNum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prev_num")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PrevNum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Page { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Pages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Total { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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