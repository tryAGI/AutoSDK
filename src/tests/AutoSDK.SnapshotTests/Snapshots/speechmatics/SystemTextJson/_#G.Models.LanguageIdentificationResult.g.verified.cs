//HintName: G.Models.LanguageIdentificationResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"results":[{"alternatives":[{"language":"en","confidence":0.98},{"language":"fr","confidence":0.02}],"start_time":0,"end_time":5.5},{"alternatives":[{"language":"en","confidence":0.95},{"language":"fr","confidence":0.05}],"start_time":5.6,"end_time":10}]}
    /// </summary>
    public sealed partial class LanguageIdentificationResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        public global::System.Collections.Generic.IList<global::G.LanguageIdentificationResultItem>? Results { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.LanguageIdentificationResultErrorJsonConverter))]
        public global::G.LanguageIdentificationResultError? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageIdentificationResult" /> class.
        /// </summary>
        /// <param name="results"></param>
        /// <param name="error"></param>
        /// <param name="message"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LanguageIdentificationResult(
            global::System.Collections.Generic.IList<global::G.LanguageIdentificationResultItem>? results,
            global::G.LanguageIdentificationResultError? error,
            string? message)
        {
            this.Results = results;
            this.Error = error;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageIdentificationResult" /> class.
        /// </summary>
        public LanguageIdentificationResult()
        {
        }
    }
}