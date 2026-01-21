//HintName: G.Models.GetVoicesResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"voices":{"available_for_tiers":["creator","enterprise"],"category":"professional","description":"A warm, expressive voice with a touch of humor.","fine_tuning":{"is_allowed_to_fine_tune":true,"manual_verification_requested":false,"state":{"eleven_multilingual_v2":"fine_tuned"},"verification_attempts_count":2,"verification_failures":[]},"high_quality_base_model_ids":["eleven_v2_flash","eleven_flash_v2","eleven_turbo_v2_5","eleven_multilingual_v2","eleven_v2_5_flash","eleven_flash_v2_5","eleven_turbo_v2"],"is_legacy":false,"is_mixed":false,"is_owner":false,"labels":{"accent":"American","age":"middle-aged","description":"expressive","gender":"female","use_case":"social media"},"name":"Rachel","preview_url":"https://storage.googleapis.com/eleven-public-prod/premade/voices/9BWtsMINqrJLrRacOk9x/405766b8-1f4e-4d3c-aba1-6f25333823ec.mp3","settings":{"similarity_boost":1,"speed":1,"stability":1,"style":0,"use_speaker_boost":true},"sharing":{"category":"professional","cloned_by_count":50,"date_unix":1714204800,"description":"A female voice with a soft and friendly tone.","disable_at_unix":1714204800,"enabled_in_library":true,"featured":true,"financial_rewards_enabled":true,"free_users_allowed":true,"history_item_sample_id":"DCwhRBWXzGAHq8TQ4Fs18","labels":{"accent":"American","gender":"female"},"liked_by_count":100,"live_moderation_enabled":true,"moderation_check":{"captcha_checks":[0.95,0.98],"captcha_ids":["captcha1","captcha2"],"date_checked_unix":1714204800,"description_check":true,"description_value":"A female voice with a soft and friendly tone.","name_check":true,"name_value":"Rachel","sample_checks":[0.95,0.98],"sample_ids":["sample1","sample2"]},"name":"Rachel","notice_period":30,"original_voice_id":"DCwhRBWXzGAHq8TQ4Fs18","public_owner_id":"DCwhRBWXzGAHq8TQ4Fs18","rate":0.05,"reader_app_enabled":true,"reader_restricted_on":[{"resource_id":"FCwhRBWXzGAHq8TQ4Fs18","resource_type":"read"}],"review_status":"allowed","status":"enabled","voice_mixing_allowed":false,"whitelisted_emails":["example@example.com"]},"verified_languages":{"accent":"American","language":"en","model_id":"eleven_turbo_v2_5"},"voice_id":"21m00Tcm4TlvDq8ikWAM","voice_verification":{"is_verified":true,"language":"en","requires_verification":false,"verification_attempts":[{"accepted":true,"date_unix":1714204800,"levenshtein_distance":2,"recording":{"mime_type":"audio/mpeg","recording_id":"CwhRBWXzGAHq8TQ4Fs17","size_bytes":1000000,"transcription":"Hello, how are you?","upload_date_unix":1714204800},"similarity":0.95,"text":"Hello, how are you?"}],"verification_attempts_count":0,"verification_failures":[]}}}
    /// </summary>
    public sealed partial class GetVoicesResponseModel
    {
        /// <summary>
        /// A list of available voices.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voices", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.VoiceResponseModel> Voices { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVoicesResponseModel" /> class.
        /// </summary>
        /// <param name="voices">
        /// A list of available voices.
        /// </param>
        public GetVoicesResponseModel(
            global::System.Collections.Generic.IList<global::G.VoiceResponseModel> voices)
        {
            this.Voices = voices ?? throw new global::System.ArgumentNullException(nameof(voices));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVoicesResponseModel" /> class.
        /// </summary>
        public GetVoicesResponseModel()
        {
        }
    }
}