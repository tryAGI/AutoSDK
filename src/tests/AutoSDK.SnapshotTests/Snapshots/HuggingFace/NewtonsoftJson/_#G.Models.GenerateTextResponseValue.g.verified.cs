//HintName: G.Models.GenerateTextResponseValue.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateTextResponseValue
    {
        /// <summary>
        /// The resulting completion up to and excluding the stop sequences.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("generated_text", Required = global::Newtonsoft.Json.Required.Always)]
        public string GeneratedText { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateTextResponseValue" /> class.
        /// </summary>
        /// <param name="generatedText">
        /// The resulting completion up to and excluding the stop sequences.
        /// </param>
        public GenerateTextResponseValue(
            string generatedText)
        {
            this.GeneratedText = generatedText ?? throw new global::System.ArgumentNullException(nameof(generatedText));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateTextResponseValue" /> class.
        /// </summary>
        public GenerateTextResponseValue()
        {
        }
    }
}