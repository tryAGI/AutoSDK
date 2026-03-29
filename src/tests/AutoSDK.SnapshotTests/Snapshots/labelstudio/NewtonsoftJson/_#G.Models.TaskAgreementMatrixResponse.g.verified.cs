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
        [global::Newtonsoft.Json.JsonProperty("matrix", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>> Matrix { get; set; } = default!;

        /// <summary>
        /// Expanded participant details (annotators and/or model versions)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("users", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<object> Users { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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