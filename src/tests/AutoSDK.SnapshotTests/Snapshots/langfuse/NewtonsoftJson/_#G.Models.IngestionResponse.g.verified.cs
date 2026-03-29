//HintName: G.Models.IngestionResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IngestionResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("successes", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.IngestionSuccess> Successes { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("errors", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.IngestionError> Errors { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IngestionResponse" /> class.
        /// </summary>
        /// <param name="successes"></param>
        /// <param name="errors"></param>
        public IngestionResponse(
            global::System.Collections.Generic.IList<global::G.IngestionSuccess> successes,
            global::System.Collections.Generic.IList<global::G.IngestionError> errors)
        {
            this.Successes = successes ?? throw new global::System.ArgumentNullException(nameof(successes));
            this.Errors = errors ?? throw new global::System.ArgumentNullException(nameof(errors));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IngestionResponse" /> class.
        /// </summary>
        public IngestionResponse()
        {
        }
    }
}