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
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("aliases", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Aliases { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjRemoveAliasesBody" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="aliases"></param>
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