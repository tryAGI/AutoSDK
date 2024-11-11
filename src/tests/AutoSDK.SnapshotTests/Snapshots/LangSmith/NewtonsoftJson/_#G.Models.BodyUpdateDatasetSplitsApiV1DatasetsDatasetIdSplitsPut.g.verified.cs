//HintName: G.Models.BodyUpdateDatasetSplitsApiV1DatasetsDatasetIdSplitsPut.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyUpdateDatasetSplitsApiV1DatasetsDatasetIdSplitsPut
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("split_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string SplitName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("examples", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::System.Guid> Examples { get; set; } = default!;

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("remove")]
        public bool? Remove { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUpdateDatasetSplitsApiV1DatasetsDatasetIdSplitsPut" /> class.
        /// </summary>
        /// <param name="splitName"></param>
        /// <param name="examples"></param>
        /// <param name="remove">
        /// Default Value: false
        /// </param>
        public BodyUpdateDatasetSplitsApiV1DatasetsDatasetIdSplitsPut(
            string splitName,
            global::System.Collections.Generic.IList<global::System.Guid> examples,
            bool? remove)
        {
            this.SplitName = splitName ?? throw new global::System.ArgumentNullException(nameof(splitName));
            this.Examples = examples ?? throw new global::System.ArgumentNullException(nameof(examples));
            this.Remove = remove;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUpdateDatasetSplitsApiV1DatasetsDatasetIdSplitsPut" /> class.
        /// </summary>
        public BodyUpdateDatasetSplitsApiV1DatasetsDatasetIdSplitsPut()
        {
        }
    }
}