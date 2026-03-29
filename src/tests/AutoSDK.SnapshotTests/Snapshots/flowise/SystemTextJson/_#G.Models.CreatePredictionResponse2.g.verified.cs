//HintName: G.Models.CreatePredictionResponse2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreatePredictionResponse2
    {
        /// <summary>
        /// Example: Invalid request format. Check required fields and parameter types.
        /// </summary>
        /// <example>Invalid request format. Check required fields and parameter types.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePredictionResponse2" /> class.
        /// </summary>
        /// <param name="error">
        /// Example: Invalid request format. Check required fields and parameter types.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreatePredictionResponse2(
            string? error)
        {
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePredictionResponse2" /> class.
        /// </summary>
        public CreatePredictionResponse2()
        {
        }
    }
}