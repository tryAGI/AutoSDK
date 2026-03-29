//HintName: G.Models.ExecuteSqlRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExecuteSqlRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sql")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Sql { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteSqlRequest" /> class.
        /// </summary>
        /// <param name="sql"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExecuteSqlRequest(
            string sql)
        {
            this.Sql = sql ?? throw new global::System.ArgumentNullException(nameof(sql));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteSqlRequest" /> class.
        /// </summary>
        public ExecuteSqlRequest()
        {
        }
    }
}