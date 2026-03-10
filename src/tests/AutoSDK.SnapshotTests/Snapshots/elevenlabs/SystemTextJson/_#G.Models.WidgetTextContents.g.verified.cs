//HintName: G.Models.WidgetTextContents.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WidgetTextContents
    {
        /// <summary>
        /// Call to action displayed inside the compact and full variants.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("main_label")]
        public string? MainLabel { get; set; }

        /// <summary>
        /// Text and ARIA label for the start call button.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_call")]
        public string? StartCall { get; set; }

        /// <summary>
        /// Text and ARIA label for the start chat button (text only)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_chat")]
        public string? StartChat { get; set; }

        /// <summary>
        /// Text and ARIA label for the new call button. Displayed when the caller already finished at least one call in order ot start the next one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_call")]
        public string? NewCall { get; set; }

        /// <summary>
        /// Text and ARIA label for the end call button.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_call")]
        public string? EndCall { get; set; }

        /// <summary>
        /// ARIA label for the mute microphone button.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mute_microphone")]
        public string? MuteMicrophone { get; set; }

        /// <summary>
        /// ARIA label for the change language dropdown.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("change_language")]
        public string? ChangeLanguage { get; set; }

        /// <summary>
        /// ARIA label for the collapse button.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collapse")]
        public string? Collapse { get; set; }

        /// <summary>
        /// ARIA label for the expand button.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expand")]
        public string? Expand { get; set; }

        /// <summary>
        /// Text displayed when the user copies a value using the copy button.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("copied")]
        public string? Copied { get; set; }

        /// <summary>
        /// Text and ARIA label for the accept terms button.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accept_terms")]
        public string? AcceptTerms { get; set; }

        /// <summary>
        /// Text and ARIA label for the cancel terms button.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dismiss_terms")]
        public string? DismissTerms { get; set; }

        /// <summary>
        /// Status displayed when the agent is listening.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("listening_status")]
        public string? ListeningStatus { get; set; }

        /// <summary>
        /// Status displayed when the agent is speaking.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaking_status")]
        public string? SpeakingStatus { get; set; }

        /// <summary>
        /// Status displayed when the agent is connecting.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connecting_status")]
        public string? ConnectingStatus { get; set; }

        /// <summary>
        /// Status displayed when the agent is chatting (text only)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chatting_status")]
        public string? ChattingStatus { get; set; }

        /// <summary>
        /// ARIA label for the text message input.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_label")]
        public string? InputLabel { get; set; }

        /// <summary>
        /// Placeholder text for the text message input.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_placeholder")]
        public string? InputPlaceholder { get; set; }

        /// <summary>
        /// Placeholder text for the text message input (text only)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_placeholder_text_only")]
        public string? InputPlaceholderTextOnly { get; set; }

        /// <summary>
        /// Placeholder text for the text message input when starting a new conversation (text only)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_placeholder_new_conversation")]
        public string? InputPlaceholderNewConversation { get; set; }

        /// <summary>
        /// Information message displayed when the user ends the conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_ended_conversation")]
        public string? UserEndedConversation { get; set; }

        /// <summary>
        /// Information message displayed when the agent ends the conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_ended_conversation")]
        public string? AgentEndedConversation { get; set; }

        /// <summary>
        /// Text label used next to the conversation ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_id")]
        public string? ConversationId { get; set; }

        /// <summary>
        /// Text label used when an error occurs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_occurred")]
        public string? ErrorOccurred { get; set; }

        /// <summary>
        /// Text and ARIA label used for the copy ID button.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("copy_id")]
        public string? CopyId { get; set; }

        /// <summary>
        /// Text displayed to prompt the user for feedback.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("initiate_feedback")]
        public string? InitiateFeedback { get; set; }

        /// <summary>
        /// Text displayed to request additional feedback details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_follow_up_feedback")]
        public string? RequestFollowUpFeedback { get; set; }

        /// <summary>
        /// Text displayed to thank the user for providing feedback.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thanks_for_feedback")]
        public string? ThanksForFeedback { get; set; }

        /// <summary>
        /// Additional text displayed explaining the value of user feedback.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thanks_for_feedback_details")]
        public string? ThanksForFeedbackDetails { get; set; }

        /// <summary>
        /// Placeholder text for the follow-up feedback input field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("follow_up_feedback_placeholder")]
        public string? FollowUpFeedbackPlaceholder { get; set; }

        /// <summary>
        /// Text and ARIA label for the submit button.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("submit")]
        public string? Submit { get; set; }

        /// <summary>
        /// Text and ARIA label for the go back button.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("go_back")]
        public string? GoBack { get; set; }

        /// <summary>
        /// Text and ARIA label for the send message button.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("send_message")]
        public string? SendMessage { get; set; }

        /// <summary>
        /// Text and ARIA label for the switch to text mode button.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_mode")]
        public string? TextMode { get; set; }

        /// <summary>
        /// Text and ARIA label for the switch to voice mode button.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_mode")]
        public string? VoiceMode { get; set; }

        /// <summary>
        /// Toast notification displayed when switching to text mode.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("switched_to_text_mode")]
        public string? SwitchedToTextMode { get; set; }

        /// <summary>
        /// Toast notification displayed when switching to voice mode.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("switched_to_voice_mode")]
        public string? SwitchedToVoiceMode { get; set; }

        /// <summary>
        /// Text and ARIA label for the copy button.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("copy")]
        public string? Copy { get; set; }

        /// <summary>
        /// Text and ARIA label for the download button.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("download")]
        public string? Download { get; set; }

        /// <summary>
        /// Text and ARIA label for the wrap toggle button.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wrap")]
        public string? Wrap { get; set; }

        /// <summary>
        /// Status text displayed when the agent is processing a tool call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_working")]
        public string? AgentWorking { get; set; }

        /// <summary>
        /// Status text displayed when the agent finishes processing a tool call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_done")]
        public string? AgentDone { get; set; }

        /// <summary>
        /// Status text displayed when the agent encounters an error during a tool call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_error")]
        public string? AgentError { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WidgetTextContents" /> class.
        /// </summary>
        /// <param name="mainLabel">
        /// Call to action displayed inside the compact and full variants.
        /// </param>
        /// <param name="startCall">
        /// Text and ARIA label for the start call button.
        /// </param>
        /// <param name="startChat">
        /// Text and ARIA label for the start chat button (text only)
        /// </param>
        /// <param name="newCall">
        /// Text and ARIA label for the new call button. Displayed when the caller already finished at least one call in order ot start the next one.
        /// </param>
        /// <param name="endCall">
        /// Text and ARIA label for the end call button.
        /// </param>
        /// <param name="muteMicrophone">
        /// ARIA label for the mute microphone button.
        /// </param>
        /// <param name="changeLanguage">
        /// ARIA label for the change language dropdown.
        /// </param>
        /// <param name="collapse">
        /// ARIA label for the collapse button.
        /// </param>
        /// <param name="expand">
        /// ARIA label for the expand button.
        /// </param>
        /// <param name="copied">
        /// Text displayed when the user copies a value using the copy button.
        /// </param>
        /// <param name="acceptTerms">
        /// Text and ARIA label for the accept terms button.
        /// </param>
        /// <param name="dismissTerms">
        /// Text and ARIA label for the cancel terms button.
        /// </param>
        /// <param name="listeningStatus">
        /// Status displayed when the agent is listening.
        /// </param>
        /// <param name="speakingStatus">
        /// Status displayed when the agent is speaking.
        /// </param>
        /// <param name="connectingStatus">
        /// Status displayed when the agent is connecting.
        /// </param>
        /// <param name="chattingStatus">
        /// Status displayed when the agent is chatting (text only)
        /// </param>
        /// <param name="inputLabel">
        /// ARIA label for the text message input.
        /// </param>
        /// <param name="inputPlaceholder">
        /// Placeholder text for the text message input.
        /// </param>
        /// <param name="inputPlaceholderTextOnly">
        /// Placeholder text for the text message input (text only)
        /// </param>
        /// <param name="inputPlaceholderNewConversation">
        /// Placeholder text for the text message input when starting a new conversation (text only)
        /// </param>
        /// <param name="userEndedConversation">
        /// Information message displayed when the user ends the conversation.
        /// </param>
        /// <param name="agentEndedConversation">
        /// Information message displayed when the agent ends the conversation.
        /// </param>
        /// <param name="conversationId">
        /// Text label used next to the conversation ID.
        /// </param>
        /// <param name="errorOccurred">
        /// Text label used when an error occurs.
        /// </param>
        /// <param name="copyId">
        /// Text and ARIA label used for the copy ID button.
        /// </param>
        /// <param name="initiateFeedback">
        /// Text displayed to prompt the user for feedback.
        /// </param>
        /// <param name="requestFollowUpFeedback">
        /// Text displayed to request additional feedback details.
        /// </param>
        /// <param name="thanksForFeedback">
        /// Text displayed to thank the user for providing feedback.
        /// </param>
        /// <param name="thanksForFeedbackDetails">
        /// Additional text displayed explaining the value of user feedback.
        /// </param>
        /// <param name="followUpFeedbackPlaceholder">
        /// Placeholder text for the follow-up feedback input field.
        /// </param>
        /// <param name="submit">
        /// Text and ARIA label for the submit button.
        /// </param>
        /// <param name="goBack">
        /// Text and ARIA label for the go back button.
        /// </param>
        /// <param name="sendMessage">
        /// Text and ARIA label for the send message button.
        /// </param>
        /// <param name="textMode">
        /// Text and ARIA label for the switch to text mode button.
        /// </param>
        /// <param name="voiceMode">
        /// Text and ARIA label for the switch to voice mode button.
        /// </param>
        /// <param name="switchedToTextMode">
        /// Toast notification displayed when switching to text mode.
        /// </param>
        /// <param name="switchedToVoiceMode">
        /// Toast notification displayed when switching to voice mode.
        /// </param>
        /// <param name="copy">
        /// Text and ARIA label for the copy button.
        /// </param>
        /// <param name="download">
        /// Text and ARIA label for the download button.
        /// </param>
        /// <param name="wrap">
        /// Text and ARIA label for the wrap toggle button.
        /// </param>
        /// <param name="agentWorking">
        /// Status text displayed when the agent is processing a tool call.
        /// </param>
        /// <param name="agentDone">
        /// Status text displayed when the agent finishes processing a tool call.
        /// </param>
        /// <param name="agentError">
        /// Status text displayed when the agent encounters an error during a tool call.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WidgetTextContents(
            string? mainLabel,
            string? startCall,
            string? startChat,
            string? newCall,
            string? endCall,
            string? muteMicrophone,
            string? changeLanguage,
            string? collapse,
            string? expand,
            string? copied,
            string? acceptTerms,
            string? dismissTerms,
            string? listeningStatus,
            string? speakingStatus,
            string? connectingStatus,
            string? chattingStatus,
            string? inputLabel,
            string? inputPlaceholder,
            string? inputPlaceholderTextOnly,
            string? inputPlaceholderNewConversation,
            string? userEndedConversation,
            string? agentEndedConversation,
            string? conversationId,
            string? errorOccurred,
            string? copyId,
            string? initiateFeedback,
            string? requestFollowUpFeedback,
            string? thanksForFeedback,
            string? thanksForFeedbackDetails,
            string? followUpFeedbackPlaceholder,
            string? submit,
            string? goBack,
            string? sendMessage,
            string? textMode,
            string? voiceMode,
            string? switchedToTextMode,
            string? switchedToVoiceMode,
            string? copy,
            string? download,
            string? wrap,
            string? agentWorking,
            string? agentDone,
            string? agentError)
        {
            this.MainLabel = mainLabel;
            this.StartCall = startCall;
            this.StartChat = startChat;
            this.NewCall = newCall;
            this.EndCall = endCall;
            this.MuteMicrophone = muteMicrophone;
            this.ChangeLanguage = changeLanguage;
            this.Collapse = collapse;
            this.Expand = expand;
            this.Copied = copied;
            this.AcceptTerms = acceptTerms;
            this.DismissTerms = dismissTerms;
            this.ListeningStatus = listeningStatus;
            this.SpeakingStatus = speakingStatus;
            this.ConnectingStatus = connectingStatus;
            this.ChattingStatus = chattingStatus;
            this.InputLabel = inputLabel;
            this.InputPlaceholder = inputPlaceholder;
            this.InputPlaceholderTextOnly = inputPlaceholderTextOnly;
            this.InputPlaceholderNewConversation = inputPlaceholderNewConversation;
            this.UserEndedConversation = userEndedConversation;
            this.AgentEndedConversation = agentEndedConversation;
            this.ConversationId = conversationId;
            this.ErrorOccurred = errorOccurred;
            this.CopyId = copyId;
            this.InitiateFeedback = initiateFeedback;
            this.RequestFollowUpFeedback = requestFollowUpFeedback;
            this.ThanksForFeedback = thanksForFeedback;
            this.ThanksForFeedbackDetails = thanksForFeedbackDetails;
            this.FollowUpFeedbackPlaceholder = followUpFeedbackPlaceholder;
            this.Submit = submit;
            this.GoBack = goBack;
            this.SendMessage = sendMessage;
            this.TextMode = textMode;
            this.VoiceMode = voiceMode;
            this.SwitchedToTextMode = switchedToTextMode;
            this.SwitchedToVoiceMode = switchedToVoiceMode;
            this.Copy = copy;
            this.Download = download;
            this.Wrap = wrap;
            this.AgentWorking = agentWorking;
            this.AgentDone = agentDone;
            this.AgentError = agentError;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WidgetTextContents" /> class.
        /// </summary>
        public WidgetTextContents()
        {
        }
    }
}