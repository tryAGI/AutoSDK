//HintName: G.Models.ContextExamplePair.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContextExamplePair
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("positive", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RecommendExample Positive { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("negative", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RecommendExample Negative { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextExamplePair" /> class.
        /// </summary>
        /// <param name="positive"></param>
        /// <param name="negative"></param>
        public ContextExamplePair(
            global::G.RecommendExample positive,
            global::G.RecommendExample negative)
        {
            this.Positive = positive;
            this.Negative = negative;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextExamplePair" /> class.
        /// </summary>
        public ContextExamplePair()
        {
        }
    }
}