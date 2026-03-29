//HintName: G.Models.ListModelsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListModelsResponse
    {
        /// <summary>
        /// Array of recommended explicit model IDs<br/>
        /// Example: [claude-4-sonnet-thinking, gpt-5.2, claude-4.5-sonnet-thinking]
        /// </summary>
        /// <example>[claude-4-sonnet-thinking, gpt-5.2, claude-4.5-sonnet-thinking]</example>
        [global::Newtonsoft.Json.JsonProperty("models", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Models { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListModelsResponse" /> class.
        /// </summary>
        /// <param name="models">
        /// Array of recommended explicit model IDs<br/>
        /// Example: [claude-4-sonnet-thinking, gpt-5.2, claude-4.5-sonnet-thinking]
        /// </param>
        public ListModelsResponse(
            global::System.Collections.Generic.IList<string> models)
        {
            this.Models = models ?? throw new global::System.ArgumentNullException(nameof(models));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListModelsResponse" /> class.
        /// </summary>
        public ListModelsResponse()
        {
        }
    }
}