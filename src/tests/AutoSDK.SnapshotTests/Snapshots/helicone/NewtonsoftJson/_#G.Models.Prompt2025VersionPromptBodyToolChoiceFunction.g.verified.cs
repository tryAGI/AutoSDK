//HintName: G.Models.Prompt2025VersionPromptBodyToolChoiceFunction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Prompt2025VersionPromptBodyToolChoiceFunction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.Prompt2025VersionPromptBodyToolChoiceFunctionTypeJsonConverter))]
        public global::G.Prompt2025VersionPromptBodyToolChoiceFunctionType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Prompt2025VersionPromptBodyToolChoiceFunction" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type"></param>
        public Prompt2025VersionPromptBodyToolChoiceFunction(
            string name,
            global::G.Prompt2025VersionPromptBodyToolChoiceFunctionType type)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Prompt2025VersionPromptBodyToolChoiceFunction" /> class.
        /// </summary>
        public Prompt2025VersionPromptBodyToolChoiceFunction()
        {
        }
    }
}