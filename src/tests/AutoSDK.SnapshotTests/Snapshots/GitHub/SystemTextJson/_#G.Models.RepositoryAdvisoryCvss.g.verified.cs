//HintName: G.Models.RepositoryAdvisoryCvss.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RepositoryAdvisoryCvss
    {
        /// <summary>
        /// The CVSS vector.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vector_string")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? VectorString { get; set; }

        /// <summary>
        /// The CVSS score.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public double? Score { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}