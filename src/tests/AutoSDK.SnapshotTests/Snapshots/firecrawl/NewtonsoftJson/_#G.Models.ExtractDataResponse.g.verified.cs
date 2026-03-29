//HintName: G.Models.ExtractDataResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExtractDataResponse
    {
        /// <summary>
        /// Example: Invalid input data.
        /// </summary>
        /// <example>Invalid input data.</example>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractDataResponse" /> class.
        /// </summary>
        /// <param name="error">
        /// Example: Invalid input data.
        /// </param>
        public ExtractDataResponse(
            string? error)
        {
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractDataResponse" /> class.
        /// </summary>
        public ExtractDataResponse()
        {
        }
    }
}