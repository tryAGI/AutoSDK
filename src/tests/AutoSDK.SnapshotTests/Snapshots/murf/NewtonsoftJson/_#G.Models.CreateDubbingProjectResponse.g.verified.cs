//HintName: G.Models.CreateDubbingProjectResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDubbingProjectResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error_code")]
        public int? ErrorCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDubbingProjectResponse" /> class.
        /// </summary>
        /// <param name="errorMessage"></param>
        /// <param name="errorCode"></param>
        public CreateDubbingProjectResponse(
            string? errorMessage,
            int? errorCode)
        {
            this.ErrorMessage = errorMessage;
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDubbingProjectResponse" /> class.
        /// </summary>
        public CreateDubbingProjectResponse()
        {
        }
    }
}