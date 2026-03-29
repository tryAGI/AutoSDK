//HintName: G.Models.MatchAny.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Exact match on any of the given values
    /// </summary>
    public sealed partial class MatchAny
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("any", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyVariants Any { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MatchAny" /> class.
        /// </summary>
        /// <param name="any"></param>
        public MatchAny(
            global::G.AnyVariants any)
        {
            this.Any = any;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MatchAny" /> class.
        /// </summary>
        public MatchAny()
        {
        }
    }
}