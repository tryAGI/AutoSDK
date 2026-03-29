//HintName: G.Models.NumericalFeedbackDefinitionUpdateVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NumericalFeedbackDefinitionUpdateVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        public global::G.NumericalFeedbackDetailUpdate? Details { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NumericalFeedbackDefinitionUpdateVariant2" /> class.
        /// </summary>
        /// <param name="details"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NumericalFeedbackDefinitionUpdateVariant2(
            global::G.NumericalFeedbackDetailUpdate? details)
        {
            this.Details = details;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumericalFeedbackDefinitionUpdateVariant2" /> class.
        /// </summary>
        public NumericalFeedbackDefinitionUpdateVariant2()
        {
        }
    }
}