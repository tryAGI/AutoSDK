//HintName: G.Models.Nested.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Select points with payload for a specified nested field
    /// </summary>
    public sealed partial class Nested
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("key", Required = global::Newtonsoft.Json.Required.Always)]
        public string Key { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filter", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Filter Filter { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Nested" /> class.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="filter"></param>
        public Nested(
            string key,
            global::G.Filter filter)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Filter = filter ?? throw new global::System.ArgumentNullException(nameof(filter));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Nested" /> class.
        /// </summary>
        public Nested()
        {
        }
    }
}