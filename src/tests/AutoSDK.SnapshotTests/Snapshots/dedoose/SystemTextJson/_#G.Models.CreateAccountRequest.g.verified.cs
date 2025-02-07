//HintName: G.Models.CreateAccountRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAccountRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("adminId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid AdminId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Credits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAccountRequest" /> class.
        /// </summary>
        /// <param name="adminId"></param>
        /// <param name="credits"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAccountRequest(
            global::System.Guid adminId,
            double credits)
        {
            this.AdminId = adminId;
            this.Credits = credits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAccountRequest" /> class.
        /// </summary>
        public CreateAccountRequest()
        {
        }
    }
}