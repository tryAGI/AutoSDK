//HintName: G.Models.ListenV1ServerEventDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListenV1ServerEventDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ListenV1ServerEventDiscriminatorTypeJsonConverter))]
        public global::G.ListenV1ServerEventDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV1ServerEventDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
        public ListenV1ServerEventDiscriminator(
            global::G.ListenV1ServerEventDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV1ServerEventDiscriminator" /> class.
        /// </summary>
        public ListenV1ServerEventDiscriminator()
        {
        }
    }
}