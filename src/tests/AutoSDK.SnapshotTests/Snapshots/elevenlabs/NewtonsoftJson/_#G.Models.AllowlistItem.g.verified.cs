//HintName: G.Models.AllowlistItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AllowlistItem
    {
        /// <summary>
        /// The hostname of the allowed origin
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hostname", Required = global::Newtonsoft.Json.Required.Always)]
        public string Hostname { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AllowlistItem" /> class.
        /// </summary>
        /// <param name="hostname">
        /// The hostname of the allowed origin
        /// </param>
        public AllowlistItem(
            string hostname)
        {
            this.Hostname = hostname ?? throw new global::System.ArgumentNullException(nameof(hostname));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AllowlistItem" /> class.
        /// </summary>
        public AllowlistItem()
        {
        }
    }
}