//HintName: G.Models.CreateChatLogsRequestVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateChatLogsRequestVariant2
    {
        /// <summary>
        /// Pagination - used to continue the creation of the chat log using this same endpoint
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        public string? Token { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatLogsRequestVariant2" /> class.
        /// </summary>
        /// <param name="token">
        /// Pagination - used to continue the creation of the chat log using this same endpoint
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateChatLogsRequestVariant2(
            string? token)
        {
            this.Token = token;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatLogsRequestVariant2" /> class.
        /// </summary>
        public CreateChatLogsRequestVariant2()
        {
        }
    }
}