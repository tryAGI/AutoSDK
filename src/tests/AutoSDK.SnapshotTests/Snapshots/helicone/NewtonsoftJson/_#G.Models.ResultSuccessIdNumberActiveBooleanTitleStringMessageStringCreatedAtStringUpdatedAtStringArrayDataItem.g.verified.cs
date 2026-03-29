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
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string UpdatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("active", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Active { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public double Id { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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