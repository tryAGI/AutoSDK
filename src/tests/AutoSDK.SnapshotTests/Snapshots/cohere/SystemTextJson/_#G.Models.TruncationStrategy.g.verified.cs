//HintName: G.Models.TruncationStrategy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Describes the truncation strategy for when the prompt exceeds the context length. Defaults to 'none'
    /// </summary>
    public sealed partial class TruncationStrategy
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}