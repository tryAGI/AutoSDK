//HintName: G.Models.ImportFieldsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImportFieldsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projectId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("userId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid UserId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fieldInfos", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.FieldInfo> FieldInfos { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("existingSetId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ExistingSetId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("newSetTitle", Required = global::Newtonsoft.Json.Required.Always)]
        public string NewSetTitle { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportFieldsRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="fieldInfos"></param>
        /// <param name="existingSetId"></param>
        /// <param name="newSetTitle"></param>
        public ImportFieldsRequest(
            global::System.Guid projectId,
            global::System.Guid userId,
            global::System.Collections.Generic.IList<global::G.FieldInfo> fieldInfos,
            global::System.Guid existingSetId,
            string newSetTitle)
        {
            this.ProjectId = projectId;
            this.UserId = userId;
            this.FieldInfos = fieldInfos ?? throw new global::System.ArgumentNullException(nameof(fieldInfos));
            this.ExistingSetId = existingSetId;
            this.NewSetTitle = newSetTitle ?? throw new global::System.ArgumentNullException(nameof(newSetTitle));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportFieldsRequest" /> class.
        /// </summary>
        public ImportFieldsRequest()
        {
        }
    }
}