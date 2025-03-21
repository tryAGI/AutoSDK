//HintName: G.Models.CreateModerationRequestInputVariant3ItemVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An object describing text to classify.
    /// </summary>
    public sealed partial class CreateModerationRequestInputVariant3ItemVariant2
    {
        /// <summary>
        /// A string of text to classify.<br/>
        /// Example: I want to kill them
        /// </summary>
        /// <example>I want to kill them</example>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Always `text`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.CreateModerationRequestInputVariant3ItemVariant2Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModerationRequestInputVariant3ItemVariant2" /> class.
        /// </summary>
        /// <param name="text">
        /// A string of text to classify.<br/>
        /// Example: I want to kill them
        /// </param>
        /// <param name="type">
        /// Always `text`.
        /// </param>
        public CreateModerationRequestInputVariant3ItemVariant2(
            string text,
            global::G.CreateModerationRequestInputVariant3ItemVariant2Type type)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModerationRequestInputVariant3ItemVariant2" /> class.
        /// </summary>
        public CreateModerationRequestInputVariant3ItemVariant2()
        {
        }
    }
}