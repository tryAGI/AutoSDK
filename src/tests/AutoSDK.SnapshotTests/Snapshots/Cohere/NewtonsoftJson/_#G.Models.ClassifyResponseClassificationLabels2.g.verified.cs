//HintName: G.Models.ClassifyResponseClassificationLabels2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Included only in responses
    /// </summary>
    public sealed partial class ClassifyResponseClassificationLabels2
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("confidence")]
        public float? Confidence { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifyResponseClassificationLabels2" /> class.
        /// </summary>
        /// <param name="confidence">
        /// Included only in responses
        /// </param>
        public ClassifyResponseClassificationLabels2(
            float? confidence)
        {
            this.Confidence = confidence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifyResponseClassificationLabels2" /> class.
        /// </summary>
        public ClassifyResponseClassificationLabels2()
        {
        }
    }
}