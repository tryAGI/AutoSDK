//HintName: G.Models.ToolFunction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A function that the model may call.
    /// </summary>
    public sealed partial class ToolFunction
    {
        /// <summary>
        /// The name of the function to be called.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// A description of what the function does, used by the model to choose when and how to call the function.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// The parameters the functions accepts, described as a JSON Schema object.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parameters", Required = global::Newtonsoft.Json.Required.Always)]
        public object Parameters { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}