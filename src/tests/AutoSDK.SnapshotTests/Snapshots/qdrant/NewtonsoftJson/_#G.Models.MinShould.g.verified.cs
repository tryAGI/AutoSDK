//HintName: G.Models.MinShould.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MinShould
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conditions", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Condition> Conditions { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("min_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int MinCount { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MinShould" /> class.
        /// </summary>
        /// <param name="conditions"></param>
        /// <param name="minCount"></param>
        public MinShould(
            global::System.Collections.Generic.IList<global::G.Condition> conditions,
            int minCount)
        {
            this.Conditions = conditions ?? throw new global::System.ArgumentNullException(nameof(conditions));
            this.MinCount = minCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MinShould" /> class.
        /// </summary>
        public MinShould()
        {
        }
    }
}