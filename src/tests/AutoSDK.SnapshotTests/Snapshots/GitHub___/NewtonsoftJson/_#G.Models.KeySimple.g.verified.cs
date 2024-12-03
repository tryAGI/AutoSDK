//HintName: G.Models.KeySimple.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Key Simple
    /// </summary>
    public sealed partial class KeySimple
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("key", Required = global::Newtonsoft.Json.Required.Always)]
        public string Key { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KeySimple" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="key"></param>
        public KeySimple(
            int id,
            string key)
        {
            this.Id = id;
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KeySimple" /> class.
        /// </summary>
        public KeySimple()
        {
        }
    }
}