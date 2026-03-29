//HintName: G.Models.ExperimentItemsBatch.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExperimentItemsBatch
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("experiment_items", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ExperimentItem> ExperimentItems { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentItemsBatch" /> class.
        /// </summary>
        /// <param name="experimentItems"></param>
        public ExperimentItemsBatch(
            global::System.Collections.Generic.IList<global::G.ExperimentItem> experimentItems)
        {
            this.ExperimentItems = experimentItems ?? throw new global::System.ArgumentNullException(nameof(experimentItems));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentItemsBatch" /> class.
        /// </summary>
        public ExperimentItemsBatch()
        {
        }
    }
}