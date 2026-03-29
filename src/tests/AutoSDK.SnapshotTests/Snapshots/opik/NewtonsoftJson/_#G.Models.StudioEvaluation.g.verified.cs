//HintName: G.Models.StudioEvaluation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StudioEvaluation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metrics", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.StudioMetric> Metrics { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StudioEvaluation" /> class.
        /// </summary>
        /// <param name="metrics"></param>
        public StudioEvaluation(
            global::System.Collections.Generic.IList<global::G.StudioMetric> metrics)
        {
            this.Metrics = metrics ?? throw new global::System.ArgumentNullException(nameof(metrics));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StudioEvaluation" /> class.
        /// </summary>
        public StudioEvaluation()
        {
        }
    }
}