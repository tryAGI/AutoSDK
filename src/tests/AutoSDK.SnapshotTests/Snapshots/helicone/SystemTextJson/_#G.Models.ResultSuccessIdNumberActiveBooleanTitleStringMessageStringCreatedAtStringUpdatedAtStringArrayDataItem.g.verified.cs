//HintName: G.Models.ResultSuccessIdNumberActiveBooleanTitleStringMessageStringCreatedAtStringUpdatedAtStringArrayDataItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResultSuccessIdNumberActiveBooleanTitleStringMessageStringCreatedAtStringUpdatedAtStringArrayDataItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Active { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessIdNumberActiveBooleanTitleStringMessageStringCreatedAtStringUpdatedAtStringArrayDataItem" /> class.
        /// </summary>
        /// <param name="updatedAt"></param>
        /// <param name="createdAt"></param>
        /// <param name="message"></param>
        /// <param name="title"></param>
        /// <param name="active"></param>
        /// <param name="id"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResultSuccessIdNumberActiveBooleanTitleStringMessageStringCreatedAtStringUpdatedAtStringArrayDataItem(
            string updatedAt,
            string createdAt,
            string message,
            string title,
            bool active,
            double id)
        {
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Active = active;
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessIdNumberActiveBooleanTitleStringMessageStringCreatedAtStringUpdatedAtStringArrayDataItem" /> class.
        /// </summary>
        public ResultSuccessIdNumberActiveBooleanTitleStringMessageStringCreatedAtStringUpdatedAtStringArrayDataItem()
        {
        }
    }
}