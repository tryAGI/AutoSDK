//HintName: G.Models.RetryFilesResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RetryFilesResponse
    {
        /// <summary>
        /// Indicates whether the retry operation was successful.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("success")]
        public bool? Success { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RetryFilesResponse" /> class.
        /// </summary>
        /// <param name="success">
        /// Indicates whether the retry operation was successful.
        /// </param>
        public RetryFilesResponse(
            bool? success)
        {
            this.Success = success;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RetryFilesResponse" /> class.
        /// </summary>
        public RetryFilesResponse()
        {
        }
    }
}