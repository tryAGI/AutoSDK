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
        [global::Newtonsoft.Json.JsonProperty("discover", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.DiscoverInput Discover { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DiscoverQuery" /> class.
        /// </summary>
        /// <param name="discover"></param>
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