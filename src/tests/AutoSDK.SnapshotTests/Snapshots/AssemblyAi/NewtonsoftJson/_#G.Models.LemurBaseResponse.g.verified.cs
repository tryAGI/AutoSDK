//HintName: G.Models.LemurBaseResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LemurBaseResponse
    {
        /// <summary>
        /// The ID of the LeMUR request
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid RequestId { get; set; } = default!;

        /// <summary>
        /// The usage numbers for the LeMUR request
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.LemurUsage Usage { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LemurBaseResponse" /> class.
        /// </summary>
        /// <param name="requestId">
        /// The ID of the LeMUR request
        /// </param>
        /// <param name="usage">
        /// The usage numbers for the LeMUR request
        /// </param>
        public LemurBaseResponse(
            global::System.Guid requestId,
            global::G.LemurUsage usage)
        {
            this.RequestId = requestId;
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LemurBaseResponse" /> class.
        /// </summary>
        public LemurBaseResponse()
        {
        }
    }
}