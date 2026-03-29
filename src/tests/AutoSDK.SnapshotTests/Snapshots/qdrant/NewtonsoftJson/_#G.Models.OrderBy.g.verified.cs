//HintName: G.Models.OrderBy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrderBy
    {
        /// <summary>
        /// Payload key to order by
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("key", Required = global::Newtonsoft.Json.Required.Always)]
        public string Key { get; set; } = default!;

        /// <summary>
        /// Direction of ordering: `asc` or `desc`. Default is ascending.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("direction")]
        public global::G.Direction? Direction { get; set; }

        /// <summary>
        /// Which payload value to start scrolling from. Default is the lowest value for `asc` and the highest for `desc`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_from")]
        public global::G.StartFrom? StartFrom { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderBy" /> class.
        /// </summary>
        /// <param name="key">
        /// Payload key to order by
        /// </param>
        /// <param name="direction">
        /// Direction of ordering: `asc` or `desc`. Default is ascending.
        /// </param>
        /// <param name="startFrom">
        /// Which payload value to start scrolling from. Default is the lowest value for `asc` and the highest for `desc`
        /// </param>
        public OrderBy(
            string key,
            global::G.Direction? direction,
            global::G.StartFrom? startFrom)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Direction = direction;
            this.StartFrom = startFrom;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderBy" /> class.
        /// </summary>
        public OrderBy()
        {
        }
    }
}