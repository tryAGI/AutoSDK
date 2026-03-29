//HintName: G.Models.AddFollowupResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddFollowupResponse
    {
        /// <summary>
        /// Unique identifier for the cloud agent<br/>
        /// Example: bc_abc123
        /// </summary>
        /// <example>bc_abc123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddFollowupResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the cloud agent<br/>
        /// Example: bc_abc123
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddFollowupResponse(
            string id)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddFollowupResponse" /> class.
        /// </summary>
        public AddFollowupResponse()
        {
        }
    }
}