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
        [global::Newtonsoft.Json.JsonProperty("key", Required = global::Newtonsoft.Json.Required.Always)]
        public string Key { get; set; } = default!;

        /// <summary>
        /// This is an individual structured data plan in the catalog.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("plan", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.StructuredDataPlan Plan { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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