//HintName: G.Models.PropertiesDetail.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PropertiesDetail
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
        /// Initializes a new instance of the <see cref="PropertiesDetail" /> class.
        /// </summary>
        /// <param name="logid"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PropertiesDetail(
            string logid)
        {
            this.Logid = logid ?? throw new global::System.ArgumentNullException(nameof(logid));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesDetail" /> class.
        /// </summary>
        public PropertiesDetail()
        {
        }
    }
}