//HintName: G.Models.CustomSIPHeaderWithDynamicVariable.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Custom SIP header for phone transfers with a dynamic variable reference.<br/>
    /// The value is a variable name that will be resolved at runtime.<br/>
    /// Value is not validated here since it will be substituted with actual value later.
    /// </summary>
    public sealed partial class CustomSIPHeaderWithDynamicVariable
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"dynamic"</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "dynamic";

        /// <summary>
        /// The SIP header name (e.g., 'X-Customer-ID')
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("key", Required = global::Newtonsoft.Json.Required.Always)]
        public string Key { get; set; } = default!;

        /// <summary>
        /// The dynamic variable name to resolve
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public string Value { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomSIPHeaderWithDynamicVariable" /> class.
        /// </summary>
        /// <param name="key">
        /// The SIP header name (e.g., 'X-Customer-ID')
        /// </param>
        /// <param name="value">
        /// The dynamic variable name to resolve
        /// </param>
        /// <param name="type"></param>
        public CustomSIPHeaderWithDynamicVariable(
            string key,
            string value,
            string type = "dynamic")
        {
            this.Type = type;
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomSIPHeaderWithDynamicVariable" /> class.
        /// </summary>
        public CustomSIPHeaderWithDynamicVariable()
        {
        }
    }
}