//HintName: G.Models.ChatCompletionToolChoiceOption.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Controls which (if any) tool is called by the model.
    /// `none` means the model will not call any tool and instead generates a message.
    /// `auto` means the model can pick between generating a message or calling one or more tools.
    /// `required` means the model must call one or more tools.
    /// Specifying a particular tool via `{"type": "function", "function": {"name": "my_function"}}` forces the model to call that tool.
    /// `none` is the default when no tools are present. `auto` is the default if tools are present.
    /// </summary>
    public sealed partial class ChatCompletionToolChoiceOption
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}