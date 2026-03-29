//HintName: G.Models.TemplatesLegacyMigrationResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TemplatesLegacyMigrationResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Success { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesLegacyMigrationResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="message"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TemplatesLegacyMigrationResponse(
            bool success,
            string? message)
        {
            this.Success = success;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesLegacyMigrationResponse" /> class.
        /// </summary>
        public TemplatesLegacyMigrationResponse()
        {
        }
    }
}