//HintName: G.Models.NumericalFeedbackDetailUpdate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NumericalFeedbackDetailUpdate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max", Required = global::Newtonsoft.Json.Required.Always)]
        public double Max { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("min", Required = global::Newtonsoft.Json.Required.Always)]
        public double Min { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NumericalFeedbackDetailUpdate" /> class.
        /// </summary>
        /// <param name="max"></param>
        /// <param name="min"></param>
        public NumericalFeedbackDetailUpdate(
            double max,
            double min)
        {
            this.Max = max;
            this.Min = min;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumericalFeedbackDetailUpdate" /> class.
        /// </summary>
        public NumericalFeedbackDetailUpdate()
        {
        }
    }
}