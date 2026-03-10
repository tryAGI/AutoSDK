//HintName: G.Models.SoftTimeoutConfigOverride.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"message":"Hhmmmm...yeah."}
    /// </summary>
    public sealed partial class SoftTimeoutConfigOverride
    {
        /// <summary>
        /// Message to show when soft timeout is reached while waiting for LLM response
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SoftTimeoutConfigOverride" /> class.
        /// </summary>
        /// <param name="message">
        /// Message to show when soft timeout is reached while waiting for LLM response
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SoftTimeoutConfigOverride(
            string? message)
        {
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SoftTimeoutConfigOverride" /> class.
        /// </summary>
        public SoftTimeoutConfigOverride()
        {
        }
    }
}