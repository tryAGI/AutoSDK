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
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("areExcerptsFiltered")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AreExcerptsFiltered { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("areResourcesFiltered")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AreResourcesFiltered { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("areDescriptorsFiltered")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AreDescriptorsFiltered { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("areTagsFiltered")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AreTagsFiltered { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("areUsersFiltered")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AreUsersFiltered { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("excerptIds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> ExcerptIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("descriptorIds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> DescriptorIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userIds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> UserIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceIds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> ResourceIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tagIds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> TagIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("excludedExcerptIds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> ExcludedExcerptIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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