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
        [global::Newtonsoft.Json.JsonProperty("inputs")]
        public object? Inputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("versionId")]
        public string? VersionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PopulatePromptRequest" /> class.
        /// </summary>
        /// <param name="inputs"></param>
        /// <param name="versionId"></param>
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