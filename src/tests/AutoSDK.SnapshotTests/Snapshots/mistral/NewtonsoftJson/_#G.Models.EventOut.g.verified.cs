//HintName: G.Models.EventOut.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EventOut
    {
        /// <summary>
        /// The UNIX timestamp (in seconds) of the event.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTimeOffset CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public object? Data { get; set; }

        /// <summary>
        /// The name of the event.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EventOut" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// The UNIX timestamp (in seconds) of the event.
        /// </param>
        /// <param name="data"></param>
        /// <param name="name">
        /// The name of the event.
        /// </param>
        public EventOut(
            global::System.DateTimeOffset createdAt,
            string name,
            object? data)
        {
            this.CreatedAt = createdAt;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EventOut" /> class.
        /// </summary>
        public EventOut()
        {
        }
    }
}