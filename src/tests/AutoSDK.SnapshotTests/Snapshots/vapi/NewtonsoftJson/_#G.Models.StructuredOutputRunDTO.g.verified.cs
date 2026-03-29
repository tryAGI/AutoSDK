//HintName: G.Models.StructuredOutputRunDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StructuredOutputRunDTO
    {
        /// <summary>
        /// This is the preview flag for the re-run. If true, the re-run will be executed and the response will be returned immediately and the call artifact will NOT be updated.<br/>
        /// If false (default), the re-run will be executed and the response will be updated in the call artifact.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("previewEnabled")]
        public bool? PreviewEnabled { get; set; }

        /// <summary>
        /// This is the ID of the structured output that will be run. This must be provided unless a transient structured output is provided.<br/>
        /// When the re-run is executed, only the value of this structured output will be replaced with the new value, or added if not present.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("structuredOutputId")]
        public string? StructuredOutputId { get; set; }

        /// <summary>
        /// This is the transient structured output that will be run. This must be provided if a structured output ID is not provided.<br/>
        /// When the re-run is executed, the structured output value will be added to the existing artifact.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("structuredOutput")]
        public global::G.CreateStructuredOutputDTO? StructuredOutput { get; set; }

        /// <summary>
        /// This is the array of callIds that will be updated with the new structured output value. If preview is true, this array must be provided and contain exactly 1 callId.<br/>
        /// If preview is false, up to 100 callIds may be provided.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("callIds", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> CallIds { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StructuredOutputRunDTO" /> class.
        /// </summary>
        /// <param name="callIds">
        /// This is the array of callIds that will be updated with the new structured output value. If preview is true, this array must be provided and contain exactly 1 callId.<br/>
        /// If preview is false, up to 100 callIds may be provided.
        /// </param>
        /// <param name="previewEnabled">
        /// This is the preview flag for the re-run. If true, the re-run will be executed and the response will be returned immediately and the call artifact will NOT be updated.<br/>
        /// If false (default), the re-run will be executed and the response will be updated in the call artifact.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="structuredOutputId">
        /// This is the ID of the structured output that will be run. This must be provided unless a transient structured output is provided.<br/>
        /// When the re-run is executed, only the value of this structured output will be replaced with the new value, or added if not present.
        /// </param>
        /// <param name="structuredOutput">
        /// This is the transient structured output that will be run. This must be provided if a structured output ID is not provided.<br/>
        /// When the re-run is executed, the structured output value will be added to the existing artifact.
        /// </param>
        public StructuredOutputRunDTO(
            global::System.Collections.Generic.IList<string> callIds,
            bool? previewEnabled,
            string? structuredOutputId,
            global::G.CreateStructuredOutputDTO? structuredOutput)
        {
            this.PreviewEnabled = previewEnabled;
            this.StructuredOutputId = structuredOutputId;
            this.StructuredOutput = structuredOutput;
            this.CallIds = callIds ?? throw new global::System.ArgumentNullException(nameof(callIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StructuredOutputRunDTO" /> class.
        /// </summary>
        public StructuredOutputRunDTO()
        {
        }
    }
}