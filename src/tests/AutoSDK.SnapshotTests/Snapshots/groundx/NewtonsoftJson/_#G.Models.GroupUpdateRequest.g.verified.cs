//HintName: G.Models.GroupUpdateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GroupUpdateRequest
    {
        /// <summary>
        /// The new name of the group being renamed.<br/>
        /// Example: your_group_name
        /// </summary>
        /// <example>your_group_name</example>
        [global::Newtonsoft.Json.JsonProperty("newName", Required = global::Newtonsoft.Json.Required.Always)]
        public string NewName { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupUpdateRequest" /> class.
        /// </summary>
        /// <param name="newName">
        /// The new name of the group being renamed.<br/>
        /// Example: your_group_name
        /// </param>
        public GroupUpdateRequest(
            string newName)
        {
            this.NewName = newName ?? throw new global::System.ArgumentNullException(nameof(newName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupUpdateRequest" /> class.
        /// </summary>
        public GroupUpdateRequest()
        {
        }
    }
}