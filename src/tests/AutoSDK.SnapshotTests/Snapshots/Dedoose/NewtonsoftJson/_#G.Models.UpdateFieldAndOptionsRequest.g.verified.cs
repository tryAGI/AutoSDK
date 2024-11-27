//HintName: G.Models.UpdateFieldAndOptionsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateFieldAndOptionsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projectId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fieldId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid FieldId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("options", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.FieldOptionVO> Options { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deletedOptionIds", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::System.Guid> DeletedOptionIds { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFieldAndOptionsRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="fieldId"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="options"></param>
        /// <param name="deletedOptionIds"></param>
        public UpdateFieldAndOptionsRequest(
            global::System.Guid projectId,
            global::System.Guid fieldId,
            string title,
            string description,
            global::System.Collections.Generic.IList<global::G.FieldOptionVO> options,
            global::System.Collections.Generic.IList<global::System.Guid> deletedOptionIds)
        {
            this.ProjectId = projectId;
            this.FieldId = fieldId;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            this.DeletedOptionIds = deletedOptionIds ?? throw new global::System.ArgumentNullException(nameof(deletedOptionIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFieldAndOptionsRequest" /> class.
        /// </summary>
        public UpdateFieldAndOptionsRequest()
        {
        }
    }
}