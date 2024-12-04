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
        /// Always `text`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateModerationRequestInputVariant3ItemVariant2TypeJsonConverter))]
        public global::G.CreateModerationRequestInputVariant3ItemVariant2Type Type { get; set; }

        /// <summary>
        /// A string of text to classify.<br/>
        /// Example: I want to kill them
        /// </summary>
        /// <example>I want to kill them</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModerationRequestInputVariant3ItemVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// Always `text`.
        /// </param>
        /// <param name="text">
        /// A string of text to classify.<br/>
        /// Example: I want to kill them
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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