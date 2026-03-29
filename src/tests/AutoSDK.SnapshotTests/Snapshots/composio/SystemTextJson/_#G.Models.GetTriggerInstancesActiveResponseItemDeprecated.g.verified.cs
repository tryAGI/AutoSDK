//HintName: G.Models.GetTriggerInstancesActiveResponseItemDeprecated.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Deprecated fields for the trigger instance
    /// </summary>
    public sealed partial class GetTriggerInstancesActiveResponseItemDeprecated
    {
        /// <summary>
        /// Deprecated created_at for the trigger instance
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTriggerInstancesActiveResponseItemDeprecated" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// Deprecated created_at for the trigger instance
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetTriggerInstancesActiveResponseItemDeprecated(
            string createdAt)
        {
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTriggerInstancesActiveResponseItemDeprecated" /> class.
        /// </summary>
        public GetTriggerInstancesActiveResponseItemDeprecated()
        {
        }
    }
}