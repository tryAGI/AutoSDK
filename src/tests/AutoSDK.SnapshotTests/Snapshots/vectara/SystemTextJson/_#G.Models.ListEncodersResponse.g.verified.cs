//HintName: G.Models.ListEncodersResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListEncodersResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encoders")]
        public global::System.Collections.Generic.IList<global::G.Encoder>? Encoders { get; set; }

        /// <summary>
        /// The standard metadata in the response of a list operation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::G.ListMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListEncodersResponse" /> class.
        /// </summary>
        /// <param name="encoders"></param>
        /// <param name="metadata">
        /// The standard metadata in the response of a list operation.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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