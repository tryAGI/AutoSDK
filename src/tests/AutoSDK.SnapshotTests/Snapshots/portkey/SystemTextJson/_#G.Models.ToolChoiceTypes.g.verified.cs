//HintName: G.Models.ToolChoiceTypes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Indicates that the model should use a built-in tool to generate a response.<br/>
    /// [Learn more about built-in tools](/docs/guides/tools).
    /// </summary>
    public sealed partial class ToolChoiceTypes
    {
        /// <summary>
        /// The type of hosted tool the model should to use. Learn more about<br/>
        /// [built-in tools](/docs/guides/tools).<br/>
        /// Allowed values are:<br/>
        /// - `file_search`<br/>
        /// - `web_search_preview`<br/>
        /// - `computer_use_preview`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ToolChoiceTypesTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ToolChoiceTypesType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolChoiceTypes" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of hosted tool the model should to use. Learn more about<br/>
        /// [built-in tools](/docs/guides/tools).<br/>
        /// Allowed values are:<br/>
        /// - `file_search`<br/>
        /// - `web_search_preview`<br/>
        /// - `computer_use_preview`
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolChoiceTypes(
            global::G.ToolChoiceTypesType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolChoiceTypes" /> class.
        /// </summary>
        public ToolChoiceTypes()
        {
        }
    }
}