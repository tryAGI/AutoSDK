//HintName: G.Models.UserForUpdateFirebaseTokenRequestDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserForUpdateFirebaseTokenRequestDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public long? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("firebaseNotificationToken")]
        public string? FirebaseNotificationToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserForUpdateFirebaseTokenRequestDto" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="firebaseNotificationToken"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserForUpdateFirebaseTokenRequestDto(
            long? id,
            string? firebaseNotificationToken)
        {
            this.Id = id;
            this.FirebaseNotificationToken = firebaseNotificationToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserForUpdateFirebaseTokenRequestDto" /> class.
        /// </summary>
        public UserForUpdateFirebaseTokenRequestDto()
        {
        }
    }
}