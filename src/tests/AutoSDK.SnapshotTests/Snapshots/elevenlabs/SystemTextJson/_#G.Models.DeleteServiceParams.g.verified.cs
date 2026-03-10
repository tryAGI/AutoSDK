//HintName: G.Models.DeleteServiceParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Delete an existing service from the system.
    /// </summary>
    public sealed partial class DeleteServiceParams
    {
        /// <summary>
        /// Default Value: delete_service
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("smb_tool_type")]
        public string? SmbToolType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteServiceParams" /> class.
        /// </summary>
        /// <param name="smbToolType">
        /// Default Value: delete_service
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteServiceParams(
            string? smbToolType)
        {
            this.SmbToolType = smbToolType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteServiceParams" /> class.
        /// </summary>
        public DeleteServiceParams()
        {
        }
    }
}