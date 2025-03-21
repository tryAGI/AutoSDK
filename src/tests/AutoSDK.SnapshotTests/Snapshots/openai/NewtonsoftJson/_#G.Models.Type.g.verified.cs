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
        /// Specifies the event type. For a type action, this property is <br/>
        /// always set to `type`.<br/>
        /// Default Value: type
        /// </summary>
        /// <default>global::G.TypeType1.Type</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.TypeType1 Type1 { get; set; } = global::G.TypeType1.Type;

        /// <summary>
        /// The text to type.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Type" /> class.
        /// </summary>
        /// <param name="type1">
        /// Specifies the event type. For a type action, this property is <br/>
        /// always set to `type`.<br/>
        /// Default Value: type
        /// </param>
        /// <param name="text">
        /// The text to type.
        /// </param>
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