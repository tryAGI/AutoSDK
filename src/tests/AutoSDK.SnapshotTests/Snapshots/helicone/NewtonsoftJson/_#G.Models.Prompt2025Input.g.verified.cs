//HintName: G.Models.Prompt2025Input.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Prompt2025Input
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string RequestId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string VersionId { get; set; } = default!;

        /// <summary>
        /// Construct a type with a set of properties K of type T
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inputs", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RecordStringAny Inputs { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Prompt2025Input" /> class.
        /// </summary>
        /// <param name="requestId"></param>
        /// <param name="versionId"></param>
        /// <param name="inputs">
        /// Construct a type with a set of properties K of type T
        /// </param>
        public Prompt2025Input(
            string requestId,
            string versionId,
            global::G.RecordStringAny inputs)
        {
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
            this.VersionId = versionId ?? throw new global::System.ArgumentNullException(nameof(versionId));
            this.Inputs = inputs ?? throw new global::System.ArgumentNullException(nameof(inputs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Prompt2025Input" /> class.
        /// </summary>
        public Prompt2025Input()
        {
        }
    }
}