//HintName: G.Models.VariableValueGroupBy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VariableValueGroupBy
    {
        /// <summary>
        /// This is the key of the variable value to group by.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("key", Required = global::Newtonsoft.Json.Required.Always)]
        public string Key { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VariableValueGroupBy" /> class.
        /// </summary>
        /// <param name="key">
        /// This is the key of the variable value to group by.
        /// </param>
        public VariableValueGroupBy(
            string key)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VariableValueGroupBy" /> class.
        /// </summary>
        public VariableValueGroupBy()
        {
        }
    }
}