//HintName: G.IVariablesClient.CreateVariable.g.cs
#nullable enable

namespace G
{
    public partial interface IVariablesClient
    {
        /// <summary>
        /// Create a new variable<br/>
        /// Create a new variable
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Variable> CreateVariableAsync(

            global::G.Variable request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new variable<br/>
        /// Create a new variable
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the variable<br/>
        /// Example: cfd531e0-82fc-11e9-bc42-526af7764f64
        /// </param>
        /// <param name="name">
        /// Name of the variable<br/>
        /// Example: API_KEY
        /// </param>
        /// <param name="value">
        /// Value of the variable<br/>
        /// Example: my-secret-key
        /// </param>
        /// <param name="type">
        /// Type of the variable (e.g., string, number)<br/>
        /// Example: string
        /// </param>
        /// <param name="createdDate">
        /// Date and time when the variable was created<br/>
        /// Example: 2024-08-24T14:15:22Z
        /// </param>
        /// <param name="updatedDate">
        /// Date and time when the variable was last updated<br/>
        /// Example: 2024-08-24T14:15:22Z
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Variable> CreateVariableAsync(
            global::System.Guid? id = default,
            string? name = default,
            string? value = default,
            string? type = default,
            global::System.DateTime? createdDate = default,
            global::System.DateTime? updatedDate = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}