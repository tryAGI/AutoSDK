//HintName: G.Models.DeployInstances.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeployInstances
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("running", Required = global::Newtonsoft.Json.Required.Always)]
        public int Running { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pending", Required = global::Newtonsoft.Json.Required.Always)]
        public int Pending { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeployInstances" /> class.
        /// </summary>
        /// <param name="running"></param>
        /// <param name="pending"></param>
        public DeployInstances(
            int running,
            int pending)
        {
            this.Running = running;
            this.Pending = pending;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeployInstances" /> class.
        /// </summary>
        public DeployInstances()
        {
        }
    }
}