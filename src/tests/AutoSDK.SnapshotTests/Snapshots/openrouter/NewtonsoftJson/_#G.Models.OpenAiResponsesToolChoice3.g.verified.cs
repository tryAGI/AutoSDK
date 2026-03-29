//HintName: G.Models.OpenAiResponsesToolChoice3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenAiResponsesToolChoice3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.OpenAiResponsesToolChoiceOneOf3Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAiResponsesToolChoice3" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type"></param>
        public OpenAiResponsesToolChoice3(
            string name,
            global::G.OpenAiResponsesToolChoiceOneOf3Type type)
        {
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAiResponsesToolChoice3" /> class.
        /// </summary>
        public OpenAiResponsesToolChoice3()
        {
        }
    }
}