//HintName: G.Models.UpdateShieldModeStatusBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateShieldModeStatusBody
    {
        /// <summary>
        /// A Boolean value that determines whether to activate Shield Mode. Set to **true** to activate Shield Mode; otherwise, **false** to deactivate Shield Mode.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_active")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsActive { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateShieldModeStatusBody" /> class.
        /// </summary>
        /// <param name="isActive">
        /// A Boolean value that determines whether to activate Shield Mode. Set to **true** to activate Shield Mode; otherwise, **false** to deactivate Shield Mode.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public UpdateShieldModeStatusBody(
            bool isActive)
        {
            this.IsActive = isActive;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateShieldModeStatusBody" /> class.
        /// </summary>
        public UpdateShieldModeStatusBody()
        {
        }
    }
}