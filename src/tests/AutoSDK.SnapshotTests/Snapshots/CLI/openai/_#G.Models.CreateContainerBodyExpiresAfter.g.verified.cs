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
        [global::System.Text.Json.Serialization.JsonPropertyName("anchor")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateContainerBodyExpiresAfterAnchorJsonConverter))]
        public global::G.CreateContainerBodyExpiresAfterAnchor Anchor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minutes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Minutes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateContainerBodyExpiresAfter" /> class.
        /// </summary>
        /// <param name="anchor">
        /// Time anchor for the expiration time. Currently only 'last_active_at' is supported.
        /// </param>
        /// <param name="minutes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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