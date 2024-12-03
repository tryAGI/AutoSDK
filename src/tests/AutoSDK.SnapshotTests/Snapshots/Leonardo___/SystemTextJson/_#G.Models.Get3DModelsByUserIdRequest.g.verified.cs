//HintName: G.Models.Get3DModelsByUserIdRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Get3DModelsByUserIdRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        public string? UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Get3DModelsByUserIdRequest" /> class.
        /// </summary>
        /// <param name="userId"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public Get3DModelsByUserIdRequest(
            string? userId)
        {
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Get3DModelsByUserIdRequest" /> class.
        /// </summary>
        public Get3DModelsByUserIdRequest()
        {
        }
    }
}