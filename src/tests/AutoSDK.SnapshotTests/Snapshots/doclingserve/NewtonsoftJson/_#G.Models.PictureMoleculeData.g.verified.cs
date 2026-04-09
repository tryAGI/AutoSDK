//HintName: G.Models.PictureMoleculeData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// PictureMoleculeData.
    /// </summary>
    public sealed partial class PictureMoleculeData
    {
        /// <summary>
        /// Default Value: molecule_data
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("kind")]
        public string? Kind { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("smi", Required = global::Newtonsoft.Json.Required.Always)]
        public string Smi { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("confidence", Required = global::Newtonsoft.Json.Required.Always)]
        public double Confidence { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("class_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ClassName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("segmentation", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>> Segmentation { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provenance", Required = global::Newtonsoft.Json.Required.Always)]
        public string Provenance { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PictureMoleculeData" /> class.
        /// </summary>
        /// <param name="smi"></param>
        /// <param name="confidence"></param>
        /// <param name="className"></param>
        /// <param name="segmentation"></param>
        /// <param name="provenance"></param>
        /// <param name="kind">
        /// Default Value: molecule_data
        /// </param>
        public PictureMoleculeData(
            string smi,
            double confidence,
            string className,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>> segmentation,
            string provenance,
            string? kind)
        {
            this.Kind = kind;
            this.Smi = smi ?? throw new global::System.ArgumentNullException(nameof(smi));
            this.Confidence = confidence;
            this.ClassName = className ?? throw new global::System.ArgumentNullException(nameof(className));
            this.Segmentation = segmentation ?? throw new global::System.ArgumentNullException(nameof(segmentation));
            this.Provenance = provenance ?? throw new global::System.ArgumentNullException(nameof(provenance));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PictureMoleculeData" /> class.
        /// </summary>
        public PictureMoleculeData()
        {
        }
    }
}