//HintName: G.Models.ExtractResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExtractResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("success")]
        public bool? Success { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// If ignoreInvalidURLs is true, this is an array containing the invalid URLs that were specified in the request. If there were no invalid URLs, this will be an empty array. If ignoreInvalidURLs is false, this field will be undefined.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("invalidURLs")]
        public global::System.Collections.Generic.IList<string>? InvalidURLs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="id"></param>
        /// <param name="invalidURLs">
        /// If ignoreInvalidURLs is true, this is an array containing the invalid URLs that were specified in the request. If there were no invalid URLs, this will be an empty array. If ignoreInvalidURLs is false, this field will be undefined.
        /// </param>
        public ExtractResponse(
            bool? success,
            string? id,
            global::System.Collections.Generic.IList<string>? invalidURLs)
        {
            this.Success = success;
            this.Id = id;
            this.InvalidURLs = invalidURLs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractResponse" /> class.
        /// </summary>
        public ExtractResponse()
        {
        }
    }
}