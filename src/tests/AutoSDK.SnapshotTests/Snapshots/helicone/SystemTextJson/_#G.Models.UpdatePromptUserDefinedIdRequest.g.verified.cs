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
        [global::System.Text.Json.Serialization.JsonPropertyName("userDefinedId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserDefinedId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePromptUserDefinedIdRequest" /> class.
        /// </summary>
        /// <param name="userDefinedId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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