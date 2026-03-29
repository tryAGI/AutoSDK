//HintName: G.Models.CreateExperimentTableRowRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateExperimentTableRowRequest
    {
        /// <summary>
        /// Construct a type with a set of properties K of type T
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inputs")]
        public global::System.Collections.Generic.Dictionary<string, string>? Inputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sourceRequest")]
        public string? SourceRequest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("promptVersionId", Required = global::Newtonsoft.Json.Required.Always)]
        public string PromptVersionId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateExperimentTableRowRequest" /> class.
        /// </summary>
        /// <param name="promptVersionId"></param>
        /// <param name="inputs">
        /// Construct a type with a set of properties K of type T
        /// </param>
        /// <param name="sourceRequest"></param>
        public CreateExperimentTableRowRequest(
            string promptVersionId,
            global::System.Collections.Generic.Dictionary<string, string>? inputs,
            string? sourceRequest)
        {
            this.Inputs = inputs;
            this.SourceRequest = sourceRequest;
            this.PromptVersionId = promptVersionId ?? throw new global::System.ArgumentNullException(nameof(promptVersionId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateExperimentTableRowRequest" /> class.
        /// </summary>
        public CreateExperimentTableRowRequest()
        {
        }
    }
}