//HintName: G.Models.ConfigurablePermissionOption.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConfigurablePermissionOption
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.Role9e7Enum> Default { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group")]
        public string? Group { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.Role9e7Enum> Options { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permission")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Permission { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tooltip")]
        public string? Tooltip { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurablePermissionOption" /> class.
        /// </summary>
        /// <param name="default"></param>
        /// <param name="options"></param>
        /// <param name="permission"></param>
        /// <param name="group"></param>
        /// <param name="label"></param>
        /// <param name="tooltip"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConfigurablePermissionOption(
            global::System.Collections.Generic.IList<global::G.Role9e7Enum> @default,
            global::System.Collections.Generic.IList<global::G.Role9e7Enum> options,
            string permission,
            string? group,
            string? label,
            string? tooltip)
        {
            this.Default = @default ?? throw new global::System.ArgumentNullException(nameof(@default));
            this.Group = group;
            this.Label = label;
            this.Options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            this.Permission = permission ?? throw new global::System.ArgumentNullException(nameof(permission));
            this.Tooltip = tooltip;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurablePermissionOption" /> class.
        /// </summary>
        public ConfigurablePermissionOption()
        {
        }
    }
}