//HintName: G.Models.SystemToolConfigInputParamsDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SystemToolConfigInputParamsDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_tool_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SystemToolConfigInputParamsDiscriminatorSystemToolTypeJsonConverter))]
        public global::G.SystemToolConfigInputParamsDiscriminatorSystemToolType? SystemToolType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemToolConfigInputParamsDiscriminator" /> class.
        /// </summary>
        /// <param name="systemToolType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SystemToolConfigInputParamsDiscriminator(
            global::G.SystemToolConfigInputParamsDiscriminatorSystemToolType? systemToolType)
        {
            this.SystemToolType = systemToolType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemToolConfigInputParamsDiscriminator" /> class.
        /// </summary>
        public SystemToolConfigInputParamsDiscriminator()
        {
        }
    }
}