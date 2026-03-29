//HintName: G.Models.DiscoverQuery.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DiscoverQuery
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discover")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.DiscoverInput Discover { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DiscoverQuery" /> class.
        /// </summary>
        /// <param name="discover"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DiscoverQuery(
            global::G.DiscoverInput discover)
        {
            this.Discover = discover ?? throw new global::System.ArgumentNullException(nameof(discover));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiscoverQuery" /> class.
        /// </summary>
        public DiscoverQuery()
        {
        }
    }
}