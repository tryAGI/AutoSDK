//HintName: G.Models.TaskAgreementMatrixResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TaskAgreementMatrixResponse
    {
        /// <summary>
        /// Pairwise agreement scores matrix where matrix[i][j] is the agreement between users[i] and users[j]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("matrix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>> Matrix { get; set; }

        /// <summary>
        /// Expanded participant details (annotators and/or model versions)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("users")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> Users { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskAgreementMatrixResponse" /> class.
        /// </summary>
        /// <param name="matrix">
        /// Pairwise agreement scores matrix where matrix[i][j] is the agreement between users[i] and users[j]
        /// </param>
        /// <param name="users">
        /// Expanded participant details (annotators and/or model versions)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TaskAgreementMatrixResponse(
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>> matrix,
            global::System.Collections.Generic.IList<object> users)
        {
            this.Matrix = matrix ?? throw new global::System.ArgumentNullException(nameof(matrix));
            this.Users = users ?? throw new global::System.ArgumentNullException(nameof(users));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskAgreementMatrixResponse" /> class.
        /// </summary>
        public TaskAgreementMatrixResponse()
        {
        }
    }
}