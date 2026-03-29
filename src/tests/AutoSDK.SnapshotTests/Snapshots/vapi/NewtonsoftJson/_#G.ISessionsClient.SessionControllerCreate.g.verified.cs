//HintName: G.ISessionsClient.SessionControllerCreate.g.cs
#nullable enable

namespace G
{
    public partial interface ISessionsClient
    {
        /// <summary>
        /// Create Session
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Session> SessionControllerCreateAsync(

            global::G.CreateSessionDTO request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Session
        /// </summary>
        /// <param name="name">
        /// This is a user-defined name for the session. Maximum length is 40 characters.
        /// </param>
        /// <param name="status">
        /// This is the current status of the session. Can be either 'active' or 'completed'.
        /// </param>
        /// <param name="expirationSeconds">
        /// Session expiration time in seconds. Defaults to 24 hours (86400 seconds) if not set.<br/>
        /// Example: 86400
        /// </param>
        /// <param name="assistantId">
        /// This is the ID of the assistant associated with this session. Use this when referencing an existing assistant.
        /// </param>
        /// <param name="assistant">
        /// This is the assistant configuration for this session. Use this when creating a new assistant configuration.<br/>
        /// If assistantId is provided, this will be ignored.
        /// </param>
        /// <param name="assistantOverrides">
        /// These are the overrides for the assistant configuration.<br/>
        /// Use this to provide variable values and other overrides when using assistantId.<br/>
        /// Variable substitution will be applied to the assistant's messages and other text-based fields.
        /// </param>
        /// <param name="squadId">
        /// This is the squad ID associated with this session. Use this when referencing an existing squad.
        /// </param>
        /// <param name="squad">
        /// This is the squad configuration for this session. Use this when creating a new squad configuration.<br/>
        /// If squadId is provided, this will be ignored.
        /// </param>
        /// <param name="messages">
        /// This is an array of chat messages in the session.
        /// </param>
        /// <param name="customer">
        /// This is the customer information associated with this session.
        /// </param>
        /// <param name="customerId">
        /// This is the customerId of the customer associated with this session.
        /// </param>
        /// <param name="phoneNumberId">
        /// This is the ID of the phone number associated with this session.
        /// </param>
        /// <param name="phoneNumber">
        /// This is the phone number configuration for this session.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Session> SessionControllerCreateAsync(
            string? name = default,
            global::G.CreateSessionDTOStatus? status = default,
            double? expirationSeconds = default,
            string? assistantId = default,
            global::G.CreateAssistantDTO? assistant = default,
            global::G.AssistantOverrides? assistantOverrides = default,
            string? squadId = default,
            global::G.CreateSquadDTO? squad = default,
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.SystemMessage, global::G.UserMessage, global::G.AssistantMessage, global::G.ToolMessage, global::G.DeveloperMessage>>? messages = default,
            global::G.CreateCustomerDTO? customer = default,
            string? customerId = default,
            string? phoneNumberId = default,
            global::G.ImportTwilioPhoneNumberDTO? phoneNumber = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}