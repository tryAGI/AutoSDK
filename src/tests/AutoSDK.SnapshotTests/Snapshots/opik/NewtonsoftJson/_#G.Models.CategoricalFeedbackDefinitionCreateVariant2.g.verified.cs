//HintName: G.Models.CategoricalFeedbackDefinitionCreateVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CategoricalFeedbackDefinitionCreateVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("details")]
        public global::G.CategoricalFeedbackDetailCreate? Details { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoricalFeedbackDefinitionCreateVariant2" /> class.
        /// </summary>
        /// <param name="details"></param>
        public CategoricalFeedbackDefinitionCreateVariant2(
            global::G.CategoricalFeedbackDetailCreate? details)
        {
            this.Details = details;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoricalFeedbackDefinitionCreateVariant2" /> class.
        /// </summary>
        public CategoricalFeedbackDefinitionCreateVariant2()
        {
        }
    }
}