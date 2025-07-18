﻿//HintName: G.Models.WidgetTextContents.g.cs

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
        [global::Newtonsoft.Json.JsonProperty("main_label")]
        public string? MainLabel { get; set; }

        /// <summary>
        /// Text and ARIA label for the start call button.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_call")]
        public string? StartCall { get; set; }

        /// <summary>
        /// Text and ARIA label for the new call button. Displayed when the caller already finished at least one call in order ot start the next one.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("new_call")]
        public string? NewCall { get; set; }

        /// <summary>
        /// Text and ARIA label for the end call button.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_call")]
        public string? EndCall { get; set; }

        /// <summary>
        /// ARIA label for the mute microphone button.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mute_microphone")]
        public string? MuteMicrophone { get; set; }

        /// <summary>
        /// ARIA label for the change language dropdown.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("change_language")]
        public string? ChangeLanguage { get; set; }

        /// <summary>
        /// ARIA label for the collapse button.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("collapse")]
        public string? Collapse { get; set; }

        /// <summary>
        /// ARIA label for the expand button.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expand")]
        public string? Expand { get; set; }

        /// <summary>
        /// Text displayed when the user copies a value using the copy button.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("copied")]
        public string? Copied { get; set; }

        /// <summary>
        /// Text and ARIA label for the accept terms button.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("accept_terms")]
        public string? AcceptTerms { get; set; }

        /// <summary>
        /// Text and ARIA label for the cancel terms button.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dismiss_terms")]
        public string? DismissTerms { get; set; }

        /// <summary>
        /// Status displayed when the agent is listening.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("listening_status")]
        public string? ListeningStatus { get; set; }

        /// <summary>
        /// Status displayed when the agent is speaking.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("speaking_status")]
        public string? SpeakingStatus { get; set; }

        /// <summary>
        /// Status displayed when the agent is connecting.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("connecting_status")]
        public string? ConnectingStatus { get; set; }

        /// <summary>
        /// ARIA label for the text message input.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_label")]
        public string? InputLabel { get; set; }

        /// <summary>
        /// Placeholder text for the text message input.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_placeholder")]
        public string? InputPlaceholder { get; set; }

        /// <summary>
        /// Information message displayed when the user ends the conversation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_ended_conversation")]
        public string? UserEndedConversation { get; set; }

        /// <summary>
        /// Information message displayed when the agent ends the conversation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_ended_conversation")]
        public string? AgentEndedConversation { get; set; }

        /// <summary>
        /// Text label used next to the conversation ID.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conversation_id")]
        public string? ConversationId { get; set; }

        /// <summary>
        /// Text label used when an error occurs.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error_occurred")]
        public string? ErrorOccurred { get; set; }

        /// <summary>
        /// Text and ARIA label used for the copy ID button.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("copy_id")]
        public string? CopyId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
        /// <param name="inputLabel">
        /// ARIA label for the text message input.
        /// </param>
        /// <param name="inputPlaceholder">
        /// Placeholder text for the text message input.
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
        public WidgetTextContents(
            string? mainLabel,
            string? startCall,
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
            string? inputLabel,
            string? inputPlaceholder,
            string? userEndedConversation,
            string? agentEndedConversation,
            string? conversationId,
            string? errorOccurred,
            string? copyId)
        {
            this.MainLabel = mainLabel;
            this.StartCall = startCall;
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
            this.InputLabel = inputLabel;
            this.InputPlaceholder = inputPlaceholder;
            this.UserEndedConversation = userEndedConversation;
            this.AgentEndedConversation = agentEndedConversation;
            this.ConversationId = conversationId;
            this.ErrorOccurred = errorOccurred;
            this.CopyId = copyId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WidgetTextContents" /> class.
        /// </summary>
        public WidgetTextContents()
        {
        }
    }
}