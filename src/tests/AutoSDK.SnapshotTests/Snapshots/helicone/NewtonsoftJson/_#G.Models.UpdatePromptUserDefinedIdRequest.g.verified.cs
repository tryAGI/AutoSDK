//HintName: G.Models.UpdatePromptUserDefinedIdRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdatePromptUserDefinedIdRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("userDefinedId", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserDefinedId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePromptUserDefinedIdRequest" /> class.
        /// </summary>
        /// <param name="userDefinedId"></param>
        public UpdatePromptUserDefinedIdRequest(
            string userDefinedId)
        {
            this.UserDefinedId = userDefinedId ?? throw new global::System.ArgumentNullException(nameof(userDefinedId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePromptUserDefinedIdRequest" /> class.
        /// </summary>
        public UpdatePromptUserDefinedIdRequest()
        {
        }
    }
}