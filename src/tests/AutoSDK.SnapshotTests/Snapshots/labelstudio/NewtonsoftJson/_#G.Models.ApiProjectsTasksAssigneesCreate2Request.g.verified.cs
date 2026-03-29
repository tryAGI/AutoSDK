//HintName: G.Models.ApiProjectsTasksAssigneesCreate2Request.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiProjectsTasksAssigneesCreate2Request
    {
        /// <summary>
        /// Assignment type. Use AN for annotate or RE for review.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ApiProjectsTasksAssigneesCreate2RequestType Type { get; set; } = default!;

        /// <summary>
        /// List of user IDs to assign
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("users", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<int> Users { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectsTasksAssigneesCreate2Request" /> class.
        /// </summary>
        /// <param name="type">
        /// Assignment type. Use AN for annotate or RE for review.
        /// </param>
        /// <param name="users">
        /// List of user IDs to assign
        /// </param>
        public ApiProjectsTasksAssigneesCreate2Request(
            global::G.ApiProjectsTasksAssigneesCreate2RequestType type,
            global::System.Collections.Generic.IList<int> users)
        {
            this.Type = type;
            this.Users = users ?? throw new global::System.ArgumentNullException(nameof(users));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectsTasksAssigneesCreate2Request" /> class.
        /// </summary>
        public ApiProjectsTasksAssigneesCreate2Request()
        {
        }
    }
}