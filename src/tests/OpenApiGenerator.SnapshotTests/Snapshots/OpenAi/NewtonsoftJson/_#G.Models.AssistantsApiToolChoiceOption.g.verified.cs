//HintName: G.Models.AssistantsApiToolChoiceOption.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Controls which (if any) tool is called by the model.
    /// `none` means the model will not call any tools and instead generates a message.
    /// `auto` is the default value and means the model can pick between generating a message or calling one or more tools.
    /// `required` means the model must call one or more tools before responding to the user.
    /// Specifying a particular tool like `{"type": "file_search"}` or `{"type": "function", "function": {"name": "my_function"}}` forces the model to call that tool.
    /// </summary>
    public sealed partial class AssistantsApiToolChoiceOption
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}