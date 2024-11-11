//HintName: G.Models.FeedbackConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FeedbackConfig
    {
        /// <summary>
        /// Enum for feedback types.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.FeedbackType Type { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("min")]
        public double? Min { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max")]
        public double? Max { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("categories")]
        public global::System.Collections.Generic.IList<global::G.FeedbackCategory>? Categories { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackConfig" /> class.
        /// </summary>
        /// <param name="type">
        /// Enum for feedback types.
        /// </param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <param name="categories"></param>
        public FeedbackConfig(
            global::G.FeedbackType type,
            double? min,
            double? max,
            global::System.Collections.Generic.IList<global::G.FeedbackCategory>? categories)
        {
            this.Type = type;
            this.Min = min;
            this.Max = max;
            this.Categories = categories;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackConfig" /> class.
        /// </summary>
        public FeedbackConfig()
        {
        }
    }
}