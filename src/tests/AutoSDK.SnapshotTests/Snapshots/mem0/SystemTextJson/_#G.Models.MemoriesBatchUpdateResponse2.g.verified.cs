//HintName: G.Models.MemoriesBatchUpdateResponse2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MemoriesBatchUpdateResponse2
    {
        /// <summary>
        /// Example: Maximum of 1000 memories can be updated in a single request
        /// </summary>
        /// <example>Maximum of 1000 memories can be updated in a single request</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoriesBatchUpdateResponse2" /> class.
        /// </summary>
        /// <param name="error">
        /// Example: Maximum of 1000 memories can be updated in a single request
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MemoriesBatchUpdateResponse2(
            string? error)
        {
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoriesBatchUpdateResponse2" /> class.
        /// </summary>
        public MemoriesBatchUpdateResponse2()
        {
        }
    }
}