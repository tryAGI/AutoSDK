//HintName: G.Models.CreateExtractResponseFailedResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateExtractResponseFailedResult
    {
        /// <summary>
        /// The URL that failed to be processed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// An error message describing why the URL couldn't be processed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateExtractResponseFailedResult" /> class.
        /// </summary>
        /// <param name="url">
        /// The URL that failed to be processed.
        /// </param>
        /// <param name="error">
        /// An error message describing why the URL couldn't be processed.
        /// </param>
        public CreateExtractResponseFailedResult(
            string? url,
            string? error)
        {
            this.Url = url;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateExtractResponseFailedResult" /> class.
        /// </summary>
        public CreateExtractResponseFailedResult()
        {
        }
    }
}