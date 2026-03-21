//HintName: G.Models.ListenV1ResultsChannel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Channel alternatives.
    /// </summary>
    public sealed partial class ListenV1ResultsChannel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("alternatives", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ListenV1ResultsChannelAlternatives> Alternatives { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV1ResultsChannel" /> class.
        /// </summary>
        /// <param name="alternatives"></param>
        public ListenV1ResultsChannel(
            global::System.Collections.Generic.IList<global::G.ListenV1ResultsChannelAlternatives> alternatives)
        {
            this.Alternatives = alternatives ?? throw new global::System.ArgumentNullException(nameof(alternatives));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV1ResultsChannel" /> class.
        /// </summary>
        public ListenV1ResultsChannel()
        {
        }
    }
}