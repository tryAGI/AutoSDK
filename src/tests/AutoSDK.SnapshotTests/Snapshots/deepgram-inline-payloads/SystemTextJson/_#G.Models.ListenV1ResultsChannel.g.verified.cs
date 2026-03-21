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
        [global::System.Text.Json.Serialization.JsonPropertyName("alternatives")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ListenV1ResultsChannelAlternatives> Alternatives { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV1ResultsChannel" /> class.
        /// </summary>
        /// <param name="alternatives"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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