//HintName: G.Models.CreateSavedQueryRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSavedQueryRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateSavedQueryRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="sql"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSavedQueryRequest(
            string name,
            string sql)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Sql = sql ?? throw new global::System.ArgumentNullException(nameof(sql));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSavedQueryRequest" /> class.
        /// </summary>
        public CreateSavedQueryRequest()
        {
        }
    }
}