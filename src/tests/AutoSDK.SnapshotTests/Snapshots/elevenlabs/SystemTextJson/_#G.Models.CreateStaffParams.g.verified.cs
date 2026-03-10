//HintName: G.Models.CreateStaffParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Create a new staff member in the system.
    /// </summary>
    public sealed partial class CreateStaffParams
    {
        /// <summary>
        /// Default Value: create_staff
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("smb_tool_type")]
        public string? SmbToolType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateStaffParams" /> class.
        /// </summary>
        /// <param name="smbToolType">
        /// Default Value: create_staff
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateStaffParams(
            string? smbToolType)
        {
            this.SmbToolType = smbToolType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateStaffParams" /> class.
        /// </summary>
        public CreateStaffParams()
        {
        }
    }
}