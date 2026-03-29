//HintName: G.Models.MoleculeMetaField.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Molecule metadata field.
    /// </summary>
    public sealed partial class MoleculeMetaField
    {
        /// <summary>
        /// The confidence of the prediction.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("confidence")]
        public double? Confidence { get; set; }

        /// <summary>
        /// The origin of the prediction.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_by")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// The SMILES representation of the molecule.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("smi", Required = global::Newtonsoft.Json.Required.Always)]
        public string Smi { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MoleculeMetaField" /> class.
        /// </summary>
        /// <param name="smi">
        /// The SMILES representation of the molecule.
        /// </param>
        /// <param name="confidence">
        /// The confidence of the prediction.
        /// </param>
        /// <param name="createdBy">
        /// The origin of the prediction.
        /// </param>
        public MoleculeMetaField(
            string smi,
            double? confidence,
            string? createdBy)
        {
            this.Confidence = confidence;
            this.CreatedBy = createdBy;
            this.Smi = smi ?? throw new global::System.ArgumentNullException(nameof(smi));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MoleculeMetaField" /> class.
        /// </summary>
        public MoleculeMetaField()
        {
        }
    }
}