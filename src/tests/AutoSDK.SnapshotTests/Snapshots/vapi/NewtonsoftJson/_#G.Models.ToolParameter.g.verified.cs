//HintName: G.Models.ToolParameter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolParameter
    {
        /// <summary>
        /// This is the key of the parameter.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("key", Required = global::Newtonsoft.Json.Required.Always)]
        public string Key { get; set; } = default!;

        /// <summary>
        /// The value of the parameter. Any JSON type. String values support Liquid templates.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<string, double?, bool?, object, byte[]> Value { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolParameter" /> class.
        /// </summary>
        /// <param name="key">
        /// This is the key of the parameter.
        /// </param>
        /// <param name="value">
        /// The value of the parameter. Any JSON type. String values support Liquid templates.
        /// </param>
        public ToolParameter(
            string key,
            global::G.OneOf<string, double?, bool?, object, byte[]> value)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolParameter" /> class.
        /// </summary>
        public ToolParameter()
        {
        }
    }
}