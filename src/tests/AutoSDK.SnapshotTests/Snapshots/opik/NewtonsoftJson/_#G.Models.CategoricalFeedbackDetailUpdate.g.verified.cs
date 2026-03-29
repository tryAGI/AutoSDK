//HintName: G.Models.CategoricalFeedbackDetailUpdate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CategoricalFeedbackDetailUpdate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("categories", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, double> Categories { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoricalFeedbackDetailUpdate" /> class.
        /// </summary>
        /// <param name="categories"></param>
        public CategoricalFeedbackDetailUpdate(
            global::System.Collections.Generic.Dictionary<string, double> categories)
        {
            this.Categories = categories ?? throw new global::System.ArgumentNullException(nameof(categories));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoricalFeedbackDetailUpdate" /> class.
        /// </summary>
        public CategoricalFeedbackDetailUpdate()
        {
        }
    }
}