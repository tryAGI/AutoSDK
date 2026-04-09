//HintName: G.Models.Input.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Input
    {
        /// <summary>
        /// Use one of [Synthesia stock avatars or your custom avatar](https://docs.synthesia.io/reference/avatars).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("avatar", Required = global::Newtonsoft.Json.Required.Always)]
        public string Avatar { get; set; } = default!;

        /// <summary>
        /// Avatar settings.<br/>
        /// Default Value: {"horizontalAlign":"center","scale":1.0,"style":"rectangular","voice":null,"seamless":false}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("avatarSettings")]
        public global::G.ActorSettings? AvatarSettings { get; set; }

        /// <summary>
        /// Use Synthesia' stock backgrounds or your custom background. For the custom background, provide the ID of an uploaded asset (see [Create an asset](https://docs.synthesia.io/reference/create-an-asset)), or URL from where Synthesia should download the background.<br/>
        /// Transparent: green_screen Green screen background can be used if you want to replace background using FFMPEG or any of the video editing software.<br/>
        /// Solid: `off_white` / `warm_white` / `light_pink` / `soft_pink` / `light_blue` / `dark_blue` / `soft_cyan` / `strong_cyan` / `light_orange` / `soft_orange`<br/>
        /// Image: `white_studio` / `white_cafe` / `luxury_lobby` / `large_window` / `white_meeting_room` / `open_office`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("background", Required = global::Newtonsoft.Json.Required.Always)]
        public string Background { get; set; } = default!;

        /// <summary>
        /// Video Settings object
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("backgroundSettings")]
        public global::G.InputBackgroundSettings? BackgroundSettings { get; set; }

        /// <summary>
        /// As an alternative to `scriptText`, provide the ID of uploaded script audio. See [Upload script audio for details](https://docs.synthesia.io/reference/upload-script-audio).<br/>
        /// If you use `scriptAudio` you must provide `scriptLanguage`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scriptAudio")]
        public string? ScriptAudio { get; set; }

        /// <summary>
        /// Language code of the language the script audio was generated in. The scriptLanguage option must be used with `scriptAudio`.<br/>
        /// To control the language/voice of the scriptText, use `input[].avatarSettings.voice` option.<br/>
        /// Language code should be in the format: `en-US`, where the first two characters represent language and the second two-character represent the country.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scriptLanguage")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.InputScriptLanguageJsonConverter))]
        public global::G.InputScriptLanguage? ScriptLanguage { get; set; }

        /// <summary>
        /// Script for text-to-voice can be entered in any of the [supported languages](https://docs.synthesia.io/reference/voices).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scriptText")]
        public string? ScriptText { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("soundSettings")]
        public global::G.InputSoundSettings? SoundSettings { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transition")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.InputTransitionJsonConverter))]
        public global::G.InputTransition? Transition { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Input" /> class.
        /// </summary>
        /// <param name="avatar">
        /// Use one of [Synthesia stock avatars or your custom avatar](https://docs.synthesia.io/reference/avatars).
        /// </param>
        /// <param name="background">
        /// Use Synthesia' stock backgrounds or your custom background. For the custom background, provide the ID of an uploaded asset (see [Create an asset](https://docs.synthesia.io/reference/create-an-asset)), or URL from where Synthesia should download the background.<br/>
        /// Transparent: green_screen Green screen background can be used if you want to replace background using FFMPEG or any of the video editing software.<br/>
        /// Solid: `off_white` / `warm_white` / `light_pink` / `soft_pink` / `light_blue` / `dark_blue` / `soft_cyan` / `strong_cyan` / `light_orange` / `soft_orange`<br/>
        /// Image: `white_studio` / `white_cafe` / `luxury_lobby` / `large_window` / `white_meeting_room` / `open_office`
        /// </param>
        /// <param name="avatarSettings">
        /// Avatar settings.<br/>
        /// Default Value: {"horizontalAlign":"center","scale":1.0,"style":"rectangular","voice":null,"seamless":false}
        /// </param>
        /// <param name="backgroundSettings">
        /// Video Settings object
        /// </param>
        /// <param name="scriptAudio">
        /// As an alternative to `scriptText`, provide the ID of uploaded script audio. See [Upload script audio for details](https://docs.synthesia.io/reference/upload-script-audio).<br/>
        /// If you use `scriptAudio` you must provide `scriptLanguage`.
        /// </param>
        /// <param name="scriptLanguage">
        /// Language code of the language the script audio was generated in. The scriptLanguage option must be used with `scriptAudio`.<br/>
        /// To control the language/voice of the scriptText, use `input[].avatarSettings.voice` option.<br/>
        /// Language code should be in the format: `en-US`, where the first two characters represent language and the second two-character represent the country.
        /// </param>
        /// <param name="scriptText">
        /// Script for text-to-voice can be entered in any of the [supported languages](https://docs.synthesia.io/reference/voices).
        /// </param>
        /// <param name="soundSettings"></param>
        /// <param name="transition">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        public Input(
            string avatar,
            string background,
            global::G.ActorSettings? avatarSettings,
            global::G.InputBackgroundSettings? backgroundSettings,
            string? scriptAudio,
            global::G.InputScriptLanguage? scriptLanguage,
            string? scriptText,
            global::G.InputSoundSettings? soundSettings,
            global::G.InputTransition? transition)
        {
            this.Avatar = avatar ?? throw new global::System.ArgumentNullException(nameof(avatar));
            this.AvatarSettings = avatarSettings;
            this.Background = background ?? throw new global::System.ArgumentNullException(nameof(background));
            this.BackgroundSettings = backgroundSettings;
            this.ScriptAudio = scriptAudio;
            this.ScriptLanguage = scriptLanguage;
            this.ScriptText = scriptText;
            this.SoundSettings = soundSettings;
            this.Transition = transition;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Input" /> class.
        /// </summary>
        public Input()
        {
        }
    }
}