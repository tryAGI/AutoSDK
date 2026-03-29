//HintName: G.Models.ScanFileResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScanFileResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScanFileResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="message"></param>
        public ScanFileResponse(
            string? id,
            string? message)
        {
            this.Id = id;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScanFileResponse" /> class.
        /// </summary>
        public ScanFileResponse()
        {
        }
    }
}