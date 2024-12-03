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
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("accelerators", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Accelerator> Accelerators { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public string Status { get; set; } = default!;

        /// <summary>
        /// Base model for schemas.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("autoscaling")]
        public global::G.NodePoolAutoscaling? Autoscaling { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("console_link", Required = global::Newtonsoft.Json.Required.Always)]
        public string ConsoleLink { get; set; } = default!;

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("use_spot_instances")]
        public bool? UseSpotInstances { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_pipelines")]
        public int? NumPipelines { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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