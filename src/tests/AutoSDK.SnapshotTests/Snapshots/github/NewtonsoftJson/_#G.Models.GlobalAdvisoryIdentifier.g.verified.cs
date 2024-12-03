//HintName: G.Models.GlobalAdvisoryIdentifier.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GlobalAdvisoryIdentifier
    {
        /// <summary>
        /// The type of identifier.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GlobalAdvisoryIdentifierType Type { get; set; } = default!;

        /// <summary>
        /// The identifier value.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public string Value { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalAdvisoryIdentifier" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of identifier.
        /// </param>
        /// <param name="value">
        /// The identifier value.
        /// </param>
        public GlobalAdvisoryIdentifier(
            global::G.GlobalAdvisoryIdentifierType type,
            string value)
        {
            this.Type = type;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalAdvisoryIdentifier" /> class.
        /// </summary>
        public GlobalAdvisoryIdentifier()
        {
        }
    }
}