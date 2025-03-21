//HintName: G.Models.Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An action to type in text.
    /// </summary>
    public sealed partial class Type
    {
        /// <summary>
        /// The text to type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Specifies the event type. For a type action, this property is <br/>
        /// always set to `type`.<br/>
        /// Default Value: type
        /// </summary>
        /// <default>global::G.TypeType1.Type</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TypeType1JsonConverter))]
        public global::G.TypeType1 Type1 { get; set; } = global::G.TypeType1.Type;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Type" /> class.
        /// </summary>
        /// <param name="text">
        /// The text to type.
        /// </param>
        /// <param name="type1">
        /// Specifies the event type. For a type action, this property is <br/>
        /// always set to `type`.<br/>
        /// Default Value: type
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Type(
            string text,
            global::G.TypeType1 type1 = global::G.TypeType1.Type)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Type1 = type1;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Type" /> class.
        /// </summary>
        public Type()
        {
        }
    }
}