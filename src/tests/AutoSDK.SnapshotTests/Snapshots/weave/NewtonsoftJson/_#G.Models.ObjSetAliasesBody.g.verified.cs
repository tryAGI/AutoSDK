//HintName: G.Models.ObjSetAliasesBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request body for setting aliases (object_id comes from path).
    /// </summary>
    public sealed partial class ObjSetAliasesBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("digest", Required = global::Newtonsoft.Json.Required.Always)]
        public string Digest { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="ObjSetAliasesBody" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="digest"></param>
        /// <param name="aliases"></param>
        public ObjSetAliasesBody(
            string projectId,
            string digest,
            global::System.Collections.Generic.IList<string> aliases)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Digest = digest ?? throw new global::System.ArgumentNullException(nameof(digest));
            this.Aliases = aliases ?? throw new global::System.ArgumentNullException(nameof(aliases));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjSetAliasesBody" /> class.
        /// </summary>
        public ObjSetAliasesBody()
        {
        }
    }
}