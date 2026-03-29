//HintName: G.Models.PopulatePromptResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PopulatePromptResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("result")]
        public global::System.Collections.Generic.IList<global::G.ChatMessage>? Result { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PopulatePromptResponse" /> class.
        /// </summary>
        /// <param name="result"></param>
        public PopulatePromptResponse(
            global::System.Collections.Generic.IList<global::G.ChatMessage>? result)
        {
            this.Result = result;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PopulatePromptResponse" /> class.
        /// </summary>
        public PopulatePromptResponse()
        {
        }
    }
}