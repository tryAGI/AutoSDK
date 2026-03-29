//HintName: G.Models.CreateGlossaryResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateGlossaryResponse
    {
        /// <summary>
        /// Generic description of the error.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// More specific description of the error.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("detail")]
        public string? Detail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGlossaryResponse" /> class.
        /// </summary>
        /// <param name="message">
        /// Generic description of the error.
        /// </param>
        /// <param name="detail">
        /// More specific description of the error.
        /// </param>
        public CreateGlossaryResponse(
            string? message,
            string? detail)
        {
            this.Message = message;
            this.Detail = detail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGlossaryResponse" /> class.
        /// </summary>
        public CreateGlossaryResponse()
        {
        }
    }
}