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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "dynamic";

        /// <summary>
        /// The SIP header name (e.g., 'X-Customer-ID')
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// The dynamic variable name to resolve
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomSIPHeaderWithDynamicVariable" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="key">
        /// The SIP header name (e.g., 'X-Customer-ID')
        /// </param>
        /// <param name="value">
        /// The dynamic variable name to resolve
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomSIPHeaderWithDynamicVariable(
            string key,
            string value,
            string type = "dynamic")
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomSIPHeaderWithDynamicVariable" /> class.
        /// </summary>
        public CustomSIPHeaderWithDynamicVariable()
        {
        }
    }
}