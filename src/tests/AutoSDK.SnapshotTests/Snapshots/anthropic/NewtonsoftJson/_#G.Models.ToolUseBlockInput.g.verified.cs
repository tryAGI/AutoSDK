//HintName: G.Models.ToolUseBlockInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An object containing the input being passed to the tool, conforming to the tool's `input_schema`.
    /// </summary>
    public sealed partial class ToolUseBlockInput
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolUseBlockInput" /> class.
        /// </summary>
        public ToolUseBlockInput(
 )
        {
        }
    }
}