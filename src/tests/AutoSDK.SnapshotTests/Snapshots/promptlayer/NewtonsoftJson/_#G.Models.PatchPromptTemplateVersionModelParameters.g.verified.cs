//HintName: G.Models.PatchPromptTemplateVersionModelParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Parameters to shallow-merge into the existing model parameters (e.g. temperature, max_tokens). Existing keys not specified here are preserved.
    /// </summary>
    public sealed partial class PatchPromptTemplateVersionModelParameters
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}