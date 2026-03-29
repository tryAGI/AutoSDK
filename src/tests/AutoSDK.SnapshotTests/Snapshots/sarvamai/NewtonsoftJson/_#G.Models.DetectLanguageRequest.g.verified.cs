//HintName: G.Models.DetectLanguageRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DetectLanguageRequest
    {
        /// <summary>
        /// Text for language and script identification (max 1000 characters)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input", Required = global::Newtonsoft.Json.Required.Always)]
        public string Input { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectLanguageRequest" /> class.
        /// </summary>
        /// <param name="input">
        /// Text for language and script identification (max 1000 characters)
        /// </param>
        public DetectLanguageRequest(
            string input)
        {
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectLanguageRequest" /> class.
        /// </summary>
        public DetectLanguageRequest()
        {
        }
    }
}