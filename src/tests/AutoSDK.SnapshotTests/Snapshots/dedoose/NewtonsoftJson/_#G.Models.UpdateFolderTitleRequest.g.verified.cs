﻿//HintName: G.Models.UpdateFolderTitleRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateFolderTitleRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projectId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("folderId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid FolderId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFolderTitleRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="folderId"></param>
        /// <param name="title"></param>
        public UpdateFolderTitleRequest(
            global::System.Guid projectId,
            global::System.Guid folderId,
            string title)
        {
            this.ProjectId = projectId;
            this.FolderId = folderId;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFolderTitleRequest" /> class.
        /// </summary>
        public UpdateFolderTitleRequest()
        {
        }
    }
}