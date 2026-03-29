//HintName: G.Models.GetTokenUsageResponse2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetTokenUsageResponse2
    {
        /// <summary>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        public bool? Success { get; set; }

        /// <summary>
        /// Example: Could not find token usage information
        /// </summary>
        /// <example>Could not find token usage information</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTokenUsageResponse2" /> class.
        /// </summary>
        /// <param name="success">
        /// Example: false
        /// </param>
        /// <param name="error">
        /// Example: Could not find token usage information
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetTokenUsageResponse2(
            bool? success,
            string? error)
        {
            this.Success = success;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTokenUsageResponse2" /> class.
        /// </summary>
        public GetTokenUsageResponse2()
        {
        }
    }
}