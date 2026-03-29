//HintName: G.Models.IdentityProperty.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A property of an identity
    /// </summary>
    public sealed partial class IdentityProperty
    {
        /// <summary>
        /// The key of the property
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("key", Required = global::Newtonsoft.Json.Required.Always)]
        public string Key { get; set; } = default!;

        /// <summary>
        /// The value of the property
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<string, int?, double?, bool?, object> Value { get; set; } = default!;

        /// <summary>
        /// The type of the property
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.IdentityPropertyType Type { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityProperty" /> class.
        /// </summary>
        /// <param name="key">
        /// The key of the property
        /// </param>
        /// <param name="value">
        /// The value of the property
        /// </param>
        /// <param name="type">
        /// The type of the property
        /// </param>
        public IdentityProperty(
            string key,
            global::G.AnyOf<string, int?, double?, bool?, object> value,
            global::G.IdentityPropertyType type)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Value = value;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityProperty" /> class.
        /// </summary>
        public IdentityProperty()
        {
        }
    }
}