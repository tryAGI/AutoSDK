//HintName: G.Models.GenerateAssetPublicGenerationsPostResponse.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct GenerateAssetPublicGenerationsPostResponse : global::System.IEquatable<GenerateAssetPublicGenerationsPostResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.GenerateAssetPublicGenerationsPostResponseDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GenerateVideoResponse? Video { get; init; }
#else
        public global::G.GenerateVideoResponse? Video { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Video))]
#endif
        public bool IsVideo => Video != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickVideo(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.GenerateVideoResponse? value)
        {
            value = Video;
            return IsVideo;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GenerateTextToSpeechResponse? TextToSpeech { get; init; }
#else
        public global::G.GenerateTextToSpeechResponse? TextToSpeech { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextToSpeech))]
#endif
        public bool IsTextToSpeech => TextToSpeech != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTextToSpeech(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.GenerateTextToSpeechResponse? value)
        {
            value = TextToSpeech;
            return IsTextToSpeech;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GenerateTextToSoundResponse? TextToSound { get; init; }
#else
        public global::G.GenerateTextToSoundResponse? TextToSound { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextToSound))]
#endif
        public bool IsTextToSound => TextToSound != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTextToSound(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.GenerateTextToSoundResponse? value)
        {
            value = TextToSound;
            return IsTextToSound;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GenerateImageResponse? Image { get; init; }
#else
        public global::G.GenerateImageResponse? Image { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Image))]
#endif
        public bool IsImage => Image != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickImage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.GenerateImageResponse? value)
        {
            value = Image;
            return IsImage;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GenerateImageUpscaleResponse? ImageUpscale { get; init; }
#else
        public global::G.GenerateImageUpscaleResponse? ImageUpscale { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageUpscale))]
#endif
        public bool IsImageUpscale => ImageUpscale != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickImageUpscale(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.GenerateImageUpscaleResponse? value)
        {
            value = ImageUpscale;
            return IsImageUpscale;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GenerateVideoUpscaleResponse? VideoUpscale { get; init; }
#else
        public global::G.GenerateVideoUpscaleResponse? VideoUpscale { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VideoUpscale))]
#endif
        public bool IsVideoUpscale => VideoUpscale != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickVideoUpscale(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.GenerateVideoUpscaleResponse? value)
        {
            value = VideoUpscale;
            return IsVideoUpscale;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GenerateIsolatedAudioResponse? AudioIsolation { get; init; }
#else
        public global::G.GenerateIsolatedAudioResponse? AudioIsolation { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AudioIsolation))]
#endif
        public bool IsAudioIsolation => AudioIsolation != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAudioIsolation(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.GenerateIsolatedAudioResponse? value)
        {
            value = AudioIsolation;
            return IsAudioIsolation;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GenerateSpeechToSpeechResponse? SpeechToSpeech { get; init; }
#else
        public global::G.GenerateSpeechToSpeechResponse? SpeechToSpeech { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SpeechToSpeech))]
#endif
        public bool IsSpeechToSpeech => SpeechToSpeech != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSpeechToSpeech(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.GenerateSpeechToSpeechResponse? value)
        {
            value = SpeechToSpeech;
            return IsSpeechToSpeech;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GenerateVoiceCloneResponse? VoiceClone { get; init; }
#else
        public global::G.GenerateVoiceCloneResponse? VoiceClone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VoiceClone))]
#endif
        public bool IsVoiceClone => VoiceClone != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickVoiceClone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.GenerateVoiceCloneResponse? value)
        {
            value = VoiceClone;
            return IsVoiceClone;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GenerateAudioFromVideoResponse? AudioFromVideo { get; init; }
#else
        public global::G.GenerateAudioFromVideoResponse? AudioFromVideo { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AudioFromVideo))]
#endif
        public bool IsAudioFromVideo => AudioFromVideo != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAudioFromVideo(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.GenerateAudioFromVideoResponse? value)
        {
            value = AudioFromVideo;
            return IsAudioFromVideo;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GenerateVideoWithAudioResponse? VideoWithAudio { get; init; }
#else
        public global::G.GenerateVideoWithAudioResponse? VideoWithAudio { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VideoWithAudio))]
#endif
        public bool IsVideoWithAudio => VideoWithAudio != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickVideoWithAudio(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.GenerateVideoWithAudioResponse? value)
        {
            value = VideoWithAudio;
            return IsVideoWithAudio;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GenerateVideoToVideoResponse? VideoToVideo { get; init; }
#else
        public global::G.GenerateVideoToVideoResponse? VideoToVideo { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VideoToVideo))]
#endif
        public bool IsVideoToVideo => VideoToVideo != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickVideoToVideo(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.GenerateVideoToVideoResponse? value)
        {
            value = VideoToVideo;
            return IsVideoToVideo;
        }

        /// <summary>
        /// Response for Motion Control generations.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GenerateMotionControlResponse? MotionControl { get; init; }
#else
        public global::G.GenerateMotionControlResponse? MotionControl { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MotionControl))]
#endif
        public bool IsMotionControl => MotionControl != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickMotionControl(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.GenerateMotionControlResponse? value)
        {
            value = MotionControl;
            return IsMotionControl;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GenerateAssetPublicGenerationsPostResponse(global::G.GenerateVideoResponse value) => new GenerateAssetPublicGenerationsPostResponse((global::G.GenerateVideoResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GenerateVideoResponse?(GenerateAssetPublicGenerationsPostResponse @this) => @this.Video;

        /// <summary>
        /// 
        /// </summary>
        public GenerateAssetPublicGenerationsPostResponse(global::G.GenerateVideoResponse? value)
        {
            Video = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static GenerateAssetPublicGenerationsPostResponse FromVideo(global::G.GenerateVideoResponse? value) => new GenerateAssetPublicGenerationsPostResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GenerateAssetPublicGenerationsPostResponse(global::G.GenerateTextToSpeechResponse value) => new GenerateAssetPublicGenerationsPostResponse((global::G.GenerateTextToSpeechResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GenerateTextToSpeechResponse?(GenerateAssetPublicGenerationsPostResponse @this) => @this.TextToSpeech;

        /// <summary>
        /// 
        /// </summary>
        public GenerateAssetPublicGenerationsPostResponse(global::G.GenerateTextToSpeechResponse? value)
        {
            TextToSpeech = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static GenerateAssetPublicGenerationsPostResponse FromTextToSpeech(global::G.GenerateTextToSpeechResponse? value) => new GenerateAssetPublicGenerationsPostResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GenerateAssetPublicGenerationsPostResponse(global::G.GenerateTextToSoundResponse value) => new GenerateAssetPublicGenerationsPostResponse((global::G.GenerateTextToSoundResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GenerateTextToSoundResponse?(GenerateAssetPublicGenerationsPostResponse @this) => @this.TextToSound;

        /// <summary>
        /// 
        /// </summary>
        public GenerateAssetPublicGenerationsPostResponse(global::G.GenerateTextToSoundResponse? value)
        {
            TextToSound = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static GenerateAssetPublicGenerationsPostResponse FromTextToSound(global::G.GenerateTextToSoundResponse? value) => new GenerateAssetPublicGenerationsPostResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GenerateAssetPublicGenerationsPostResponse(global::G.GenerateImageResponse value) => new GenerateAssetPublicGenerationsPostResponse((global::G.GenerateImageResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GenerateImageResponse?(GenerateAssetPublicGenerationsPostResponse @this) => @this.Image;

        /// <summary>
        /// 
        /// </summary>
        public GenerateAssetPublicGenerationsPostResponse(global::G.GenerateImageResponse? value)
        {
            Image = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static GenerateAssetPublicGenerationsPostResponse FromImage(global::G.GenerateImageResponse? value) => new GenerateAssetPublicGenerationsPostResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GenerateAssetPublicGenerationsPostResponse(global::G.GenerateImageUpscaleResponse value) => new GenerateAssetPublicGenerationsPostResponse((global::G.GenerateImageUpscaleResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GenerateImageUpscaleResponse?(GenerateAssetPublicGenerationsPostResponse @this) => @this.ImageUpscale;

        /// <summary>
        /// 
        /// </summary>
        public GenerateAssetPublicGenerationsPostResponse(global::G.GenerateImageUpscaleResponse? value)
        {
            ImageUpscale = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static GenerateAssetPublicGenerationsPostResponse FromImageUpscale(global::G.GenerateImageUpscaleResponse? value) => new GenerateAssetPublicGenerationsPostResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GenerateAssetPublicGenerationsPostResponse(global::G.GenerateVideoUpscaleResponse value) => new GenerateAssetPublicGenerationsPostResponse((global::G.GenerateVideoUpscaleResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GenerateVideoUpscaleResponse?(GenerateAssetPublicGenerationsPostResponse @this) => @this.VideoUpscale;

        /// <summary>
        /// 
        /// </summary>
        public GenerateAssetPublicGenerationsPostResponse(global::G.GenerateVideoUpscaleResponse? value)
        {
            VideoUpscale = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static GenerateAssetPublicGenerationsPostResponse FromVideoUpscale(global::G.GenerateVideoUpscaleResponse? value) => new GenerateAssetPublicGenerationsPostResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GenerateAssetPublicGenerationsPostResponse(global::G.GenerateIsolatedAudioResponse value) => new GenerateAssetPublicGenerationsPostResponse((global::G.GenerateIsolatedAudioResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GenerateIsolatedAudioResponse?(GenerateAssetPublicGenerationsPostResponse @this) => @this.AudioIsolation;

        /// <summary>
        /// 
        /// </summary>
        public GenerateAssetPublicGenerationsPostResponse(global::G.GenerateIsolatedAudioResponse? value)
        {
            AudioIsolation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static GenerateAssetPublicGenerationsPostResponse FromAudioIsolation(global::G.GenerateIsolatedAudioResponse? value) => new GenerateAssetPublicGenerationsPostResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GenerateAssetPublicGenerationsPostResponse(global::G.GenerateSpeechToSpeechResponse value) => new GenerateAssetPublicGenerationsPostResponse((global::G.GenerateSpeechToSpeechResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GenerateSpeechToSpeechResponse?(GenerateAssetPublicGenerationsPostResponse @this) => @this.SpeechToSpeech;

        /// <summary>
        /// 
        /// </summary>
        public GenerateAssetPublicGenerationsPostResponse(global::G.GenerateSpeechToSpeechResponse? value)
        {
            SpeechToSpeech = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static GenerateAssetPublicGenerationsPostResponse FromSpeechToSpeech(global::G.GenerateSpeechToSpeechResponse? value) => new GenerateAssetPublicGenerationsPostResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GenerateAssetPublicGenerationsPostResponse(global::G.GenerateVoiceCloneResponse value) => new GenerateAssetPublicGenerationsPostResponse((global::G.GenerateVoiceCloneResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GenerateVoiceCloneResponse?(GenerateAssetPublicGenerationsPostResponse @this) => @this.VoiceClone;

        /// <summary>
        /// 
        /// </summary>
        public GenerateAssetPublicGenerationsPostResponse(global::G.GenerateVoiceCloneResponse? value)
        {
            VoiceClone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static GenerateAssetPublicGenerationsPostResponse FromVoiceClone(global::G.GenerateVoiceCloneResponse? value) => new GenerateAssetPublicGenerationsPostResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GenerateAssetPublicGenerationsPostResponse(global::G.GenerateAudioFromVideoResponse value) => new GenerateAssetPublicGenerationsPostResponse((global::G.GenerateAudioFromVideoResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GenerateAudioFromVideoResponse?(GenerateAssetPublicGenerationsPostResponse @this) => @this.AudioFromVideo;

        /// <summary>
        /// 
        /// </summary>
        public GenerateAssetPublicGenerationsPostResponse(global::G.GenerateAudioFromVideoResponse? value)
        {
            AudioFromVideo = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static GenerateAssetPublicGenerationsPostResponse FromAudioFromVideo(global::G.GenerateAudioFromVideoResponse? value) => new GenerateAssetPublicGenerationsPostResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GenerateAssetPublicGenerationsPostResponse(global::G.GenerateVideoWithAudioResponse value) => new GenerateAssetPublicGenerationsPostResponse((global::G.GenerateVideoWithAudioResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GenerateVideoWithAudioResponse?(GenerateAssetPublicGenerationsPostResponse @this) => @this.VideoWithAudio;

        /// <summary>
        /// 
        /// </summary>
        public GenerateAssetPublicGenerationsPostResponse(global::G.GenerateVideoWithAudioResponse? value)
        {
            VideoWithAudio = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static GenerateAssetPublicGenerationsPostResponse FromVideoWithAudio(global::G.GenerateVideoWithAudioResponse? value) => new GenerateAssetPublicGenerationsPostResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GenerateAssetPublicGenerationsPostResponse(global::G.GenerateVideoToVideoResponse value) => new GenerateAssetPublicGenerationsPostResponse((global::G.GenerateVideoToVideoResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GenerateVideoToVideoResponse?(GenerateAssetPublicGenerationsPostResponse @this) => @this.VideoToVideo;

        /// <summary>
        /// 
        /// </summary>
        public GenerateAssetPublicGenerationsPostResponse(global::G.GenerateVideoToVideoResponse? value)
        {
            VideoToVideo = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static GenerateAssetPublicGenerationsPostResponse FromVideoToVideo(global::G.GenerateVideoToVideoResponse? value) => new GenerateAssetPublicGenerationsPostResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GenerateAssetPublicGenerationsPostResponse(global::G.GenerateMotionControlResponse value) => new GenerateAssetPublicGenerationsPostResponse((global::G.GenerateMotionControlResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GenerateMotionControlResponse?(GenerateAssetPublicGenerationsPostResponse @this) => @this.MotionControl;

        /// <summary>
        /// 
        /// </summary>
        public GenerateAssetPublicGenerationsPostResponse(global::G.GenerateMotionControlResponse? value)
        {
            MotionControl = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static GenerateAssetPublicGenerationsPostResponse FromMotionControl(global::G.GenerateMotionControlResponse? value) => new GenerateAssetPublicGenerationsPostResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public GenerateAssetPublicGenerationsPostResponse(
            global::G.GenerateAssetPublicGenerationsPostResponseDiscriminatorType? type,
            global::G.GenerateVideoResponse? video,
            global::G.GenerateTextToSpeechResponse? textToSpeech,
            global::G.GenerateTextToSoundResponse? textToSound,
            global::G.GenerateImageResponse? image,
            global::G.GenerateImageUpscaleResponse? imageUpscale,
            global::G.GenerateVideoUpscaleResponse? videoUpscale,
            global::G.GenerateIsolatedAudioResponse? audioIsolation,
            global::G.GenerateSpeechToSpeechResponse? speechToSpeech,
            global::G.GenerateVoiceCloneResponse? voiceClone,
            global::G.GenerateAudioFromVideoResponse? audioFromVideo,
            global::G.GenerateVideoWithAudioResponse? videoWithAudio,
            global::G.GenerateVideoToVideoResponse? videoToVideo,
            global::G.GenerateMotionControlResponse? motionControl
            )
        {
            Type = type;

            Video = video;
            TextToSpeech = textToSpeech;
            TextToSound = textToSound;
            Image = image;
            ImageUpscale = imageUpscale;
            VideoUpscale = videoUpscale;
            AudioIsolation = audioIsolation;
            SpeechToSpeech = speechToSpeech;
            VoiceClone = voiceClone;
            AudioFromVideo = audioFromVideo;
            VideoWithAudio = videoWithAudio;
            VideoToVideo = videoToVideo;
            MotionControl = motionControl;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            MotionControl as object ??
            VideoToVideo as object ??
            VideoWithAudio as object ??
            AudioFromVideo as object ??
            VoiceClone as object ??
            SpeechToSpeech as object ??
            AudioIsolation as object ??
            VideoUpscale as object ??
            ImageUpscale as object ??
            Image as object ??
            TextToSound as object ??
            TextToSpeech as object ??
            Video as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Video?.ToString() ??
            TextToSpeech?.ToString() ??
            TextToSound?.ToString() ??
            Image?.ToString() ??
            ImageUpscale?.ToString() ??
            VideoUpscale?.ToString() ??
            AudioIsolation?.ToString() ??
            SpeechToSpeech?.ToString() ??
            VoiceClone?.ToString() ??
            AudioFromVideo?.ToString() ??
            VideoWithAudio?.ToString() ??
            VideoToVideo?.ToString() ??
            MotionControl?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsVideo && !IsTextToSpeech && !IsTextToSound && !IsImage && !IsImageUpscale && !IsVideoUpscale && !IsAudioIsolation && !IsSpeechToSpeech && !IsVoiceClone && !IsAudioFromVideo && !IsVideoWithAudio && !IsVideoToVideo && !IsMotionControl || !IsVideo && IsTextToSpeech && !IsTextToSound && !IsImage && !IsImageUpscale && !IsVideoUpscale && !IsAudioIsolation && !IsSpeechToSpeech && !IsVoiceClone && !IsAudioFromVideo && !IsVideoWithAudio && !IsVideoToVideo && !IsMotionControl || !IsVideo && !IsTextToSpeech && IsTextToSound && !IsImage && !IsImageUpscale && !IsVideoUpscale && !IsAudioIsolation && !IsSpeechToSpeech && !IsVoiceClone && !IsAudioFromVideo && !IsVideoWithAudio && !IsVideoToVideo && !IsMotionControl || !IsVideo && !IsTextToSpeech && !IsTextToSound && IsImage && !IsImageUpscale && !IsVideoUpscale && !IsAudioIsolation && !IsSpeechToSpeech && !IsVoiceClone && !IsAudioFromVideo && !IsVideoWithAudio && !IsVideoToVideo && !IsMotionControl || !IsVideo && !IsTextToSpeech && !IsTextToSound && !IsImage && IsImageUpscale && !IsVideoUpscale && !IsAudioIsolation && !IsSpeechToSpeech && !IsVoiceClone && !IsAudioFromVideo && !IsVideoWithAudio && !IsVideoToVideo && !IsMotionControl || !IsVideo && !IsTextToSpeech && !IsTextToSound && !IsImage && !IsImageUpscale && IsVideoUpscale && !IsAudioIsolation && !IsSpeechToSpeech && !IsVoiceClone && !IsAudioFromVideo && !IsVideoWithAudio && !IsVideoToVideo && !IsMotionControl || !IsVideo && !IsTextToSpeech && !IsTextToSound && !IsImage && !IsImageUpscale && !IsVideoUpscale && IsAudioIsolation && !IsSpeechToSpeech && !IsVoiceClone && !IsAudioFromVideo && !IsVideoWithAudio && !IsVideoToVideo && !IsMotionControl || !IsVideo && !IsTextToSpeech && !IsTextToSound && !IsImage && !IsImageUpscale && !IsVideoUpscale && !IsAudioIsolation && IsSpeechToSpeech && !IsVoiceClone && !IsAudioFromVideo && !IsVideoWithAudio && !IsVideoToVideo && !IsMotionControl || !IsVideo && !IsTextToSpeech && !IsTextToSound && !IsImage && !IsImageUpscale && !IsVideoUpscale && !IsAudioIsolation && !IsSpeechToSpeech && IsVoiceClone && !IsAudioFromVideo && !IsVideoWithAudio && !IsVideoToVideo && !IsMotionControl || !IsVideo && !IsTextToSpeech && !IsTextToSound && !IsImage && !IsImageUpscale && !IsVideoUpscale && !IsAudioIsolation && !IsSpeechToSpeech && !IsVoiceClone && IsAudioFromVideo && !IsVideoWithAudio && !IsVideoToVideo && !IsMotionControl || !IsVideo && !IsTextToSpeech && !IsTextToSound && !IsImage && !IsImageUpscale && !IsVideoUpscale && !IsAudioIsolation && !IsSpeechToSpeech && !IsVoiceClone && !IsAudioFromVideo && IsVideoWithAudio && !IsVideoToVideo && !IsMotionControl || !IsVideo && !IsTextToSpeech && !IsTextToSound && !IsImage && !IsImageUpscale && !IsVideoUpscale && !IsAudioIsolation && !IsSpeechToSpeech && !IsVoiceClone && !IsAudioFromVideo && !IsVideoWithAudio && IsVideoToVideo && !IsMotionControl || !IsVideo && !IsTextToSpeech && !IsTextToSound && !IsImage && !IsImageUpscale && !IsVideoUpscale && !IsAudioIsolation && !IsSpeechToSpeech && !IsVoiceClone && !IsAudioFromVideo && !IsVideoWithAudio && !IsVideoToVideo && IsMotionControl;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.GenerateVideoResponse, TResult>? video = null,
            global::System.Func<global::G.GenerateTextToSpeechResponse, TResult>? textToSpeech = null,
            global::System.Func<global::G.GenerateTextToSoundResponse, TResult>? textToSound = null,
            global::System.Func<global::G.GenerateImageResponse, TResult>? image = null,
            global::System.Func<global::G.GenerateImageUpscaleResponse, TResult>? imageUpscale = null,
            global::System.Func<global::G.GenerateVideoUpscaleResponse, TResult>? videoUpscale = null,
            global::System.Func<global::G.GenerateIsolatedAudioResponse, TResult>? audioIsolation = null,
            global::System.Func<global::G.GenerateSpeechToSpeechResponse, TResult>? speechToSpeech = null,
            global::System.Func<global::G.GenerateVoiceCloneResponse, TResult>? voiceClone = null,
            global::System.Func<global::G.GenerateAudioFromVideoResponse, TResult>? audioFromVideo = null,
            global::System.Func<global::G.GenerateVideoWithAudioResponse, TResult>? videoWithAudio = null,
            global::System.Func<global::G.GenerateVideoToVideoResponse, TResult>? videoToVideo = null,
            global::System.Func<global::G.GenerateMotionControlResponse, TResult>? motionControl = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVideo && video != null)
            {
                return video(Video!);
            }
            else if (IsTextToSpeech && textToSpeech != null)
            {
                return textToSpeech(TextToSpeech!);
            }
            else if (IsTextToSound && textToSound != null)
            {
                return textToSound(TextToSound!);
            }
            else if (IsImage && image != null)
            {
                return image(Image!);
            }
            else if (IsImageUpscale && imageUpscale != null)
            {
                return imageUpscale(ImageUpscale!);
            }
            else if (IsVideoUpscale && videoUpscale != null)
            {
                return videoUpscale(VideoUpscale!);
            }
            else if (IsAudioIsolation && audioIsolation != null)
            {
                return audioIsolation(AudioIsolation!);
            }
            else if (IsSpeechToSpeech && speechToSpeech != null)
            {
                return speechToSpeech(SpeechToSpeech!);
            }
            else if (IsVoiceClone && voiceClone != null)
            {
                return voiceClone(VoiceClone!);
            }
            else if (IsAudioFromVideo && audioFromVideo != null)
            {
                return audioFromVideo(AudioFromVideo!);
            }
            else if (IsVideoWithAudio && videoWithAudio != null)
            {
                return videoWithAudio(VideoWithAudio!);
            }
            else if (IsVideoToVideo && videoToVideo != null)
            {
                return videoToVideo(VideoToVideo!);
            }
            else if (IsMotionControl && motionControl != null)
            {
                return motionControl(MotionControl!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.GenerateVideoResponse>? video = null,

            global::System.Action<global::G.GenerateTextToSpeechResponse>? textToSpeech = null,

            global::System.Action<global::G.GenerateTextToSoundResponse>? textToSound = null,

            global::System.Action<global::G.GenerateImageResponse>? image = null,

            global::System.Action<global::G.GenerateImageUpscaleResponse>? imageUpscale = null,

            global::System.Action<global::G.GenerateVideoUpscaleResponse>? videoUpscale = null,

            global::System.Action<global::G.GenerateIsolatedAudioResponse>? audioIsolation = null,

            global::System.Action<global::G.GenerateSpeechToSpeechResponse>? speechToSpeech = null,

            global::System.Action<global::G.GenerateVoiceCloneResponse>? voiceClone = null,

            global::System.Action<global::G.GenerateAudioFromVideoResponse>? audioFromVideo = null,

            global::System.Action<global::G.GenerateVideoWithAudioResponse>? videoWithAudio = null,

            global::System.Action<global::G.GenerateVideoToVideoResponse>? videoToVideo = null,

            global::System.Action<global::G.GenerateMotionControlResponse>? motionControl = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVideo)
            {
                video?.Invoke(Video!);
            }
            else if (IsTextToSpeech)
            {
                textToSpeech?.Invoke(TextToSpeech!);
            }
            else if (IsTextToSound)
            {
                textToSound?.Invoke(TextToSound!);
            }
            else if (IsImage)
            {
                image?.Invoke(Image!);
            }
            else if (IsImageUpscale)
            {
                imageUpscale?.Invoke(ImageUpscale!);
            }
            else if (IsVideoUpscale)
            {
                videoUpscale?.Invoke(VideoUpscale!);
            }
            else if (IsAudioIsolation)
            {
                audioIsolation?.Invoke(AudioIsolation!);
            }
            else if (IsSpeechToSpeech)
            {
                speechToSpeech?.Invoke(SpeechToSpeech!);
            }
            else if (IsVoiceClone)
            {
                voiceClone?.Invoke(VoiceClone!);
            }
            else if (IsAudioFromVideo)
            {
                audioFromVideo?.Invoke(AudioFromVideo!);
            }
            else if (IsVideoWithAudio)
            {
                videoWithAudio?.Invoke(VideoWithAudio!);
            }
            else if (IsVideoToVideo)
            {
                videoToVideo?.Invoke(VideoToVideo!);
            }
            else if (IsMotionControl)
            {
                motionControl?.Invoke(MotionControl!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::G.GenerateVideoResponse>? video = null,
            global::System.Action<global::G.GenerateTextToSpeechResponse>? textToSpeech = null,
            global::System.Action<global::G.GenerateTextToSoundResponse>? textToSound = null,
            global::System.Action<global::G.GenerateImageResponse>? image = null,
            global::System.Action<global::G.GenerateImageUpscaleResponse>? imageUpscale = null,
            global::System.Action<global::G.GenerateVideoUpscaleResponse>? videoUpscale = null,
            global::System.Action<global::G.GenerateIsolatedAudioResponse>? audioIsolation = null,
            global::System.Action<global::G.GenerateSpeechToSpeechResponse>? speechToSpeech = null,
            global::System.Action<global::G.GenerateVoiceCloneResponse>? voiceClone = null,
            global::System.Action<global::G.GenerateAudioFromVideoResponse>? audioFromVideo = null,
            global::System.Action<global::G.GenerateVideoWithAudioResponse>? videoWithAudio = null,
            global::System.Action<global::G.GenerateVideoToVideoResponse>? videoToVideo = null,
            global::System.Action<global::G.GenerateMotionControlResponse>? motionControl = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVideo)
            {
                video?.Invoke(Video!);
            }
            else if (IsTextToSpeech)
            {
                textToSpeech?.Invoke(TextToSpeech!);
            }
            else if (IsTextToSound)
            {
                textToSound?.Invoke(TextToSound!);
            }
            else if (IsImage)
            {
                image?.Invoke(Image!);
            }
            else if (IsImageUpscale)
            {
                imageUpscale?.Invoke(ImageUpscale!);
            }
            else if (IsVideoUpscale)
            {
                videoUpscale?.Invoke(VideoUpscale!);
            }
            else if (IsAudioIsolation)
            {
                audioIsolation?.Invoke(AudioIsolation!);
            }
            else if (IsSpeechToSpeech)
            {
                speechToSpeech?.Invoke(SpeechToSpeech!);
            }
            else if (IsVoiceClone)
            {
                voiceClone?.Invoke(VoiceClone!);
            }
            else if (IsAudioFromVideo)
            {
                audioFromVideo?.Invoke(AudioFromVideo!);
            }
            else if (IsVideoWithAudio)
            {
                videoWithAudio?.Invoke(VideoWithAudio!);
            }
            else if (IsVideoToVideo)
            {
                videoToVideo?.Invoke(VideoToVideo!);
            }
            else if (IsMotionControl)
            {
                motionControl?.Invoke(MotionControl!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Video,
                typeof(global::G.GenerateVideoResponse),
                TextToSpeech,
                typeof(global::G.GenerateTextToSpeechResponse),
                TextToSound,
                typeof(global::G.GenerateTextToSoundResponse),
                Image,
                typeof(global::G.GenerateImageResponse),
                ImageUpscale,
                typeof(global::G.GenerateImageUpscaleResponse),
                VideoUpscale,
                typeof(global::G.GenerateVideoUpscaleResponse),
                AudioIsolation,
                typeof(global::G.GenerateIsolatedAudioResponse),
                SpeechToSpeech,
                typeof(global::G.GenerateSpeechToSpeechResponse),
                VoiceClone,
                typeof(global::G.GenerateVoiceCloneResponse),
                AudioFromVideo,
                typeof(global::G.GenerateAudioFromVideoResponse),
                VideoWithAudio,
                typeof(global::G.GenerateVideoWithAudioResponse),
                VideoToVideo,
                typeof(global::G.GenerateVideoToVideoResponse),
                MotionControl,
                typeof(global::G.GenerateMotionControlResponse),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(GenerateAssetPublicGenerationsPostResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.GenerateVideoResponse?>.Default.Equals(Video, other.Video) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GenerateTextToSpeechResponse?>.Default.Equals(TextToSpeech, other.TextToSpeech) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GenerateTextToSoundResponse?>.Default.Equals(TextToSound, other.TextToSound) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GenerateImageResponse?>.Default.Equals(Image, other.Image) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GenerateImageUpscaleResponse?>.Default.Equals(ImageUpscale, other.ImageUpscale) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GenerateVideoUpscaleResponse?>.Default.Equals(VideoUpscale, other.VideoUpscale) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GenerateIsolatedAudioResponse?>.Default.Equals(AudioIsolation, other.AudioIsolation) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GenerateSpeechToSpeechResponse?>.Default.Equals(SpeechToSpeech, other.SpeechToSpeech) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GenerateVoiceCloneResponse?>.Default.Equals(VoiceClone, other.VoiceClone) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GenerateAudioFromVideoResponse?>.Default.Equals(AudioFromVideo, other.AudioFromVideo) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GenerateVideoWithAudioResponse?>.Default.Equals(VideoWithAudio, other.VideoWithAudio) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GenerateVideoToVideoResponse?>.Default.Equals(VideoToVideo, other.VideoToVideo) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GenerateMotionControlResponse?>.Default.Equals(MotionControl, other.MotionControl) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(GenerateAssetPublicGenerationsPostResponse obj1, GenerateAssetPublicGenerationsPostResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<GenerateAssetPublicGenerationsPostResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(GenerateAssetPublicGenerationsPostResponse obj1, GenerateAssetPublicGenerationsPostResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GenerateAssetPublicGenerationsPostResponse o && Equals(o);
        }
    }
}
