//HintName: G.Models.UpdateFieldOrdersRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateFieldOrdersRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projectId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fields", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.FieldVO> Fields { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFieldOrdersRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="fields"></param>
        public UpdateFieldOrdersRequest(
            global::System.Guid projectId,
            global::System.Collections.Generic.IList<global::G.FieldVO> fields)
        {
            this.ProjectId = projectId;
            this.Fields = fields ?? throw new global::System.ArgumentNullException(nameof(fields));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFieldOrdersRequest" /> class.
        /// </summary>
        public UpdateFieldOrdersRequest()
        {
        }
    }
}