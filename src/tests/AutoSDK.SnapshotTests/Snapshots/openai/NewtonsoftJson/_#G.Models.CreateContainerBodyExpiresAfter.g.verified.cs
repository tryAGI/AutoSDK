//HintName: G.Models.CreateContainerBodyExpiresAfter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Container expiration time in seconds relative to the 'anchor' time.
    /// </summary>
    public sealed partial class CreateContainerBodyExpiresAfter
    {
        /// <summary>
        /// Time anchor for the expiration time. Currently only 'last_active_at' is supported.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("anchor")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CreateContainerBodyExpiresAfterAnchorJsonConverter))]
        public global::G.CreateContainerBodyExpiresAfterAnchor Anchor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("minutes", Required = global::Newtonsoft.Json.Required.Always)]
        public int Minutes { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateContainerBodyExpiresAfter" /> class.
        /// </summary>
        /// <param name="minutes"></param>
        /// <param name="anchor">
        /// Time anchor for the expiration time. Currently only 'last_active_at' is supported.
        /// </param>
        public CreateContainerBodyExpiresAfter(
            int minutes,
            global::G.CreateContainerBodyExpiresAfterAnchor anchor)
        {
            this.Anchor = anchor;
            this.Minutes = minutes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateContainerBodyExpiresAfter" /> class.
        /// </summary>
        public CreateContainerBodyExpiresAfter()
        {
        }
    }
}