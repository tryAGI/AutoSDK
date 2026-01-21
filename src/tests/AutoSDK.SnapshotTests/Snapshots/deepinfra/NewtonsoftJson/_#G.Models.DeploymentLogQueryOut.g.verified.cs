//HintName: G.Models.DeploymentLogQueryOut.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeploymentLogQueryOut
    {
        /// <summary>
        /// mapping of pod names to log lines ordered by increasing timestamp
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("entries")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<byte[]>>? Entries { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentLogQueryOut" /> class.
        /// </summary>
        /// <param name="entries">
        /// mapping of pod names to log lines ordered by increasing timestamp
        /// </param>
        public DeploymentLogQueryOut(
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<byte[]>>? entries)
        {
            this.Entries = entries;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentLogQueryOut" /> class.
        /// </summary>
        public DeploymentLogQueryOut()
        {
        }
    }
}