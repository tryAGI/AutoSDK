//HintName: G.Models.CustomFieldFilterVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomFieldFilterVariant2
    {
        /// <summary>
        /// The field name to filter on.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("key", Required = global::Newtonsoft.Json.Required.Always)]
        public string Key { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomFieldFilterVariant2" /> class.
        /// </summary>
        /// <param name="key">
        /// The field name to filter on.
        /// </param>
        public CustomFieldFilterVariant2(
            string key)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomFieldFilterVariant2" /> class.
        /// </summary>
        public CustomFieldFilterVariant2()
        {
        }
    }
}