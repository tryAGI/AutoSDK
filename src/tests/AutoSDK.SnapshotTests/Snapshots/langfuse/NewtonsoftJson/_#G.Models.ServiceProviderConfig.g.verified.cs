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
        [global::Newtonsoft.Json.JsonProperty("schemas", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Schemas { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("documentationUri", Required = global::Newtonsoft.Json.Required.Always)]
        public string DocumentationUri { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("patch", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ScimFeatureSupport Patch { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bulk", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.BulkConfig Bulk { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filter", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.FilterConfig Filter { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("changePassword", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ScimFeatureSupport ChangePassword { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sort", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ScimFeatureSupport Sort { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("etag", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ScimFeatureSupport Etag { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("authenticationSchemes", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.AuthenticationScheme> AuthenticationSchemes { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("meta", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ResourceMeta Meta { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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