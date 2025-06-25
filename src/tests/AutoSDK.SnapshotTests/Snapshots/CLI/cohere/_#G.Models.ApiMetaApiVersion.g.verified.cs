﻿//HintName: G.Models.ApiMetaApiVersion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiMetaApiVersion
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_deprecated")]
        public bool? IsDeprecated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_experimental")]
        public bool? IsExperimental { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiMetaApiVersion" /> class.
        /// </summary>
        /// <param name="isDeprecated"></param>
        /// <param name="isExperimental"></param>
        /// <param name="version"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiMetaApiVersion(
            string version,
            bool? isDeprecated,
            bool? isExperimental)
        {
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.IsDeprecated = isDeprecated;
            this.IsExperimental = isExperimental;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiMetaApiVersion" /> class.
        /// </summary>
        public ApiMetaApiVersion()
        {
        }
    }
}