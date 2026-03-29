//HintName: G.Models.CallFilterDynamicVariable.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CallFilterDynamicVariable
    {
        /// <summary>
        /// The dynamic variable name to filter on.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("key", Required = global::Newtonsoft.Json.Required.Always)]
        public string Key { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallFilterDynamicVariable" /> class.
        /// </summary>
        /// <param name="key">
        /// The dynamic variable name to filter on.
        /// </param>
        public CallFilterDynamicVariable(
            string key)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallFilterDynamicVariable" /> class.
        /// </summary>
        public CallFilterDynamicVariable()
        {
        }
    }
}