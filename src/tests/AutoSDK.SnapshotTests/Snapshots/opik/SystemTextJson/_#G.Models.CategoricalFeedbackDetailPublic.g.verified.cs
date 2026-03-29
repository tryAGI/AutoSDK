//HintName: G.Models.CategoricalFeedbackDetailPublic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CategoricalFeedbackDetailPublic
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("categories")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, double> Categories { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoricalFeedbackDetailPublic" /> class.
        /// </summary>
        /// <param name="categories"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CategoricalFeedbackDetailPublic(
            global::System.Collections.Generic.Dictionary<string, double> categories)
        {
            this.Categories = categories ?? throw new global::System.ArgumentNullException(nameof(categories));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoricalFeedbackDetailPublic" /> class.
        /// </summary>
        public CategoricalFeedbackDetailPublic()
        {
        }
    }
}