//HintName: G.Models.FailMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FailMessage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("key", Required = global::Newtonsoft.Json.Required.Always)]
        public string Key { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("extras", Required = global::Newtonsoft.Json.Required.Always)]
        public object Extras { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FailMessage" /> class.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="key"></param>
        /// <param name="extras"></param>
        public FailMessage(
            string description,
            string key,
            object extras)
        {
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Extras = extras ?? throw new global::System.ArgumentNullException(nameof(extras));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FailMessage" /> class.
        /// </summary>
        public FailMessage()
        {
        }
    }
}