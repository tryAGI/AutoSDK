//HintName: G.Models.ObjDeleteReq.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ObjDeleteReq
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ObjectId { get; set; } = default!;

        /// <summary>
        /// List of digests to delete. If not provided, all digests for the object will be deleted.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("digests")]
        public global::System.Collections.Generic.IList<string>? Digests { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjDeleteReq" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="objectId"></param>
        /// <param name="digests">
        /// List of digests to delete. If not provided, all digests for the object will be deleted.
        /// </param>
        public ObjDeleteReq(
            string projectId,
            string objectId,
            global::System.Collections.Generic.IList<string>? digests)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.ObjectId = objectId ?? throw new global::System.ArgumentNullException(nameof(objectId));
            this.Digests = digests;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjDeleteReq" /> class.
        /// </summary>
        public ObjDeleteReq()
        {
        }
    }
}