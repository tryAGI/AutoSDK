//HintName: G.Models.WritePatchCondition.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A condition evaluated against the current value of each document targeted by a patch write. Only documents that pass the condition are patched.
    /// </summary>
    public sealed partial class WritePatchCondition
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}