//HintName: G.Models.FolderEntitiesCountResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FolderEntitiesCountResponse
    {
        /// <summary>
        /// The number of entities affected by the operation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("moved_count")]
        public int? MovedCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FolderEntitiesCountResponse" /> class.
        /// </summary>
        /// <param name="movedCount">
        /// The number of entities affected by the operation.
        /// </param>
        public FolderEntitiesCountResponse(
            int? movedCount)
        {
            this.MovedCount = movedCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FolderEntitiesCountResponse" /> class.
        /// </summary>
        public FolderEntitiesCountResponse()
        {
        }
    }
}