//HintName: G.Models.OpenAiResponsesToolChoice4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenAiResponsesToolChoice4
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OpenAiResponsesToolChoiceOneOf4Type Type { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAiResponsesToolChoice4" /> class.
        /// </summary>
        /// <param name="type"></param>
        public OpenAiResponsesToolChoice4(
            global::G.OpenAiResponsesToolChoiceOneOf4Type type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAiResponsesToolChoice4" /> class.
        /// </summary>
        public OpenAiResponsesToolChoice4()
        {
        }
    }
}