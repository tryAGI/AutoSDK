//HintName: G.Models.TransportConfigurationTwilio.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TransportConfigurationTwilio
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TransportConfigurationTwilioProviderJsonConverter))]
        public global::G.TransportConfigurationTwilioProvider Provider { get; set; }

        /// <summary>
        /// The integer number of seconds that we should allow the phone to ring before assuming there is no answer.<br/>
        /// The default is `60` seconds and the maximum is `600` seconds.<br/>
        /// For some call flows, we will add a 5-second buffer to the timeout value you provide.<br/>
        /// For this reason, a timeout value of 10 seconds could result in an actual timeout closer to 15 seconds.<br/>
        /// You can set this to a short time, such as `15` seconds, to hang up before reaching an answering machine or voicemail.<br/>
        /// @default 60<br/>
        /// Example: 60
        /// </summary>
        /// <example>60</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout")]
        public double? Timeout { get; set; }

        /// <summary>
        /// Whether to record the call.<br/>
        /// Can be `true` to record the phone call, or `false` to not.<br/>
        /// The default is `false`.<br/>
        /// @default false<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("record")]
        public bool? Record { get; set; }

        /// <summary>
        /// The number of channels in the final recording.<br/>
        /// Can be: `mono` or `dual`.<br/>
        /// The default is `mono`.<br/>
        /// `mono` records both legs of the call in a single channel of the recording file.<br/>
        /// `dual` records each leg to a separate channel of the recording file.<br/>
        /// The first channel of a dual-channel recording contains the parent call and the second channel contains the child call.<br/>
        /// @default 'mono'<br/>
        /// Example: mono
        /// </summary>
        /// <example>mono</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("recordingChannels")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TransportConfigurationTwilioRecordingChannelsJsonConverter))]
        public global::G.TransportConfigurationTwilioRecordingChannels? RecordingChannels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TransportConfigurationTwilio" /> class.
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="timeout">
        /// The integer number of seconds that we should allow the phone to ring before assuming there is no answer.<br/>
        /// The default is `60` seconds and the maximum is `600` seconds.<br/>
        /// For some call flows, we will add a 5-second buffer to the timeout value you provide.<br/>
        /// For this reason, a timeout value of 10 seconds could result in an actual timeout closer to 15 seconds.<br/>
        /// You can set this to a short time, such as `15` seconds, to hang up before reaching an answering machine or voicemail.<br/>
        /// @default 60<br/>
        /// Example: 60
        /// </param>
        /// <param name="record">
        /// Whether to record the call.<br/>
        /// Can be `true` to record the phone call, or `false` to not.<br/>
        /// The default is `false`.<br/>
        /// @default false<br/>
        /// Example: false
        /// </param>
        /// <param name="recordingChannels">
        /// The number of channels in the final recording.<br/>
        /// Can be: `mono` or `dual`.<br/>
        /// The default is `mono`.<br/>
        /// `mono` records both legs of the call in a single channel of the recording file.<br/>
        /// `dual` records each leg to a separate channel of the recording file.<br/>
        /// The first channel of a dual-channel recording contains the parent call and the second channel contains the child call.<br/>
        /// @default 'mono'<br/>
        /// Example: mono
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TransportConfigurationTwilio(
            global::G.TransportConfigurationTwilioProvider provider,
            double? timeout,
            bool? record,
            global::G.TransportConfigurationTwilioRecordingChannels? recordingChannels)
        {
            this.Provider = provider;
            this.Timeout = timeout;
            this.Record = record;
            this.RecordingChannels = recordingChannels;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransportConfigurationTwilio" /> class.
        /// </summary>
        public TransportConfigurationTwilio()
        {
        }
    }
}