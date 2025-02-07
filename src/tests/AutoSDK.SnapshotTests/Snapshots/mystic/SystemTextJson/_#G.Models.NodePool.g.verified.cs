//HintName: G.Models.NodePool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Base model for schemas.
    /// </summary>
    public sealed partial class NodePool
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accelerators")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.Accelerator> Accelerators { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// Base model for schemas.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoscaling")]
        public global::G.NodePoolAutoscaling? Autoscaling { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("console_link")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConsoleLink { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_spot_instances")]
        public bool? UseSpotInstances { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_pipelines")]
        public int? NumPipelines { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NodePool" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="accelerators"></param>
        /// <param name="status"></param>
        /// <param name="autoscaling">
        /// Base model for schemas.
        /// </param>
        /// <param name="consoleLink"></param>
        /// <param name="useSpotInstances">
        /// Default Value: false
        /// </param>
        /// <param name="numPipelines">
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NodePool(
            string name,
            global::System.Collections.Generic.IList<global::G.Accelerator> accelerators,
            string status,
            string consoleLink,
            global::G.NodePoolAutoscaling? autoscaling,
            bool? useSpotInstances,
            int? numPipelines)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Accelerators = accelerators ?? throw new global::System.ArgumentNullException(nameof(accelerators));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.ConsoleLink = consoleLink ?? throw new global::System.ArgumentNullException(nameof(consoleLink));
            this.Autoscaling = autoscaling;
            this.UseSpotInstances = useSpotInstances;
            this.NumPipelines = numPipelines;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodePool" /> class.
        /// </summary>
        public NodePool()
        {
        }
    }
}