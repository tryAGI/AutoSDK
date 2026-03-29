//HintName: G.Models.ServiceProviderConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ServiceProviderConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schemas")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Schemas { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documentationUri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DocumentationUri { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("patch")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ScimFeatureSupport Patch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bulk")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.BulkConfig Bulk { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.FilterConfig Filter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("changePassword")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ScimFeatureSupport ChangePassword { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sort")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ScimFeatureSupport Sort { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("etag")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ScimFeatureSupport Etag { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authenticationSchemes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.AuthenticationScheme> AuthenticationSchemes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ResourceMeta Meta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceProviderConfig" /> class.
        /// </summary>
        /// <param name="schemas"></param>
        /// <param name="documentationUri"></param>
        /// <param name="patch"></param>
        /// <param name="bulk"></param>
        /// <param name="filter"></param>
        /// <param name="changePassword"></param>
        /// <param name="sort"></param>
        /// <param name="etag"></param>
        /// <param name="authenticationSchemes"></param>
        /// <param name="meta"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ServiceProviderConfig(
            global::System.Collections.Generic.IList<string> schemas,
            string documentationUri,
            global::G.ScimFeatureSupport patch,
            global::G.BulkConfig bulk,
            global::G.FilterConfig filter,
            global::G.ScimFeatureSupport changePassword,
            global::G.ScimFeatureSupport sort,
            global::G.ScimFeatureSupport etag,
            global::System.Collections.Generic.IList<global::G.AuthenticationScheme> authenticationSchemes,
            global::G.ResourceMeta meta)
        {
            this.Schemas = schemas ?? throw new global::System.ArgumentNullException(nameof(schemas));
            this.DocumentationUri = documentationUri ?? throw new global::System.ArgumentNullException(nameof(documentationUri));
            this.Patch = patch ?? throw new global::System.ArgumentNullException(nameof(patch));
            this.Bulk = bulk ?? throw new global::System.ArgumentNullException(nameof(bulk));
            this.Filter = filter ?? throw new global::System.ArgumentNullException(nameof(filter));
            this.ChangePassword = changePassword ?? throw new global::System.ArgumentNullException(nameof(changePassword));
            this.Sort = sort ?? throw new global::System.ArgumentNullException(nameof(sort));
            this.Etag = etag ?? throw new global::System.ArgumentNullException(nameof(etag));
            this.AuthenticationSchemes = authenticationSchemes ?? throw new global::System.ArgumentNullException(nameof(authenticationSchemes));
            this.Meta = meta ?? throw new global::System.ArgumentNullException(nameof(meta));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceProviderConfig" /> class.
        /// </summary>
        public ServiceProviderConfig()
        {
        }
    }
}