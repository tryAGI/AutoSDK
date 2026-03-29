//HintName: G.Models.CompletionsRequestForbiddenError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CompletionsRequestForbiddenError
    {
        /// <summary>
        /// Description of the error.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionsRequestForbiddenError" /> class.
        /// </summary>
        /// <param name="error">
        /// Description of the error.
        /// </param>
        public CompletionsRequestForbiddenError(
            string? error)
        {
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionsRequestForbiddenError" /> class.
        /// </summary>
        public CompletionsRequestForbiddenError()
        {
        }
    }
}