//HintName: G.Models.LayoutPage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LayoutPage
    {
        /// <summary>
        /// The page number.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Width of the page in pixels.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("width")]
        public int? Width { get; set; }

        /// <summary>
        /// Height of the page in pixels.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("height")]
        public int? Height { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LayoutPage" /> class.
        /// </summary>
        /// <param name="id">
        /// The page number.
        /// </param>
        /// <param name="width">
        /// Width of the page in pixels.
        /// </param>
        /// <param name="height">
        /// Height of the page in pixels.
        /// </param>
        public LayoutPage(
            int? id,
            int? width,
            int? height)
        {
            this.Id = id;
            this.Width = width;
            this.Height = height;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LayoutPage" /> class.
        /// </summary>
        public LayoutPage()
        {
        }
    }
}