//HintName: G.Models.UpdateStaffParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Update an existing staff member's information.
    /// </summary>
    public sealed partial class UpdateStaffParams
    {
        /// <summary>
        /// Default Value: update_staff
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("smb_tool_type")]
        public string? SmbToolType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateStaffParams" /> class.
        /// </summary>
        /// <param name="smbToolType">
        /// Default Value: update_staff
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateStaffParams(
            string? smbToolType)
        {
            this.SmbToolType = smbToolType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateStaffParams" /> class.
        /// </summary>
        public UpdateStaffParams()
        {
        }
    }
}