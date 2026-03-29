//HintName: G.Models.PictureMeta.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Metadata model for pictures.
    /// </summary>
    public sealed partial class PictureMeta
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summary")]
        public global::G.SummaryMetaField? Summary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public global::G.DescriptionMetaField? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("classification")]
        public global::G.PictureClassificationMetaField? Classification { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("molecule")]
        public global::G.MoleculeMetaField? Molecule { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tabular_chart")]
        public global::G.TabularChartMetaField? TabularChart { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PictureMeta" /> class.
        /// </summary>
        /// <param name="summary"></param>
        /// <param name="description"></param>
        /// <param name="classification"></param>
        /// <param name="molecule"></param>
        /// <param name="tabularChart"></param>
        public PictureMeta(
            global::G.SummaryMetaField? summary,
            global::G.DescriptionMetaField? description,
            global::G.PictureClassificationMetaField? classification,
            global::G.MoleculeMetaField? molecule,
            global::G.TabularChartMetaField? tabularChart)
        {
            this.Summary = summary;
            this.Description = description;
            this.Classification = classification;
            this.Molecule = molecule;
            this.TabularChart = tabularChart;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PictureMeta" /> class.
        /// </summary>
        public PictureMeta()
        {
        }
    }
}