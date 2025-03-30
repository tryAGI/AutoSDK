//HintName: G.Models.ListEncodersResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response containing a list of available encoders for converting text to vector embeddings.
    /// </summary>
    public sealed partial class ListEncodersResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("encoders")]
        public global::System.Collections.Generic.IList<global::G.Encoder>? Encoders { get; set; }

        /// <summary>
        /// The standard metadata in the response of a list operation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::G.ListMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListEncodersResponse" /> class.
        /// </summary>
        /// <param name="encoders"></param>
        /// <param name="metadata">
        /// The standard metadata in the response of a list operation.
        /// </param>
        public ListEncodersResponse(
            global::System.Collections.Generic.IList<global::G.Encoder>? encoders,
            global::G.ListMetadata? metadata)
        {
            this.Encoders = encoders;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListEncodersResponse" /> class.
        /// </summary>
        public ListEncodersResponse()
        {
        }
    }
}