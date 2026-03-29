//HintName: G.Models.OpenCreateSpaceRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenCreateSpaceRequest
    {
        /// <summary>
        /// 组织id
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("coze_account_id")]
        public string? CozeAccountId { get; set; }

        /// <summary>
        /// 空间描述
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// 空间图标，通过上传接口https://www.coze.cn/open/docs/developer_guides/upload_files，未指定文件ID则使用默认头像
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("icon_file_id")]
        public string? IconFileId { get; set; }

        /// <summary>
        /// 空间名称
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 空间所有者id，不传则为当前用户
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("owner_uid")]
        public string? OwnerUid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenCreateSpaceRequest" /> class.
        /// </summary>
        /// <param name="description">
        /// 空间描述
        /// </param>
        /// <param name="name">
        /// 空间名称
        /// </param>
        /// <param name="cozeAccountId">
        /// 组织id
        /// </param>
        /// <param name="iconFileId">
        /// 空间图标，通过上传接口https://www.coze.cn/open/docs/developer_guides/upload_files，未指定文件ID则使用默认头像
        /// </param>
        /// <param name="ownerUid">
        /// 空间所有者id，不传则为当前用户
        /// </param>
        public OpenCreateSpaceRequest(
            string description,
            string name,
            string? cozeAccountId,
            string? iconFileId,
            string? ownerUid)
        {
            this.CozeAccountId = cozeAccountId;
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.IconFileId = iconFileId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.OwnerUid = ownerUid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenCreateSpaceRequest" /> class.
        /// </summary>
        public OpenCreateSpaceRequest()
        {
        }
    }
}