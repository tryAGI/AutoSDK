//HintName: G.Models.DocumentElement.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DocumentElement
    {
        /// <summary>
        /// The ID of the element.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// The type of element (e.g., paragraph, table, figure, heading).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.DocumentElementType? Type { get; set; }

        /// <summary>
        /// The category of the element.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("category")]
        public string? Category { get; set; }

        /// <summary>
        /// The content of the element.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content")]
        public global::G.DocumentElementContent? Content { get; set; }

        /// <summary>
        /// Bounding box coordinates for the element.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("coordinates")]
        public global::System.Collections.Generic.IList<global::G.DocumentElementCoordinate>? Coordinates { get; set; }

        /// <summary>
        /// The page number where the element is located.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page")]
        public int? Page { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentElement" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the element.
        /// </param>
        /// <param name="type">
        /// The type of element (e.g., paragraph, table, figure, heading).
        /// </param>
        /// <param name="category">
        /// The category of the element.
        /// </param>
        /// <param name="content">
        /// The content of the element.
        /// </param>
        /// <param name="coordinates">
        /// Bounding box coordinates for the element.
        /// </param>
        /// <param name="page">
        /// The page number where the element is located.
        /// </param>
        public DocumentElement(
            int? id,
            global::G.DocumentElementType? type,
            string? category,
            global::G.DocumentElementContent? content,
            global::System.Collections.Generic.IList<global::G.DocumentElementCoordinate>? coordinates,
            int? page)
        {
            this.Id = id;
            this.Type = type;
            this.Category = category;
            this.Content = content;
            this.Coordinates = coordinates;
            this.Page = page;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentElement" /> class.
        /// </summary>
        public DocumentElement()
        {
        }
    }
}