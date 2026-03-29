//HintName: G.Models.GetExperimentsOldRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetExperimentsOldRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("include")]
        public global::G.IncludeExperimentKeys? Include { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filter", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ExperimentFilterNode Filter { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetExperimentsOldRequest" /> class.
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="include"></param>
        public GetExperimentsOldRequest(
            global::G.ExperimentFilterNode filter,
            global::G.IncludeExperimentKeys? include)
        {
            this.Include = include;
            this.Filter = filter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetExperimentsOldRequest" /> class.
        /// </summary>
        public GetExperimentsOldRequest()
        {
        }
    }
}