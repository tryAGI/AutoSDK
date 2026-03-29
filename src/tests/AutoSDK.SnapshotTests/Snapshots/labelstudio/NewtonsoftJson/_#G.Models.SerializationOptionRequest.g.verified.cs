//HintName: G.Models.SerializationOptionRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SerializationOptionRequest
    {
        /// <summary>
        /// Include a full json body or IDs only<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("only_id")]
        public bool? OnlyId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializationOptionRequest" /> class.
        /// </summary>
        /// <param name="onlyId">
        /// Include a full json body or IDs only<br/>
        /// Default Value: false
        /// </param>
        public SerializationOptionRequest(
            bool? onlyId)
        {
            this.OnlyId = onlyId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializationOptionRequest" /> class.
        /// </summary>
        public SerializationOptionRequest()
        {
        }
    }
}