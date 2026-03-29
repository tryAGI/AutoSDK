//HintName: G.Models.ApiMlVersionsRetrieveResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiMlVersionsRetrieveResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("versions")]
        public global::System.Collections.Generic.IList<string>? Versions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiMlVersionsRetrieveResponse" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="versions"></param>
        public ApiMlVersionsRetrieveResponse(
            string? message,
            global::System.Collections.Generic.IList<string>? versions)
        {
            this.Message = message;
            this.Versions = versions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiMlVersionsRetrieveResponse" /> class.
        /// </summary>
        public ApiMlVersionsRetrieveResponse()
        {
        }
    }
}