//HintName: G.Models.WriteDeleteCondition.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A condition evaluated against the current value of each document targeted by a delete write. Only documents that pass the condition are deleted.
    /// </summary>
    public sealed partial class WriteDeleteCondition
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}