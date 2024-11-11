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
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.StreamMarkerCreated> Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateStreamMarkerResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// A list that contains the single marker that you added.
        /// </param>
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