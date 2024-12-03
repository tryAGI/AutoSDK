//HintName: G.Models.AddDataSetRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddDataSetRequest
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
        [global::Newtonsoft.Json.JsonProperty("areExcerptsFiltered", Required = global::Newtonsoft.Json.Required.Always)]
        public bool AreExcerptsFiltered { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("areResourcesFiltered", Required = global::Newtonsoft.Json.Required.Always)]
        public bool AreResourcesFiltered { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("areDescriptorsFiltered", Required = global::Newtonsoft.Json.Required.Always)]
        public bool AreDescriptorsFiltered { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("areTagsFiltered", Required = global::Newtonsoft.Json.Required.Always)]
        public bool AreTagsFiltered { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("areUsersFiltered", Required = global::Newtonsoft.Json.Required.Always)]
        public bool AreUsersFiltered { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("excerptIds", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::System.Guid> ExcerptIds { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("descriptorIds", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::System.Guid> DescriptorIds { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("userIds", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::System.Guid> UserIds { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("resourceIds", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::System.Guid> ResourceIds { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tagIds", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::System.Guid> TagIds { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("excludedExcerptIds", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::System.Guid> ExcludedExcerptIds { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddDataSetRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="areExcerptsFiltered"></param>
        /// <param name="areResourcesFiltered"></param>
        /// <param name="areDescriptorsFiltered"></param>
        /// <param name="areTagsFiltered"></param>
        /// <param name="areUsersFiltered"></param>
        /// <param name="excerptIds"></param>
        /// <param name="descriptorIds"></param>
        /// <param name="userIds"></param>
        /// <param name="resourceIds"></param>
        /// <param name="tagIds"></param>
        /// <param name="excludedExcerptIds"></param>
        public AddDataSetRequest(
            global::System.Guid projectId,
            global::System.Guid userId,
            string title,
            string description,
            bool areExcerptsFiltered,
            bool areResourcesFiltered,
            bool areDescriptorsFiltered,
            bool areTagsFiltered,
            bool areUsersFiltered,
            global::System.Collections.Generic.IList<global::System.Guid> excerptIds,
            global::System.Collections.Generic.IList<global::System.Guid> descriptorIds,
            global::System.Collections.Generic.IList<global::System.Guid> userIds,
            global::System.Collections.Generic.IList<global::System.Guid> resourceIds,
            global::System.Collections.Generic.IList<global::System.Guid> tagIds,
            global::System.Collections.Generic.IList<global::System.Guid> excludedExcerptIds)
        {
            this.ProjectId = projectId;
            this.UserId = userId;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.AreExcerptsFiltered = areExcerptsFiltered;
            this.AreResourcesFiltered = areResourcesFiltered;
            this.AreDescriptorsFiltered = areDescriptorsFiltered;
            this.AreTagsFiltered = areTagsFiltered;
            this.AreUsersFiltered = areUsersFiltered;
            this.ExcerptIds = excerptIds ?? throw new global::System.ArgumentNullException(nameof(excerptIds));
            this.DescriptorIds = descriptorIds ?? throw new global::System.ArgumentNullException(nameof(descriptorIds));
            this.UserIds = userIds ?? throw new global::System.ArgumentNullException(nameof(userIds));
            this.ResourceIds = resourceIds ?? throw new global::System.ArgumentNullException(nameof(resourceIds));
            this.TagIds = tagIds ?? throw new global::System.ArgumentNullException(nameof(tagIds));
            this.ExcludedExcerptIds = excludedExcerptIds ?? throw new global::System.ArgumentNullException(nameof(excludedExcerptIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddDataSetRequest" /> class.
        /// </summary>
        public AddDataSetRequest()
        {
        }
    }
}