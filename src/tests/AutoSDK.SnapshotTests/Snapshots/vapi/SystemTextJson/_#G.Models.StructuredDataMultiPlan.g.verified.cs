//HintName: G.Models.StructuredDataMultiPlan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StructuredDataMultiPlan
    {
        /// <summary>
        /// This is the key of the structured data plan in the catalog.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// This is an individual structured data plan in the catalog.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.StructuredDataPlan Plan { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StructuredDataMultiPlan" /> class.
        /// </summary>
        /// <param name="key">
        /// This is the key of the structured data plan in the catalog.
        /// </param>
        /// <param name="plan">
        /// This is an individual structured data plan in the catalog.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StructuredDataMultiPlan(
            string key,
            global::G.StructuredDataPlan plan)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Plan = plan ?? throw new global::System.ArgumentNullException(nameof(plan));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StructuredDataMultiPlan" /> class.
        /// </summary>
        public StructuredDataMultiPlan()
        {
        }
    }
}