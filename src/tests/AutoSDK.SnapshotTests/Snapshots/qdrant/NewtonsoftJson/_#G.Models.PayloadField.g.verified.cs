//HintName: G.Models.PayloadField.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Payload field
    /// </summary>
    public sealed partial class PayloadField
    {
        /// <summary>
        /// Payload field name
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("key", Required = global::Newtonsoft.Json.Required.Always)]
        public string Key { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PayloadField" /> class.
        /// </summary>
        /// <param name="key">
        /// Payload field name
        /// </param>
        public PayloadField(
            string key)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PayloadField" /> class.
        /// </summary>
        public PayloadField()
        {
        }
    }
}