//HintName: G.Models.Traffic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Traffic
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timestamp", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime Timestamp { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("uniques", Required = global::Newtonsoft.Json.Required.Always)]
        public int Uniques { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("count", Required = global::Newtonsoft.Json.Required.Always)]
        public int Count { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Traffic" /> class.
        /// </summary>
        /// <param name="timestamp"></param>
        /// <param name="uniques"></param>
        /// <param name="count"></param>
        public Traffic(
            global::System.DateTime timestamp,
            int uniques,
            int count)
        {
            this.Timestamp = timestamp;
            this.Uniques = uniques;
            this.Count = count;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Traffic" /> class.
        /// </summary>
        public Traffic()
        {
        }
    }
}