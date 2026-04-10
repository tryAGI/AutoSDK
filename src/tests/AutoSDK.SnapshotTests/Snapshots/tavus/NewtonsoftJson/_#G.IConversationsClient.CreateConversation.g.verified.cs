//HintName: G.IConversationsClient.CreateConversation.g.cs
#nullable enable

namespace G
{
    public partial interface IConversationsClient
    {
        /// <summary>
        /// Create Conversation<br/>
        /// Start a real-time video conversation with your AI replica and persona. The response includes a conversation_url to join the call or embed it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateConversationResponse> CreateConversationAsync(

            global::G.CreateConversationRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Conversation<br/>
        /// Start a real-time video conversation with your AI replica and persona. The response includes a conversation_url to join the call or embed it.
        /// </summary>
        /// <param name="personaId">
        /// The identifier of the persona to use.
        /// </param>
        /// <param name="replicaId">
        /// The identifier of the replica. Required if persona has no default replica.
        /// </param>
        /// <param name="callbackUrl">
        /// URL to receive webhook callbacks.
        /// </param>
        /// <param name="conversationalContext">
        /// Additional context for the LLM.
        /// </param>
        /// <param name="customGreeting">
        /// Custom greeting message.
        /// </param>
        /// <param name="language">
        /// Conversation language or "multilingual" for auto-detection.
        /// </param>
        /// <param name="audioOnly">
        /// Start in audio-only mode.
        /// </param>
        /// <param name="maxCallDuration">
        /// Maximum call length in seconds (max 3600).
        /// </param>
        /// <param name="idleTimeout">
        /// Timeout if no participant joins.
        /// </param>
        /// <param name="participantLeftTimeout">
        /// Timeout after last participant leaves.
        /// </param>
        /// <param name="enableClosedCaptions">
        /// Enable closed captions.
        /// </param>
        /// <param name="isPrivate">
        /// Create a private conversation requiring a meeting token.
        /// </param>
        /// <param name="maxParticipantCount">
        /// Maximum number of participants.
        /// </param>
        /// <param name="applyGreenscreen">
        /// Apply green screen effect.
        /// </param>
        /// <param name="backgroundUrl">
        /// Website URL for background.
        /// </param>
        /// <param name="backgroundImageUrl">
        /// Image URL for background.
        /// </param>
        /// <param name="memoryStores">
        /// Memory store identifiers for cross-conversation memory.
        /// </param>
        /// <param name="enableRecording">
        /// Enable conversation recording.
        /// </param>
        /// <param name="recordingS3BucketRegion">
        /// AWS S3 bucket region for recordings.
        /// </param>
        /// <param name="recordingS3BucketName">
        /// AWS S3 bucket name for recordings.
        /// </param>
        /// <param name="properties"></param>
        /// <param name="documentIds">
        /// Knowledge base document IDs to make available.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateConversationResponse> CreateConversationAsync(
            string? personaId = default,
            string? replicaId = default,
            string? callbackUrl = default,
            string? conversationalContext = default,
            string? customGreeting = default,
            string? language = default,
            bool? audioOnly = default,
            int? maxCallDuration = default,
            int? idleTimeout = default,
            int? participantLeftTimeout = default,
            bool? enableClosedCaptions = default,
            bool? isPrivate = default,
            int? maxParticipantCount = default,
            bool? applyGreenscreen = default,
            string? backgroundUrl = default,
            string? backgroundImageUrl = default,
            global::System.Collections.Generic.IList<string>? memoryStores = default,
            bool? enableRecording = default,
            string? recordingS3BucketRegion = default,
            string? recordingS3BucketName = default,
            global::G.ConversationProperties? properties = default,
            global::System.Collections.Generic.IList<string>? documentIds = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}