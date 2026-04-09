//HintName: G.Models.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant6.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant6
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("authScheme")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant6AuthSchemeJsonConverter))]
        public global::G.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant6AuthScheme AuthScheme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("toolkitSlug", Required = global::Newtonsoft.Json.Required.Always)]
        public string ToolkitSlug { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("val", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant6Val Val { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant6" /> class.
        /// </summary>
        /// <param name="toolkitSlug"></param>
        /// <param name="val"></param>
        /// <param name="authScheme"></param>
        public PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant6(
            string toolkitSlug,
            global::G.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant6Val val,
            global::G.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant6AuthScheme authScheme)
        {
            this.AuthScheme = authScheme;
            this.ToolkitSlug = toolkitSlug ?? throw new global::System.ArgumentNullException(nameof(toolkitSlug));
            this.Val = val ?? throw new global::System.ArgumentNullException(nameof(val));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant6" /> class.
        /// </summary>
        public PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant6()
        {
        }
    }
}