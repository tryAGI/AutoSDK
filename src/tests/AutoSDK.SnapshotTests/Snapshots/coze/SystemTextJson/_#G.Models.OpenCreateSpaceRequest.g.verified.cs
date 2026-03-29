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
        [global::System.Text.Json.Serialization.JsonPropertyName("coze_account_id")]
        public string? CozeAccountId { get; set; }

        /// <summary>
        /// 空间描述
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 空间图标，通过上传接口https://www.coze.cn/open/docs/developer_guides/upload_files，未指定文件ID则使用默认头像
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("icon_file_id")]
        public string? IconFileId { get; set; }

        /// <summary>
        /// 空间名称
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 空间所有者id，不传则为当前用户
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner_uid")]
        public string? OwnerUid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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