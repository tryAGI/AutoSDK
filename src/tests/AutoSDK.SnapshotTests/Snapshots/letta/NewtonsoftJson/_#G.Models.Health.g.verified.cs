//HintName: G.Models.Health.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Health check response body
    /// </summary>
    public sealed partial class Health
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version", Required = global::Newtonsoft.Json.Required.Always)]
        public string Version { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public string Status { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Health" /> class.
        /// </summary>
        /// <param name="version"></param>
        /// <param name="status"></param>
        public Health(
            string version,
            string status)
        {
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Health" /> class.
        /// </summary>
        public Health()
        {
        }
    }
}