//HintName: G.Models.LayoutElement.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LayoutElement
    {
        /// <summary>
        /// The ID of the layout element.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// The type of layout element.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.LayoutElementTypeJsonConverter))]
        public global::G.LayoutElementType? Type { get; set; }

        /// <summary>
        /// The category of the element.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("category")]
        public string? Category { get; set; }

        /// <summary>
        /// Bounding box coordinates.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bounding_box")]
        public global::G.LayoutElementBoundingBox? BoundingBox { get; set; }

        /// <summary>
        /// The page number where the element is located.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page")]
        public int? Page { get; set; }

        /// <summary>
        /// Extracted text content of the element.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// HTML representation of the element.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html")]
        public string? Html { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LayoutElement" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the layout element.
        /// </param>
        /// <param name="type">
        /// The type of layout element.
        /// </param>
        /// <param name="category">
        /// The category of the element.
        /// </param>
        /// <param name="boundingBox">
        /// Bounding box coordinates.
        /// </param>
        /// <param name="page">
        /// The page number where the element is located.
        /// </param>
        /// <param name="text">
        /// Extracted text content of the element.
        /// </param>
        /// <param name="html">
        /// HTML representation of the element.
        /// </param>
        public LayoutElement(
            int? id,
            global::G.LayoutElementType? type,
            string? category,
            global::G.LayoutElementBoundingBox? boundingBox,
            int? page,
            string? text,
            string? html)
        {
            this.Id = id;
            this.Type = type;
            this.Category = category;
            this.BoundingBox = boundingBox;
            this.Page = page;
            this.Text = text;
            this.Html = html;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LayoutElement" /> class.
        /// </summary>
        public LayoutElement()
        {
        }
    }
}