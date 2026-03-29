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
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Count { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsCountResponseData" /> class.
        /// </summary>
        /// <param name="count">
        /// Total number of available models
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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