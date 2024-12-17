//HintName: G.Models.ClassifyResponseClassificationLabels.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A map containing each label and its confidence score according to the classifier. All the confidence scores add up to 1 for single-label classification. For multi-label classification the label confidences are independent of each other, so they don't have to sum up to 1.<br/>
    /// Included only in responses
    /// </summary>
    public sealed partial class ClassifyResponseClassificationLabels
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}