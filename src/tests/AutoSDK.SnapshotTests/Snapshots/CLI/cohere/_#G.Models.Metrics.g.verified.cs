﻿//HintName: G.Models.Metrics.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Metrics
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finetune_dataset_metrics")]
        public global::G.FinetuneDatasetMetrics? FinetuneDatasetMetrics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Metrics" /> class.
        /// </summary>
        /// <param name="finetuneDatasetMetrics"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Metrics(
            global::G.FinetuneDatasetMetrics? finetuneDatasetMetrics)
        {
            this.FinetuneDatasetMetrics = finetuneDatasetMetrics;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Metrics" /> class.
        /// </summary>
        public Metrics()
        {
        }
    }
}