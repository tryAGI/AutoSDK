//HintName: G.Models.KeyPress.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A collection of keypresses the model would like to perform.
    /// </summary>
    public sealed partial class KeyPress
    {
        /// <summary>
        /// Specifies the event type. For a keypress action, this property is <br/>
        /// always set to `keypress`.<br/>
        /// Default Value: keypress
        /// </summary>
        /// <default>global::G.KeyPressType.Keypress</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.KeyPressTypeJsonConverter))]
        public global::G.KeyPressType Type { get; set; } = global::G.KeyPressType.Keypress;

        /// <summary>
        /// The combination of keys the model is requesting to be pressed. This is an<br/>
        /// array of strings, each representing a key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keys")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Keys { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyPress" /> class.
        /// </summary>
        /// <param name="type">
        /// Specifies the event type. For a keypress action, this property is <br/>
        /// always set to `keypress`.<br/>
        /// Default Value: keypress
        /// </param>
        /// <param name="keys">
        /// The combination of keys the model is requesting to be pressed. This is an<br/>
        /// array of strings, each representing a key.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KeyPress(
            global::System.Collections.Generic.IList<string> keys,
            global::G.KeyPressType type = global::G.KeyPressType.Keypress)
        {
            this.Keys = keys ?? throw new global::System.ArgumentNullException(nameof(keys));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyPress" /> class.
        /// </summary>
        public KeyPress()
        {
        }
    }
}