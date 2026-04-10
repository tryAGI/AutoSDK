//HintName: G.Models.ResponseOutputContentDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseOutputContentDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ResponseOutputContentDiscriminatorTypeJsonConverter))]
        public global::G.ResponseOutputContentDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseOutputContentDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
        public ResponseOutputContentDiscriminator(
            global::G.ResponseOutputContentDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseOutputContentDiscriminator" /> class.
        /// </summary>
        public ResponseOutputContentDiscriminator()
        {
        }
    }
}