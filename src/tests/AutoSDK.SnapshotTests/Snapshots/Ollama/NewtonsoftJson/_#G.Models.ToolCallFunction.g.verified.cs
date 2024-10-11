//HintName: G.Models.ToolCallFunction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The function the model wants to call.
    /// </summary>
    public sealed partial class ToolCallFunction
    {
        /// <summary>
        /// The name of the function to be called.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The arguments to pass to the function.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("arguments", Required = global::Newtonsoft.Json.Required.Always)]
        public object Arguments { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}