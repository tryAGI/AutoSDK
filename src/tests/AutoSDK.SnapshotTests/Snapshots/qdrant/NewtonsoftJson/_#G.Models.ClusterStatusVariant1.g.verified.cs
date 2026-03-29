//HintName: G.Models.ClusterStatusVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClusterStatusVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.ClusterStatusVariant1Status Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterStatusVariant1" /> class.
        /// </summary>
        /// <param name="status"></param>
        public ClusterStatusVariant1(
            global::G.ClusterStatusVariant1Status status)
        {
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterStatusVariant1" /> class.
        /// </summary>
        public ClusterStatusVariant1()
        {
        }
    }
}