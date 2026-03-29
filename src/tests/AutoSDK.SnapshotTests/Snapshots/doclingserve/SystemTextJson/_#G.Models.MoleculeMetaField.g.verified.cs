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
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        public double? Confidence { get; set; }

        /// <summary>
        /// The origin of the prediction.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// The SMILES representation of the molecule.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("smi")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Smi { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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