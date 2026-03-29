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
        [global::System.Text.Json.Serialization.JsonPropertyName("authScheme")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant6AuthSchemeJsonConverter))]
        public global::G.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant6AuthScheme AuthScheme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolkitSlug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolkitSlug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("val")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant6Val Val { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant6" /> class.
        /// </summary>
        /// <param name="toolkitSlug"></param>
        /// <param name="val"></param>
        /// <param name="authScheme"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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