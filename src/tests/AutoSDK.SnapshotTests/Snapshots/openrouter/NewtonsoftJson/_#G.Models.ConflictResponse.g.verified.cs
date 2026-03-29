//HintName: G.Models.ConflictResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Conflict - Resource conflict or concurrent modification
    /// </summary>
    public sealed partial class ConflictResponse
    {
        /// <summary>
        /// Error data for ConflictResponse
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ConflictResponseErrorData Error { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="ConflictResponse" /> class.
        /// </summary>
        /// <param name="error">
        /// Error data for ConflictResponse
        /// </param>
        /// <param name="userId"></param>
        public ConflictResponse(
            global::G.ConflictResponseErrorData error,
            string? userId)
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConflictResponse" /> class.
        /// </summary>
        public ConflictResponse()
        {
        }
    }
}