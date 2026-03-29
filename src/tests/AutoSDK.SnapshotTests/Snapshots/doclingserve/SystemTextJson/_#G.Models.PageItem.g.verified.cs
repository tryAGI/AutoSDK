//HintName: G.Models.PageItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// PageItem.
    /// </summary>
    public sealed partial class PageItem
    {
        /// <summary>
        /// Size.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Size Size { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public global::G.ImageRef? Image { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_no")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PageNo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PageItem" /> class.
        /// </summary>
        /// <param name="size">
        /// Size.
        /// </param>
        /// <param name="pageNo"></param>
        /// <param name="image"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PageItem(
            global::G.Size size,
            int pageNo,
            global::G.ImageRef? image)
        {
            this.Size = size ?? throw new global::System.ArgumentNullException(nameof(size));
            this.Image = image;
            this.PageNo = pageNo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PageItem" /> class.
        /// </summary>
        public PageItem()
        {
        }
    }
}