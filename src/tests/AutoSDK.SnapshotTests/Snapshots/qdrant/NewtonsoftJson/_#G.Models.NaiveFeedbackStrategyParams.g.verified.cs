//HintName: G.Models.NaiveFeedbackStrategyParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NaiveFeedbackStrategyParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("a", Required = global::Newtonsoft.Json.Required.Always)]
        public float A { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("b", Required = global::Newtonsoft.Json.Required.Always)]
        public float B { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("c", Required = global::Newtonsoft.Json.Required.Always)]
        public float C { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NaiveFeedbackStrategyParams" /> class.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        public NaiveFeedbackStrategyParams(
            float a,
            float b,
            float c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NaiveFeedbackStrategyParams" /> class.
        /// </summary>
        public NaiveFeedbackStrategyParams()
        {
        }
    }
}