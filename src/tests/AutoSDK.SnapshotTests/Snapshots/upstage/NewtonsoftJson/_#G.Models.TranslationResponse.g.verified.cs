//HintName: G.Models.TranslationResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranslationResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output")]
        public global::G.TranslationResponseOutput? Output { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationResponse" /> class.
        /// </summary>
        /// <param name="output"></param>
        public TranslationResponse(
            global::G.TranslationResponseOutput? output)
        {
            this.Output = output;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationResponse" /> class.
        /// </summary>
        public TranslationResponse()
        {
        }
    }
}