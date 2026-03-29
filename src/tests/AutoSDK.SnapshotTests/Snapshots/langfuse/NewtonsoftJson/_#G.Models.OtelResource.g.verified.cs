//HintName: G.Models.OtelResource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Resource attributes identifying the source of telemetry
    /// </summary>
    public sealed partial class OtelResource
    {
        /// <summary>
        /// Resource attributes like service.name, service.version, etc.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("attributes")]
        public global::System.Collections.Generic.IList<global::G.OtelAttribute>? Attributes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OtelResource" /> class.
        /// </summary>
        /// <param name="attributes">
        /// Resource attributes like service.name, service.version, etc.
        /// </param>
        public OtelResource(
            global::System.Collections.Generic.IList<global::G.OtelAttribute>? attributes)
        {
            this.Attributes = attributes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OtelResource" /> class.
        /// </summary>
        public OtelResource()
        {
        }
    }
}