//HintName: G.Models.Prompt2025VersionPromptBodyToolFunction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Prompt2025VersionPromptBodyToolFunction
    {
        /// <summary>
        /// Construct a type with a set of properties K of type T
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parameters", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RecordStringUnknown Parameters { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="Prompt2025VersionPromptBodyToolFunction" /> class.
        /// </summary>
        /// <param name="parameters">
        /// Construct a type with a set of properties K of type T
        /// </param>
        /// <param name="description"></param>
        /// <param name="name"></param>
        public Prompt2025VersionPromptBodyToolFunction(
            global::G.RecordStringUnknown parameters,
            string description,
            string name)
        {
            this.Parameters = parameters ?? throw new global::System.ArgumentNullException(nameof(parameters));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Prompt2025VersionPromptBodyToolFunction" /> class.
        /// </summary>
        public Prompt2025VersionPromptBodyToolFunction()
        {
        }
    }
}