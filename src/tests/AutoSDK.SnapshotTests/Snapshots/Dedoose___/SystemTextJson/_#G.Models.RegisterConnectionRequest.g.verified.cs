//HintName: G.Models.RegisterConnectionRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RegisterConnectionRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectionKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ConnectionKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterConnectionRequest" /> class.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="connectionKey"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RegisterConnectionRequest(
            global::System.Guid userId,
            global::System.Guid connectionKey)
        {
            this.UserId = userId;
            this.ConnectionKey = connectionKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterConnectionRequest" /> class.
        /// </summary>
        public RegisterConnectionRequest()
        {
        }
    }
}