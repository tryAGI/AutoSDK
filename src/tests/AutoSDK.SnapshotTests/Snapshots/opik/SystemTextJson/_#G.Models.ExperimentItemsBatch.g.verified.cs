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
        [global::System.Text.Json.Serialization.JsonPropertyName("experiment_items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ExperimentItem> ExperimentItems { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentItemsBatch" /> class.
        /// </summary>
        /// <param name="experimentItems"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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