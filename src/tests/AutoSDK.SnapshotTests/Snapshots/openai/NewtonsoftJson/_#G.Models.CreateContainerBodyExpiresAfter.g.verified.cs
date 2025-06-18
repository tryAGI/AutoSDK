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
        /// <param name="anchor">
        /// Time anchor for the expiration time. Currently only 'last_active_at' is supported.
        /// </param>
        /// <param name="minutes"></param>
        public CreateContainerBodyExpiresAfter(
            int minutes,
            global::G.CreateContainerBodyExpiresAfterAnchor anchor)
        {
            this.Minutes = minutes;
            this.Anchor = anchor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateContainerBodyExpiresAfter" /> class.
        /// </summary>
        public CreateContainerBodyExpiresAfter()
        {
        }
    }
}