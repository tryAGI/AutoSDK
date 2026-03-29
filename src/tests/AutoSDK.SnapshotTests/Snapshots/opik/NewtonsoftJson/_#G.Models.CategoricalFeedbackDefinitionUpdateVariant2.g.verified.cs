//HintName: G.Models.CategoricalFeedbackDefinitionUpdateVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CategoricalFeedbackDefinitionUpdateVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("details")]
        public global::G.CategoricalFeedbackDetailUpdate? Details { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoricalFeedbackDefinitionUpdateVariant2" /> class.
        /// </summary>
        /// <param name="details"></param>
        public CategoricalFeedbackDefinitionUpdateVariant2(
            global::G.CategoricalFeedbackDetailUpdate? details)
        {
            this.Details = details;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoricalFeedbackDefinitionUpdateVariant2" /> class.
        /// </summary>
        public CategoricalFeedbackDefinitionUpdateVariant2()
        {
        }
    }
}