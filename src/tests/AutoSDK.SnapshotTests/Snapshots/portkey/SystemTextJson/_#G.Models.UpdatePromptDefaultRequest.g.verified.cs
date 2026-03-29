//HintName: G.Models.UpdatePromptDefaultRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdatePromptDefaultRequest
    {
        /// <summary>
        /// Version Number to set as default
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePromptDefaultRequest" /> class.
        /// </summary>
        /// <param name="version">
        /// Version Number to set as default
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdatePromptDefaultRequest(
            double version)
        {
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePromptDefaultRequest" /> class.
        /// </summary>
        public UpdatePromptDefaultRequest()
        {
        }
    }
}