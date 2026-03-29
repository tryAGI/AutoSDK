//HintName: G.Models.SandboxesWithMetrics.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SandboxesWithMetrics
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sandboxes", Required = global::Newtonsoft.Json.Required.Always)]
        public object Sandboxes { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesWithMetrics" /> class.
        /// </summary>
        /// <param name="sandboxes"></param>
        public SandboxesWithMetrics(
            object sandboxes)
        {
            this.Sandboxes = sandboxes ?? throw new global::System.ArgumentNullException(nameof(sandboxes));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesWithMetrics" /> class.
        /// </summary>
        public SandboxesWithMetrics()
        {
        }
    }
}