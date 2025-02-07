//HintName: G.Models.AddProjectEncryptedByUserRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddProjectEncryptedByUserRequest
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
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("decription")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Decription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("symKeyHash")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SymKeyHash { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddProjectEncryptedByUserRequest" /> class.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="title"></param>
        /// <param name="decription"></param>
        /// <param name="symKeyHash"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddProjectEncryptedByUserRequest(
            global::System.Guid userId,
            string title,
            string decription,
            string symKeyHash)
        {
            this.UserId = userId;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Decription = decription ?? throw new global::System.ArgumentNullException(nameof(decription));
            this.SymKeyHash = symKeyHash ?? throw new global::System.ArgumentNullException(nameof(symKeyHash));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddProjectEncryptedByUserRequest" /> class.
        /// </summary>
        public AddProjectEncryptedByUserRequest()
        {
        }
    }
}