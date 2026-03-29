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
        [global::Newtonsoft.Json.JsonProperty("size", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Size Size { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image")]
        public global::G.ImageRef? Image { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page_no", Required = global::Newtonsoft.Json.Required.Always)]
        public int PageNo { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PageItem" /> class.
        /// </summary>
        /// <param name="size">
        /// Size.
        /// </param>
        /// <param name="pageNo"></param>
        /// <param name="image"></param>
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