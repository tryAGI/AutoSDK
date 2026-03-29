//HintName: G.Models.WorkspaceDefaults.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkspaceDefaults
    {
        /// <summary>
        /// Example: {"foo":"bar"}
        /// </summary>
        /// <example>{"foo":"bar"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_default")]
        public int? IsDefault { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WorkspaceDefaultsObjectJsonConverter))]
        public global::G.WorkspaceDefaultsObject? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceDefaults" /> class.
        /// </summary>
        /// <param name="metadata">
        /// Example: {"foo":"bar"}
        /// </param>
        /// <param name="isDefault">
        /// Example: 0
        /// </param>
        /// <param name="object"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkspaceDefaults(
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            int? isDefault,
            global::G.WorkspaceDefaultsObject? @object)
        {
            this.Metadata = metadata;
            this.IsDefault = isDefault;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceDefaults" /> class.
        /// </summary>
        public WorkspaceDefaults()
        {
        }
    }
}