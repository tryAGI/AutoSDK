//HintName: G.Models.ObjRemoveAliasesBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request body for removing aliases (object_id comes from path).
    /// </summary>
    public sealed partial class ObjRemoveAliasesBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aliases")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Aliases { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjRemoveAliasesBody" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="aliases"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ObjRemoveAliasesBody(
            string projectId,
            global::System.Collections.Generic.IList<string> aliases)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Aliases = aliases ?? throw new global::System.ArgumentNullException(nameof(aliases));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjRemoveAliasesBody" /> class.
        /// </summary>
        public ObjRemoveAliasesBody()
        {
        }
    }
}