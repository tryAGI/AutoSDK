//HintName: G.Models.ApiProjectsTasksAssigneesPartialUpdateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiProjectsTasksAssigneesPartialUpdateRequest
    {
        /// <summary>
        /// Assignment type. Use AN for annotate or RE for review.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ApiProjectsTasksAssigneesPartialUpdateRequestTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ApiProjectsTasksAssigneesPartialUpdateRequestType Type { get; set; }

        /// <summary>
        /// List of user IDs to assign
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("users")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> Users { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectsTasksAssigneesPartialUpdateRequest" /> class.
        /// </summary>
        /// <param name="type">
        /// Assignment type. Use AN for annotate or RE for review.
        /// </param>
        /// <param name="users">
        /// List of user IDs to assign
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiProjectsTasksAssigneesPartialUpdateRequest(
            global::G.ApiProjectsTasksAssigneesPartialUpdateRequestType type,
            global::System.Collections.Generic.IList<int> users)
        {
            this.Type = type;
            this.Users = users ?? throw new global::System.ArgumentNullException(nameof(users));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectsTasksAssigneesPartialUpdateRequest" /> class.
        /// </summary>
        public ApiProjectsTasksAssigneesPartialUpdateRequest()
        {
        }
    }
}