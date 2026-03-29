//HintName: G.Models.ResponseDetail.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseDetail
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Logid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseDetail" /> class.
        /// </summary>
        /// <param name="logid"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseDetail(
            string logid)
        {
            this.Logid = logid ?? throw new global::System.ArgumentNullException(nameof(logid));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseDetail" /> class.
        /// </summary>
        public ResponseDetail()
        {
        }
    }
}