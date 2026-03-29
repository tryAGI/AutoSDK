//HintName: G.Models.PathwayEdgeData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PathwayEdgeData
    {
        /// <summary>
        /// Description of when this path is taken
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PathwayEdgeData" /> class.
        /// </summary>
        /// <param name="label">
        /// Description of when this path is taken
        /// </param>
        public PathwayEdgeData(
            string? label)
        {
            this.Label = label;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PathwayEdgeData" /> class.
        /// </summary>
        public PathwayEdgeData()
        {
        }
    }
}