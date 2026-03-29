//HintName: G.Models.PipelinesUpdatePipelineRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PipelinesUpdatePipelineRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disabled")]
        public bool? Disabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelinesUpdatePipelineRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="disabled"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PipelinesUpdatePipelineRequest(
            string? name,
            bool? disabled)
        {
            this.Name = name;
            this.Disabled = disabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelinesUpdatePipelineRequest" /> class.
        /// </summary>
        public PipelinesUpdatePipelineRequest()
        {
        }
    }
}