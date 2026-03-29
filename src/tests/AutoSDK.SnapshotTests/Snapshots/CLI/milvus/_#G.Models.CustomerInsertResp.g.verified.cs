//HintName: G.Models.CustomerInsertResp.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomerInsertResp
    {
        /// <summary>
        /// The number of inserted entities.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("insertCount")]
        public int? InsertCount { get; set; }

        /// <summary>
        /// An array of the IDs of inserted entities.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("insertIds")]
        public global::System.Collections.Generic.IList<string>? InsertIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerInsertResp" /> class.
        /// </summary>
        /// <param name="insertCount">
        /// The number of inserted entities.
        /// </param>
        /// <param name="insertIds">
        /// An array of the IDs of inserted entities.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomerInsertResp(
            int? insertCount,
            global::System.Collections.Generic.IList<string>? insertIds)
        {
            this.InsertCount = insertCount;
            this.InsertIds = insertIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerInsertResp" /> class.
        /// </summary>
        public CustomerInsertResp()
        {
        }
    }
}