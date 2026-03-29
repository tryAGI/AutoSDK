//HintName: G.Models.TavusConversationProperties.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TavusConversationProperties
    {
        /// <summary>
        /// The maximum duration of the call in seconds. The default `maxCallDuration` is 3600 seconds (1 hour).<br/>
        /// Once the time limit specified by this parameter has been reached, the conversation will automatically shut down.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxCallDuration")]
        public double? MaxCallDuration { get; set; }

        /// <summary>
        /// The duration in seconds after which the call will be automatically shut down once the last participant leaves.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("participantLeftTimeout")]
        public double? ParticipantLeftTimeout { get; set; }

        /// <summary>
        /// Starting from conversation creation, the duration in seconds after which the call will be automatically shut down if no participant joins the call.<br/>
        /// Default is 300 seconds (5 minutes).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("participantAbsentTimeout")]
        public double? ParticipantAbsentTimeout { get; set; }

        /// <summary>
        /// If true, the user will be able to record the conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enableRecording")]
        public bool? EnableRecording { get; set; }

        /// <summary>
        /// If true, the user will be able to transcribe the conversation.<br/>
        /// You can find more instructions on displaying transcriptions if you are using your custom DailyJS components here.<br/>
        /// You need to have an event listener on Daily that listens for `app-messages`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enableTranscription")]
        public bool? EnableTranscription { get; set; }

        /// <summary>
        /// If true, the background will be replaced with a greenscreen (RGB values: `[0, 255, 155]`).<br/>
        /// You can use WebGL on the frontend to make the greenscreen transparent or change its color.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("applyGreenscreen")]
        public bool? ApplyGreenscreen { get; set; }

        /// <summary>
        /// The language of the conversation. Please provide the **full language name**, not the two-letter code.<br/>
        /// If you are using your own TTS voice, please ensure it supports the language you provide.<br/>
        /// If you are using a stock replica or default persona, please note that only ElevenLabs and Cartesia supported languages are available.<br/>
        /// You can find a full list of supported languages for Cartesia here, for ElevenLabs here, and for PlayHT here.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// The name of the S3 bucket where the recording will be stored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recordingS3BucketName")]
        public string? RecordingS3BucketName { get; set; }

        /// <summary>
        /// The region of the S3 bucket where the recording will be stored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recordingS3BucketRegion")]
        public string? RecordingS3BucketRegion { get; set; }

        /// <summary>
        /// The ARN of the role that will be assumed to access the S3 bucket.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("awsAssumeRoleArn")]
        public string? AwsAssumeRoleArn { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TavusConversationProperties" /> class.
        /// </summary>
        /// <param name="maxCallDuration">
        /// The maximum duration of the call in seconds. The default `maxCallDuration` is 3600 seconds (1 hour).<br/>
        /// Once the time limit specified by this parameter has been reached, the conversation will automatically shut down.
        /// </param>
        /// <param name="participantLeftTimeout">
        /// The duration in seconds after which the call will be automatically shut down once the last participant leaves.
        /// </param>
        /// <param name="participantAbsentTimeout">
        /// Starting from conversation creation, the duration in seconds after which the call will be automatically shut down if no participant joins the call.<br/>
        /// Default is 300 seconds (5 minutes).
        /// </param>
        /// <param name="enableRecording">
        /// If true, the user will be able to record the conversation.
        /// </param>
        /// <param name="enableTranscription">
        /// If true, the user will be able to transcribe the conversation.<br/>
        /// You can find more instructions on displaying transcriptions if you are using your custom DailyJS components here.<br/>
        /// You need to have an event listener on Daily that listens for `app-messages`.
        /// </param>
        /// <param name="applyGreenscreen">
        /// If true, the background will be replaced with a greenscreen (RGB values: `[0, 255, 155]`).<br/>
        /// You can use WebGL on the frontend to make the greenscreen transparent or change its color.
        /// </param>
        /// <param name="language">
        /// The language of the conversation. Please provide the **full language name**, not the two-letter code.<br/>
        /// If you are using your own TTS voice, please ensure it supports the language you provide.<br/>
        /// If you are using a stock replica or default persona, please note that only ElevenLabs and Cartesia supported languages are available.<br/>
        /// You can find a full list of supported languages for Cartesia here, for ElevenLabs here, and for PlayHT here.
        /// </param>
        /// <param name="recordingS3BucketName">
        /// The name of the S3 bucket where the recording will be stored.
        /// </param>
        /// <param name="recordingS3BucketRegion">
        /// The region of the S3 bucket where the recording will be stored.
        /// </param>
        /// <param name="awsAssumeRoleArn">
        /// The ARN of the role that will be assumed to access the S3 bucket.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TavusConversationProperties(
            double? maxCallDuration,
            double? participantLeftTimeout,
            double? participantAbsentTimeout,
            bool? enableRecording,
            bool? enableTranscription,
            bool? applyGreenscreen,
            string? language,
            string? recordingS3BucketName,
            string? recordingS3BucketRegion,
            string? awsAssumeRoleArn)
        {
            this.MaxCallDuration = maxCallDuration;
            this.ParticipantLeftTimeout = participantLeftTimeout;
            this.ParticipantAbsentTimeout = participantAbsentTimeout;
            this.EnableRecording = enableRecording;
            this.EnableTranscription = enableTranscription;
            this.ApplyGreenscreen = applyGreenscreen;
            this.Language = language;
            this.RecordingS3BucketName = recordingS3BucketName;
            this.RecordingS3BucketRegion = recordingS3BucketRegion;
            this.AwsAssumeRoleArn = awsAssumeRoleArn;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TavusConversationProperties" /> class.
        /// </summary>
        public TavusConversationProperties()
        {
        }
    }
}