//HintName: G.Models.SMBToolConfigParamsDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SMBToolConfigParamsDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("smb_tool_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SMBToolConfigParamsDiscriminatorSmbToolTypeJsonConverter))]
        public global::G.SMBToolConfigParamsDiscriminatorSmbToolType? SmbToolType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SMBToolConfigParamsDiscriminator" /> class.
        /// </summary>
        /// <param name="smbToolType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SMBToolConfigParamsDiscriminator(
            global::G.SMBToolConfigParamsDiscriminatorSmbToolType? smbToolType)
        {
            this.SmbToolType = smbToolType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SMBToolConfigParamsDiscriminator" /> class.
        /// </summary>
        public SMBToolConfigParamsDiscriminator()
        {
        }
    }
}