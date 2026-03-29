//HintName: G.Models.AssertionScoreAverage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Per-assertion average pass rates for evaluation suite experiments. Null for regular experiments.<br/>
    /// Included only in responses
    /// </summary>
    public sealed partial class AssertionScoreAverage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public double Value { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssertionScoreAverage" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public AssertionScoreAverage(
            string name,
            double value)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssertionScoreAverage" /> class.
        /// </summary>
        public AssertionScoreAverage()
        {
        }
    }
}