//HintName: G.Models.TableItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TableItem
    {
        /// <summary>
        /// Table item type<br/>
        /// Default Value: table
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Markdown representation preserving formatting
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("md", Required = global::Newtonsoft.Json.Required.Always)]
        public string Md { get; set; } = default!;

        /// <summary>
        /// List of bounding boxes
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bbox")]
        public global::System.Collections.Generic.IList<global::G.BBox>? Bbox { get; set; }

        /// <summary>
        /// Table data as array of arrays (string, number, or null)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rows", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::G.AnyOf<string, int?, double?, object>>> Rows { get; set; } = default!;

        /// <summary>
        /// HTML representation of the table
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html", Required = global::Newtonsoft.Json.Required.Always)]
        public string Html { get; set; } = default!;

        /// <summary>
        /// CSV representation of the table
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("csv", Required = global::Newtonsoft.Json.Required.Always)]
        public string Csv { get; set; } = default!;

        /// <summary>
        /// List of page numbers with tables that were merged into this table (e.g., [1, 2, 3, 4])
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("merged_from_pages")]
        public global::System.Collections.Generic.IList<int>? MergedFromPages { get; set; }

        /// <summary>
        /// Populated when merged into another table. Page number where the full merged table begins (used on empty tables).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("merged_into_page")]
        public int? MergedIntoPage { get; set; }

        /// <summary>
        /// Quality concerns detected during table extraction, indicating the table may have issues
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parse_concerns")]
        public global::System.Collections.Generic.IList<global::G.ParseConcernItem>? ParseConcerns { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TableItem" /> class.
        /// </summary>
        /// <param name="md">
        /// Markdown representation preserving formatting
        /// </param>
        /// <param name="rows">
        /// Table data as array of arrays (string, number, or null)
        /// </param>
        /// <param name="html">
        /// HTML representation of the table
        /// </param>
        /// <param name="csv">
        /// CSV representation of the table
        /// </param>
        /// <param name="type">
        /// Table item type<br/>
        /// Default Value: table
        /// </param>
        /// <param name="bbox">
        /// List of bounding boxes
        /// </param>
        /// <param name="mergedFromPages">
        /// List of page numbers with tables that were merged into this table (e.g., [1, 2, 3, 4])
        /// </param>
        /// <param name="mergedIntoPage">
        /// Populated when merged into another table. Page number where the full merged table begins (used on empty tables).
        /// </param>
        /// <param name="parseConcerns">
        /// Quality concerns detected during table extraction, indicating the table may have issues
        /// </param>
        public TableItem(
            string md,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::G.AnyOf<string, int?, double?, object>>> rows,
            string html,
            string csv,
            string? type,
            global::System.Collections.Generic.IList<global::G.BBox>? bbox,
            global::System.Collections.Generic.IList<int>? mergedFromPages,
            int? mergedIntoPage,
            global::System.Collections.Generic.IList<global::G.ParseConcernItem>? parseConcerns)
        {
            this.Type = type;
            this.Md = md ?? throw new global::System.ArgumentNullException(nameof(md));
            this.Bbox = bbox;
            this.Rows = rows ?? throw new global::System.ArgumentNullException(nameof(rows));
            this.Html = html ?? throw new global::System.ArgumentNullException(nameof(html));
            this.Csv = csv ?? throw new global::System.ArgumentNullException(nameof(csv));
            this.MergedFromPages = mergedFromPages;
            this.MergedIntoPage = mergedIntoPage;
            this.ParseConcerns = parseConcerns;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TableItem" /> class.
        /// </summary>
        public TableItem()
        {
        }
    }
}