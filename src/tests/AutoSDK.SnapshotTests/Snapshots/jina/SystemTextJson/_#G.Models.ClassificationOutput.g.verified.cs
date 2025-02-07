//HintName: G.Models.ClassificationOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Output of the classification service
    /// </summary>
    public sealed partial class ClassificationOutput
    {
        /// <summary>
        /// A list of Classification Objects returned by the classification service
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> Data { get; set; }

        /// <summary>
        /// Total usage of the request. Sums up the usage from each individual input
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ApiSchemasClassificationUsage Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassificationOutput" /> class.
        /// </summary>
        /// <param name="data">
        /// A list of Classification Objects returned by the classification service
        /// </param>
        /// <param name="usage">
        /// Total usage of the request. Sums up the usage from each individual input
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClassificationOutput(
            global::System.Collections.Generic.IList<object> data,
            global::G.ApiSchemasClassificationUsage usage)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassificationOutput" /> class.
        /// </summary>
        public ClassificationOutput()
        {
        }
    }
}