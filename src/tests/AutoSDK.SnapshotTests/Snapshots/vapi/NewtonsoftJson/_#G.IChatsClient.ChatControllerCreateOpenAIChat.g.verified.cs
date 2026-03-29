//HintName: G.IChatsClient.ChatControllerCreateOpenAIChat.g.cs
#nullable enable

namespace G
{
    public partial interface IChatsClient
    {
        /// <summary>
        /// Create Chat (OpenAI Compatible)
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.OneOf<global::G.ResponseObject, global::G.ResponseTextDeltaEvent, global::G.ResponseTextDoneEvent, global::G.ResponseCompletedEvent, global::G.ResponseErrorEvent>> ChatControllerCreateOpenAIChatAsync(

            global::G.OpenAIResponsesRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Chat (OpenAI Compatible)
        /// </summary>
        /// <param name="assistantId">
        /// This is the assistant that will be used for the chat. To use an existing assistant, use `assistantId` instead.
        /// </param>
        /// <param name="assistant">
        /// This is the assistant that will be used for the chat. To use an existing assistant, use `assistantId` instead.
        /// </param>
        /// <param name="assistantOverrides">
        /// These are the variable values that will be used to replace template variables in the assistant messages.<br/>
        /// Only variable substitution is supported in chat contexts - other assistant properties cannot be overridden.
        /// </param>
        /// <param name="squadId">
        /// This is the squad that will be used for the chat. To use a transient squad, use `squad` instead.
        /// </param>
        /// <param name="squad">
        /// This is the squad that will be used for the chat. To use an existing squad, use `squadId` instead.
        /// </param>
        /// <param name="name">
        /// This is the name of the chat. This is just for your own reference.
        /// </param>
        /// <param name="sessionId">
        /// This is the ID of the session that will be used for the chat.<br/>
        /// Mutually exclusive with previousChatId.
        /// </param>
        /// <param name="input">
        /// This is the input text for the chat.<br/>
        /// Can be a string or an array of chat messages.<br/>
        /// This field is REQUIRED for chat creation.
        /// </param>
        /// <param name="stream">
        /// Whether to stream the response or not.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="previousChatId">
        /// This is the ID of the chat that will be used as context for the new chat.<br/>
        /// The messages from the previous chat will be used as context.<br/>
        /// Mutually exclusive with sessionId.
        /// </param>
        /// <param name="transport">
        /// This is used to send the chat through a transport like SMS.<br/>
        /// If transport.phoneNumberId and transport.customer are provided, creates a new session.<br/>
        /// If sessionId is provided without transport fields, uses existing session data.<br/>
        /// Cannot specify both sessionId and transport fields (phoneNumberId/customer) together.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.OneOf<global::G.ResponseObject, global::G.ResponseTextDeltaEvent, global::G.ResponseTextDoneEvent, global::G.ResponseCompletedEvent, global::G.ResponseErrorEvent>> ChatControllerCreateOpenAIChatAsync(
            global::G.OneOf<string, global::System.Collections.Generic.IList<global::G.OneOf<global::G.SystemMessage, global::G.UserMessage, global::G.AssistantMessage, global::G.ToolMessage, global::G.DeveloperMessage>>> input,
            string? assistantId = default,
            global::G.CreateAssistantDTO? assistant = default,
            global::G.AssistantOverrides? assistantOverrides = default,
            string? squadId = default,
            global::G.CreateSquadDTO? squad = default,
            string? name = default,
            string? sessionId = default,
            bool? stream = default,
            string? previousChatId = default,
            global::G.TwilioSMSChatTransport? transport = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}