//HintName: G.Models.CreateStreamMarkerResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateStreamMarkerResponse
    {
        /// <summary>
        /// A list that contains the single marker that you added.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.StreamMarkerCreated> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateStreamMarkerResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// A list that contains the single marker that you added.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateStreamMarkerResponse(
            global::System.Collections.Generic.IList<global::G.StreamMarkerCreated> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateStreamMarkerResponse" /> class.
        /// </summary>
        public CreateStreamMarkerResponse()
        {
        }
    }
}