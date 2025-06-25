//HintName: G.Models.ContainerResourceExpiresAfter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The container will expire after this time period.<br/>
    /// The anchor is the reference point for the expiration.<br/>
    /// The minutes is the number of minutes after the anchor before the container expires.
    /// </summary>
    public sealed partial class ContainerResourceExpiresAfter
    {
        /// <summary>
        /// The reference point for the expiration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("anchor")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ContainerResourceExpiresAfterAnchorJsonConverter))]
        public global::G.ContainerResourceExpiresAfterAnchor? Anchor { get; set; }

        /// <summary>
        /// The number of minutes after the anchor before the container expires.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minutes")]
        public int? Minutes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerResourceExpiresAfter" /> class.
        /// </summary>
        /// <param name="anchor">
        /// The reference point for the expiration.
        /// </param>
        /// <param name="minutes">
        /// The number of minutes after the anchor before the container expires.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContainerResourceExpiresAfter(
            global::G.ContainerResourceExpiresAfterAnchor? anchor,
            int? minutes)
        {
            this.Anchor = anchor;
            this.Minutes = minutes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerResourceExpiresAfter" /> class.
        /// </summary>
        public ContainerResourceExpiresAfter()
        {
        }
    }
}