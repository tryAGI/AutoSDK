//HintName: G.Models.ListTranscriptionResponseItemsDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListTranscriptionResponseItemsDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("kind")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ListTranscriptionResponseItemsDiscriminatorKindJsonConverter))]
        public global::G.ListTranscriptionResponseItemsDiscriminatorKind? Kind { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListTranscriptionResponseItemsDiscriminator" /> class.
        /// </summary>
        /// <param name="kind"></param>
        public ListTranscriptionResponseItemsDiscriminator(
            global::G.ListTranscriptionResponseItemsDiscriminatorKind? kind)
        {
            this.Kind = kind;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListTranscriptionResponseItemsDiscriminator" /> class.
        /// </summary>
        public ListTranscriptionResponseItemsDiscriminator()
        {
        }
    }
}