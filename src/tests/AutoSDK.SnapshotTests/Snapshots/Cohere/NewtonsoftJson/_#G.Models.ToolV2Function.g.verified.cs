//HintName: G.Models.ToolV2Function.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The function to be executed.
    /// </summary>
    public sealed partial class ToolV2Function
    {
        /// <summary>
        /// The name of the function.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The description of the function.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The parameters of the function as a JSON schema.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parameters")]
        public global::G.ToolV2FunctionParameters? Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}