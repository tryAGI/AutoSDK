//HintName: G.Models.BooleanFeedbackDefinitionCreateVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BooleanFeedbackDefinitionCreateVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("details")]
        public global::G.BooleanFeedbackDetailCreate? Details { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BooleanFeedbackDefinitionCreateVariant2" /> class.
        /// </summary>
        /// <param name="details"></param>
        public BooleanFeedbackDefinitionCreateVariant2(
            global::G.BooleanFeedbackDetailCreate? details)
        {
            this.Details = details;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BooleanFeedbackDefinitionCreateVariant2" /> class.
        /// </summary>
        public BooleanFeedbackDefinitionCreateVariant2()
        {
        }
    }
}