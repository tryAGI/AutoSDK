//HintName: G.Models.DescribeBlocksRequestExecutionEngineVersion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Requested Execution Engine compatibility. If given, result will only contain blocks suitable for requested EE version, otherwise - descriptions for all available blocks will be delivered.
    /// </summary>
    public sealed partial class DescribeBlocksRequestExecutionEngineVersion
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}