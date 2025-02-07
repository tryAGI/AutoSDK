//HintName: G.Models.AddProjectByUserRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddProjectByUserRequest
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddProjectByUserRequest" /> class.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="title"></param>
        /// <param name="decription"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddProjectByUserRequest(
            global::System.Guid userId,
            string title,
            string decription)
        {
            this.UserId = userId;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Decription = decription ?? throw new global::System.ArgumentNullException(nameof(decription));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddProjectByUserRequest" /> class.
        /// </summary>
        public AddProjectByUserRequest()
        {
        }
    }
}