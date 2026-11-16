//HintName: G.Models.MappedStartEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MappedStartEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("kind", Required = global::Newtonsoft.Json.Required.Always)]
        public string Kind { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("startedAt")]
        public string? StartedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MappedStartEvent" /> class.
        /// </summary>
        /// <param name="kind"></param>
        /// <param name="startedAt"></param>
        public MappedStartEvent(
            string kind,
            string? startedAt)
        {
            this.Kind = kind ?? throw new global::System.ArgumentNullException(nameof(kind));
            this.StartedAt = startedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MappedStartEvent" /> class.
        /// </summary>
        public MappedStartEvent()
        {
        }

    }
}