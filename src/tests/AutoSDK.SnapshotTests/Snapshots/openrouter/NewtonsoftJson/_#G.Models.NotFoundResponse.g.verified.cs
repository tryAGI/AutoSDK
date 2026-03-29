//HintName: G.Models.NotFoundResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Not Found - Resource does not exist
    /// </summary>
    public sealed partial class NotFoundResponse
    {
        /// <summary>
        /// Error data for NotFoundResponse
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.NotFoundResponseErrorData Error { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NotFoundResponse" /> class.
        /// </summary>
        /// <param name="error">
        /// Error data for NotFoundResponse
        /// </param>
        /// <param name="userId"></param>
        public NotFoundResponse(
            global::G.NotFoundResponseErrorData error,
            string? userId)
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotFoundResponse" /> class.
        /// </summary>
        public NotFoundResponse()
        {
        }
    }
}