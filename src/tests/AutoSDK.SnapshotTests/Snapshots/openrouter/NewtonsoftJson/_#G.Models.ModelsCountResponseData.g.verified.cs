//HintName: G.Models.ModelsCountResponseData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Model count data
    /// </summary>
    public sealed partial class ModelsCountResponseData
    {
        /// <summary>
        /// Total number of available models
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("count", Required = global::Newtonsoft.Json.Required.Always)]
        public double Count { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsCountResponseData" /> class.
        /// </summary>
        /// <param name="count">
        /// Total number of available models
        /// </param>
        public ModelsCountResponseData(
            double count)
        {
            this.Count = count;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsCountResponseData" /> class.
        /// </summary>
        public ModelsCountResponseData()
        {
        }
    }
}