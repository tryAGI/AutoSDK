//HintName: G.Models.UpdatePromptRequestToolChoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Controls which tool the model uses. When `patch` is `true`, this field is optional and will be inherited from the current latest version if omitted.
    /// </summary>
    public sealed partial class UpdatePromptRequestToolChoice
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}