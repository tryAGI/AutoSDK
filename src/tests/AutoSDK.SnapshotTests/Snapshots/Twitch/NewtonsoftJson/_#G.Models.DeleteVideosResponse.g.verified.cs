//HintName: G.Models.DeleteVideosResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteVideosResponse
    {
        /// <summary>
        /// The list of IDs of the videos that were deleted.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteVideosResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// The list of IDs of the videos that were deleted.
        /// </param>
        public DeleteVideosResponse(
            global::System.Collections.Generic.IList<string> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteVideosResponse" /> class.
        /// </summary>
        public DeleteVideosResponse()
        {
        }
    }
}