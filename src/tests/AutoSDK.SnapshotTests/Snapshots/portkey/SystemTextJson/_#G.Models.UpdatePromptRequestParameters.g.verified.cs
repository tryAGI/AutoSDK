//HintName: G.Models.UpdatePromptRequestParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Model parameters (e.g. temperature, max_tokens). When `patch` is `true`, this field is optional and will be inherited from the current latest version if omitted.
    /// </summary>
    public sealed partial class UpdatePromptRequestParameters
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}