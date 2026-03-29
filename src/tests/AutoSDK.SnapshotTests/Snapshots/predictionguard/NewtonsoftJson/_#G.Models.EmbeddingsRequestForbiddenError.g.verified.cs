//HintName: G.Models.EmbeddingsRequestForbiddenError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmbeddingsRequestForbiddenError
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
        /// Initializes a new instance of the <see cref="EmbeddingsRequestForbiddenError" /> class.
        /// </summary>
        /// <param name="error">
        /// Description of the error.
        /// </param>
        public EmbeddingsRequestForbiddenError(
            string? error)
        {
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingsRequestForbiddenError" /> class.
        /// </summary>
        public EmbeddingsRequestForbiddenError()
        {
        }
    }
}