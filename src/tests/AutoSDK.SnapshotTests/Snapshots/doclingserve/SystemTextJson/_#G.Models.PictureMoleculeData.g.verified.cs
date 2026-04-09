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
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        public string? Kind { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("smi")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Smi { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Confidence { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("class_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClassName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segmentation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>> Segmentation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provenance")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Provenance { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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