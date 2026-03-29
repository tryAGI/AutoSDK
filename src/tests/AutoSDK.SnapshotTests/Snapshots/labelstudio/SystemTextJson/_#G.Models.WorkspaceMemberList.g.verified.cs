//HintName: G.Models.WorkspaceMemberList.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkspaceMemberList
    {
        /// <summary>
        /// A ModelSerializer that takes additional arguments for<br/>
        /// "fields", "omit" and "expand" in order to<br/>
        /// control which fields are displayed, and whether to replace simple<br/>
        /// values with complex, nested serializations
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.LseUser User { get; set; }

        /// <summary>
        /// Workspace ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace")]
        public int? Workspace { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceMemberList" /> class.
        /// </summary>
        /// <param name="user">
        /// A ModelSerializer that takes additional arguments for<br/>
        /// "fields", "omit" and "expand" in order to<br/>
        /// control which fields are displayed, and whether to replace simple<br/>
        /// values with complex, nested serializations
        /// </param>
        /// <param name="workspace">
        /// Workspace ID
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkspaceMemberList(
            global::G.LseUser user,
            int? workspace)
        {
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
            this.Workspace = workspace;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceMemberList" /> class.
        /// </summary>
        public WorkspaceMemberList()
        {
        }
    }
}