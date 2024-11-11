//HintName: G.Models.LLMPrompts.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// List of prompts that the model can use. This is deprecated; see `/v2/generation_presets` instead.
    /// </summary>
    [global::System.Obsolete("This model marked as deprecated.")]
    public sealed partial class LLMPrompts
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMPrompts" /> class.
        /// </summary>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public LLMPrompts(
 )
        {
        }
    }
}