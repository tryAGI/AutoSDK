//HintName: G.Models.GetInternalActionExecutionLogByIdResponseConnection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetInternalActionExecutionLogByIdResponseConnection
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Entity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetInternalActionExecutionLogByIdResponseConnection" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="entity"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetInternalActionExecutionLogByIdResponseConnection(
            string id,
            string entity)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Entity = entity ?? throw new global::System.ArgumentNullException(nameof(entity));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetInternalActionExecutionLogByIdResponseConnection" /> class.
        /// </summary>
        public GetInternalActionExecutionLogByIdResponseConnection()
        {
        }
    }
}