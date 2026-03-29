//HintName: G.Models.ScimEmail.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScimEmail
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("primary", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Primary { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public string Value { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScimEmail" /> class.
        /// </summary>
        /// <param name="primary"></param>
        /// <param name="value"></param>
        /// <param name="type"></param>
        public ScimEmail(
            bool primary,
            string value,
            string type)
        {
            this.Primary = primary;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScimEmail" /> class.
        /// </summary>
        public ScimEmail()
        {
        }
    }
}