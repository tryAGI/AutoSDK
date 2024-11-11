//HintName: G.Models.UpdateMessageResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateMessageResponse
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public global::G.AppV1alphaMessage? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMessageResponse" /> class.
        /// </summary>
        /// <param name="message">
        /// Included only in responses
        /// </param>
        public UpdateMessageResponse(
            global::G.AppV1alphaMessage? message)
        {
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMessageResponse" /> class.
        /// </summary>
        public UpdateMessageResponse()
        {
        }
    }
}