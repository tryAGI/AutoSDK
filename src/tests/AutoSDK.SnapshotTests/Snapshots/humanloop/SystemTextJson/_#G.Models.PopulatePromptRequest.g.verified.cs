//HintName: G.Models.PopulatePromptRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PopulatePromptRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        public object? Inputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versionId")]
        public string? VersionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PopulatePromptRequest" /> class.
        /// </summary>
        /// <param name="inputs"></param>
        /// <param name="versionId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PopulatePromptRequest(
            object? inputs,
            string? versionId)
        {
            this.Inputs = inputs;
            this.VersionId = versionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PopulatePromptRequest" /> class.
        /// </summary>
        public PopulatePromptRequest()
        {
        }
    }
}