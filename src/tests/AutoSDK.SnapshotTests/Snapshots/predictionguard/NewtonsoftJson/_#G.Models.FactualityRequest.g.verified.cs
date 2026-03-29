//HintName: G.Models.FactualityRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FactualityRequest
    {
        /// <summary>
        /// The reference text for comparison.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reference", Required = global::Newtonsoft.Json.Required.Always)]
        public string Reference { get; set; } = default!;

        /// <summary>
        /// The text to be checked for factuality.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FactualityRequest" /> class.
        /// </summary>
        /// <param name="reference">
        /// The reference text for comparison.
        /// </param>
        /// <param name="text">
        /// The text to be checked for factuality.
        /// </param>
        public FactualityRequest(
            string reference,
            string text)
        {
            this.Reference = reference ?? throw new global::System.ArgumentNullException(nameof(reference));
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FactualityRequest" /> class.
        /// </summary>
        public FactualityRequest()
        {
        }
    }
}