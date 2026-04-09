//HintName: G.Models.GetSessionPaginatedDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetSessionPaginatedDTO
    {
        /// <summary>
        /// This is the unique identifier for the session to filter by.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// This is the name of the session to filter by.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// This is the ID of the assistant to filter sessions by.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assistantId")]
        public string? AssistantId { get; set; }

        /// <summary>
        /// Filter by multiple assistant IDs. Provide as comma-separated values.<br/>
        /// Example: assistant-1,assistant-2,assistant-3
        /// </summary>
        /// <example>assistant-1,assistant-2,assistant-3</example>
        [global::Newtonsoft.Json.JsonProperty("assistantIdAny")]
        public string? AssistantIdAny { get; set; }

        /// <summary>
        /// This is the ID of the squad to filter sessions by.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("squadId")]
        public string? SquadId { get; set; }

        /// <summary>
        /// This is the ID of the workflow to filter sessions by.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workflowId")]
        public string? WorkflowId { get; set; }

        /// <summary>
        /// This is the customer information to filter by.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("customer")]
        public global::G.CreateCustomerDTO? Customer { get; set; }

        /// <summary>
        /// Filter by any of the specified customer phone numbers (comma-separated).<br/>
        /// Example: +1234567890,+0987654321
        /// </summary>
        /// <example>+1234567890,+0987654321</example>
        [global::Newtonsoft.Json.JsonProperty("customerNumberAny")]
        public string? CustomerNumberAny { get; set; }

        /// <summary>
        /// This will return sessions with the specified phoneNumberId.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("phoneNumberId")]
        public string? PhoneNumberId { get; set; }

        /// <summary>
        /// This will return sessions with any of the specified phoneNumberIds.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("phoneNumberIdAny")]
        public global::System.Collections.Generic.IList<string>? PhoneNumberIdAny { get; set; }

        /// <summary>
        /// This is the page number to return. Defaults to 1.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page")]
        public double? Page { get; set; }

        /// <summary>
        /// This is the sort order for pagination. Defaults to 'DESC'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sortOrder")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.GetSessionPaginatedDTOSortOrderJsonConverter))]
        public global::G.GetSessionPaginatedDTOSortOrder? SortOrder { get; set; }

        /// <summary>
        /// This is the maximum number of items to return. Defaults to 100.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit")]
        public double? Limit { get; set; }

        /// <summary>
        /// This will return items where the createdAt is greater than the specified value.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAtGt")]
        public global::System.DateTime? CreatedAtGt { get; set; }

        /// <summary>
        /// This will return items where the createdAt is less than the specified value.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAtLt")]
        public global::System.DateTime? CreatedAtLt { get; set; }

        /// <summary>
        /// This will return items where the createdAt is greater than or equal to the specified value.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAtGe")]
        public global::System.DateTime? CreatedAtGe { get; set; }

        /// <summary>
        /// This will return items where the createdAt is less than or equal to the specified value.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAtLe")]
        public global::System.DateTime? CreatedAtLe { get; set; }

        /// <summary>
        /// This will return items where the updatedAt is greater than the specified value.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updatedAtGt")]
        public global::System.DateTime? UpdatedAtGt { get; set; }

        /// <summary>
        /// This will return items where the updatedAt is less than the specified value.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updatedAtLt")]
        public global::System.DateTime? UpdatedAtLt { get; set; }

        /// <summary>
        /// This will return items where the updatedAt is greater than or equal to the specified value.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updatedAtGe")]
        public global::System.DateTime? UpdatedAtGe { get; set; }

        /// <summary>
        /// This will return items where the updatedAt is less than or equal to the specified value.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updatedAtLe")]
        public global::System.DateTime? UpdatedAtLe { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSessionPaginatedDTO" /> class.
        /// </summary>
        /// <param name="id">
        /// This is the unique identifier for the session to filter by.
        /// </param>
        /// <param name="name">
        /// This is the name of the session to filter by.
        /// </param>
        /// <param name="assistantId">
        /// This is the ID of the assistant to filter sessions by.
        /// </param>
        /// <param name="assistantIdAny">
        /// Filter by multiple assistant IDs. Provide as comma-separated values.<br/>
        /// Example: assistant-1,assistant-2,assistant-3
        /// </param>
        /// <param name="squadId">
        /// This is the ID of the squad to filter sessions by.
        /// </param>
        /// <param name="workflowId">
        /// This is the ID of the workflow to filter sessions by.
        /// </param>
        /// <param name="customer">
        /// This is the customer information to filter by.
        /// </param>
        /// <param name="customerNumberAny">
        /// Filter by any of the specified customer phone numbers (comma-separated).<br/>
        /// Example: +1234567890,+0987654321
        /// </param>
        /// <param name="phoneNumberId">
        /// This will return sessions with the specified phoneNumberId.
        /// </param>
        /// <param name="phoneNumberIdAny">
        /// This will return sessions with any of the specified phoneNumberIds.
        /// </param>
        /// <param name="page">
        /// This is the page number to return. Defaults to 1.
        /// </param>
        /// <param name="sortOrder">
        /// This is the sort order for pagination. Defaults to 'DESC'.
        /// </param>
        /// <param name="limit">
        /// This is the maximum number of items to return. Defaults to 100.
        /// </param>
        /// <param name="createdAtGt">
        /// This will return items where the createdAt is greater than the specified value.
        /// </param>
        /// <param name="createdAtLt">
        /// This will return items where the createdAt is less than the specified value.
        /// </param>
        /// <param name="createdAtGe">
        /// This will return items where the createdAt is greater than or equal to the specified value.
        /// </param>
        /// <param name="createdAtLe">
        /// This will return items where the createdAt is less than or equal to the specified value.
        /// </param>
        /// <param name="updatedAtGt">
        /// This will return items where the updatedAt is greater than the specified value.
        /// </param>
        /// <param name="updatedAtLt">
        /// This will return items where the updatedAt is less than the specified value.
        /// </param>
        /// <param name="updatedAtGe">
        /// This will return items where the updatedAt is greater than or equal to the specified value.
        /// </param>
        /// <param name="updatedAtLe">
        /// This will return items where the updatedAt is less than or equal to the specified value.
        /// </param>
        public GetSessionPaginatedDTO(
            string? id,
            string? name,
            string? assistantId,
            string? assistantIdAny,
            string? squadId,
            string? workflowId,
            global::G.CreateCustomerDTO? customer,
            string? customerNumberAny,
            string? phoneNumberId,
            global::System.Collections.Generic.IList<string>? phoneNumberIdAny,
            double? page,
            global::G.GetSessionPaginatedDTOSortOrder? sortOrder,
            double? limit,
            global::System.DateTime? createdAtGt,
            global::System.DateTime? createdAtLt,
            global::System.DateTime? createdAtGe,
            global::System.DateTime? createdAtLe,
            global::System.DateTime? updatedAtGt,
            global::System.DateTime? updatedAtLt,
            global::System.DateTime? updatedAtGe,
            global::System.DateTime? updatedAtLe)
        {
            this.Id = id;
            this.Name = name;
            this.AssistantId = assistantId;
            this.AssistantIdAny = assistantIdAny;
            this.SquadId = squadId;
            this.WorkflowId = workflowId;
            this.Customer = customer;
            this.CustomerNumberAny = customerNumberAny;
            this.PhoneNumberId = phoneNumberId;
            this.PhoneNumberIdAny = phoneNumberIdAny;
            this.Page = page;
            this.SortOrder = sortOrder;
            this.Limit = limit;
            this.CreatedAtGt = createdAtGt;
            this.CreatedAtLt = createdAtLt;
            this.CreatedAtGe = createdAtGe;
            this.CreatedAtLe = createdAtLe;
            this.UpdatedAtGt = updatedAtGt;
            this.UpdatedAtLt = updatedAtLt;
            this.UpdatedAtGe = updatedAtGe;
            this.UpdatedAtLe = updatedAtLe;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSessionPaginatedDTO" /> class.
        /// </summary>
        public GetSessionPaginatedDTO()
        {
        }
    }
}