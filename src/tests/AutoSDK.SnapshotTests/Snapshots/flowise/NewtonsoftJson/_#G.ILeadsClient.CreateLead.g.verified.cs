//HintName: G.ILeadsClient.CreateLead.g.cs
#nullable enable

namespace G
{
    public partial interface ILeadsClient
    {
        /// <summary>
        /// Create a new lead in a chatflow<br/>
        /// Create a new lead associated with a specific chatflow
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Lead> CreateLeadAsync(

            global::G.Lead request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new lead in a chatflow<br/>
        /// Create a new lead associated with a specific chatflow
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the lead<br/>
        /// Example: cfd531e0-82fc-11e9-bc42-526af7764f64
        /// </param>
        /// <param name="name">
        /// Name of the lead<br/>
        /// Example: John Doe
        /// </param>
        /// <param name="email">
        /// Email address of the lead<br/>
        /// Example: john.doe@example.com
        /// </param>
        /// <param name="phone">
        /// Phone number of the lead<br/>
        /// Example: +1234567890
        /// </param>
        /// <param name="chatflowid">
        /// ID of the chatflow the lead is associated with<br/>
        /// Example: 7c4e8b7a-7b9a-4b4d-9f3e-2d28f1ebea02
        /// </param>
        /// <param name="chatId">
        /// ID of the chat session the lead is associated with<br/>
        /// Example: d7b0b5d8-85e6-4f2a-9c1f-9d9a0e2ebf6b
        /// </param>
        /// <param name="createdDate">
        /// Date and time when the lead was created<br/>
        /// Example: 2024-08-24T14:15:22Z
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Lead> CreateLeadAsync(
            global::System.Guid? id = default,
            string? name = default,
            string? email = default,
            string? phone = default,
            string? chatflowid = default,
            string? chatId = default,
            global::System.DateTime? createdDate = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}