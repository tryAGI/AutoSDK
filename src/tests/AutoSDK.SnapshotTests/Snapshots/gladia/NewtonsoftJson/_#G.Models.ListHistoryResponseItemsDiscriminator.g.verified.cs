//HintName: G.Models.ListHistoryResponseItemsDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListHistoryResponseItemsDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("kind")]
        public global::G.ListHistoryResponseItemsDiscriminatorKind? Kind { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListHistoryResponseItemsDiscriminator" /> class.
        /// </summary>
        /// <param name="kind"></param>
        public ListHistoryResponseItemsDiscriminator(
            global::G.ListHistoryResponseItemsDiscriminatorKind? kind)
        {
            this.Kind = kind;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListHistoryResponseItemsDiscriminator" /> class.
        /// </summary>
        public ListHistoryResponseItemsDiscriminator()
        {
        }
    }
}