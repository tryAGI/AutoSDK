//HintName: G.Models.Input.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Inputs for the generation
    /// </summary>
    public readonly partial struct Input : global::System.IEquatable<Input>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.GenerationInputDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GenerateVideoRequestOutput? Video { get; init; }
#else
        public global::G.GenerateVideoRequestOutput? Video { get; }
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
#if NET6_0_OR_GREATER
        public global::G.GenerateTextToSpeechRequest? TextToSpeech { get; init; }
#else
        public global::G.GenerateTextToSpeechRequest? TextToSpeech { get; }
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
#if NET6_0_OR_GREATER
        public global::G.GenerateTextToSoundRequest? TextToSound { get; init; }
#else
        public global::G.GenerateTextToSoundRequest? TextToSound { get; }
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
#if NET6_0_OR_GREATER
        public global::G.GenerateImageRequest? Image { get; init; }
#else
        public global::G.GenerateImageRequest? Image { get; }
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
#if NET6_0_OR_GREATER
        public global::G.GenerateImageUpscaleRequest? ImageUpscale { get; init; }
#else
        public global::G.GenerateImageUpscaleRequest? ImageUpscale { get; }
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
#if NET6_0_OR_GREATER
        public global::G.GenerateVideoUpscaleRequest? VideoUpscale { get; init; }
#else
        public global::G.GenerateVideoUpscaleRequest? VideoUpscale { get; }
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
#if NET6_0_OR_GREATER
        public global::G.GenerateIsolatedAudioRequest? AudioIsolation { get; init; }
#else
        public global::G.GenerateIsolatedAudioRequest? AudioIsolation { get; }
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
#if NET6_0_OR_GREATER
        public global::G.GenerateSpeechToSpeechRequest? SpeechToSpeech { get; init; }
#else
        public global::G.GenerateSpeechToSpeechRequest? SpeechToSpeech { get; }
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
#if NET6_0_OR_GREATER
        public global::G.GenerateVoiceCloneRequest? VoiceClone { get; init; }
#else
        public global::G.GenerateVoiceCloneRequest? VoiceClone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VoiceClone))]
#endif
        public bool IsVoiceClone => VoiceClone != null;

        /// <summary>
        /// Audio generation request that extracts sound effects from video using Mirelo Studio.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GenerateAudioFromVideoRequest? AudioFromVideo { get; init; }
#else
        public global::G.GenerateAudioFromVideoRequest? AudioFromVideo { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AudioFromVideo))]
#endif
        public bool IsAudioFromVideo => AudioFromVideo != null;

        /// <summary>
        /// Video generation request that adds synchronized sound effects to video using Mirelo Studio.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GenerateVideoWithAudioRequest? VideoWithAudio { get; init; }
#else
        public global::G.GenerateVideoWithAudioRequest? VideoWithAudio { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VideoWithAudio))]
#endif
        public bool IsVideoWithAudio => VideoWithAudio != null;

        /// <summary>
        /// Video-to-video edit request for Kling O1 Edit model.<br/>
        /// Transforms videos using natural language while preserving motion.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GenerateVideoToVideoRequest? VideoToVideo { get; init; }
#else
        public global::G.GenerateVideoToVideoRequest? VideoToVideo { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VideoToVideo))]
#endif
        public bool IsVideoToVideo => VideoToVideo != null;

        /// <summary>
        /// Motion Control request for transferring motion from a reference video to a character image.<br/>
        /// Processed through V2V infrastructure internally.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GenerateMotionControlRequestOutput? MotionControl { get; init; }
#else
        public global::G.GenerateMotionControlRequestOutput? MotionControl { get; }
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
        public static implicit operator Input(global::G.GenerateVideoRequestOutput value) => new Input((global::G.GenerateVideoRequestOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GenerateVideoRequestOutput?(Input @this) => @this.Video;

        /// <summary>
        /// 
        /// </summary>
        public Input(global::G.GenerateVideoRequestOutput? value)
        {
            Video = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Input(global::G.GenerateTextToSpeechRequest value) => new Input((global::G.GenerateTextToSpeechRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GenerateTextToSpeechRequest?(Input @this) => @this.TextToSpeech;

        /// <summary>
        /// 
        /// </summary>
        public Input(global::G.GenerateTextToSpeechRequest? value)
        {
            TextToSpeech = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Input(global::G.GenerateTextToSoundRequest value) => new Input((global::G.GenerateTextToSoundRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GenerateTextToSoundRequest?(Input @this) => @this.TextToSound;

        /// <summary>
        /// 
        /// </summary>
        public Input(global::G.GenerateTextToSoundRequest? value)
        {
            TextToSound = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Input(global::G.GenerateImageRequest value) => new Input((global::G.GenerateImageRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GenerateImageRequest?(Input @this) => @this.Image;

        /// <summary>
        /// 
        /// </summary>
        public Input(global::G.GenerateImageRequest? value)
        {
            Image = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Input(global::G.GenerateImageUpscaleRequest value) => new Input((global::G.GenerateImageUpscaleRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GenerateImageUpscaleRequest?(Input @this) => @this.ImageUpscale;

        /// <summary>
        /// 
        /// </summary>
        public Input(global::G.GenerateImageUpscaleRequest? value)
        {
            ImageUpscale = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Input(global::G.GenerateVideoUpscaleRequest value) => new Input((global::G.GenerateVideoUpscaleRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GenerateVideoUpscaleRequest?(Input @this) => @this.VideoUpscale;

        /// <summary>
        /// 
        /// </summary>
        public Input(global::G.GenerateVideoUpscaleRequest? value)
        {
            VideoUpscale = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Input(global::G.GenerateIsolatedAudioRequest value) => new Input((global::G.GenerateIsolatedAudioRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GenerateIsolatedAudioRequest?(Input @this) => @this.AudioIsolation;

        /// <summary>
        /// 
        /// </summary>
        public Input(global::G.GenerateIsolatedAudioRequest? value)
        {
            AudioIsolation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Input(global::G.GenerateSpeechToSpeechRequest value) => new Input((global::G.GenerateSpeechToSpeechRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GenerateSpeechToSpeechRequest?(Input @this) => @this.SpeechToSpeech;

        /// <summary>
        /// 
        /// </summary>
        public Input(global::G.GenerateSpeechToSpeechRequest? value)
        {
            SpeechToSpeech = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Input(global::G.GenerateVoiceCloneRequest value) => new Input((global::G.GenerateVoiceCloneRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GenerateVoiceCloneRequest?(Input @this) => @this.VoiceClone;

        /// <summary>
        /// 
        /// </summary>
        public Input(global::G.GenerateVoiceCloneRequest? value)
        {
            VoiceClone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Input(global::G.GenerateAudioFromVideoRequest value) => new Input((global::G.GenerateAudioFromVideoRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GenerateAudioFromVideoRequest?(Input @this) => @this.AudioFromVideo;

        /// <summary>
        /// 
        /// </summary>
        public Input(global::G.GenerateAudioFromVideoRequest? value)
        {
            AudioFromVideo = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Input(global::G.GenerateVideoWithAudioRequest value) => new Input((global::G.GenerateVideoWithAudioRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GenerateVideoWithAudioRequest?(Input @this) => @this.VideoWithAudio;

        /// <summary>
        /// 
        /// </summary>
        public Input(global::G.GenerateVideoWithAudioRequest? value)
        {
            VideoWithAudio = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Input(global::G.GenerateVideoToVideoRequest value) => new Input((global::G.GenerateVideoToVideoRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GenerateVideoToVideoRequest?(Input @this) => @this.VideoToVideo;

        /// <summary>
        /// 
        /// </summary>
        public Input(global::G.GenerateVideoToVideoRequest? value)
        {
            VideoToVideo = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Input(global::G.GenerateMotionControlRequestOutput value) => new Input((global::G.GenerateMotionControlRequestOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GenerateMotionControlRequestOutput?(Input @this) => @this.MotionControl;

        /// <summary>
        /// 
        /// </summary>
        public Input(global::G.GenerateMotionControlRequestOutput? value)
        {
            MotionControl = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Input(
            global::G.GenerationInputDiscriminatorType? type,
            global::G.GenerateVideoRequestOutput? video,
            global::G.GenerateTextToSpeechRequest? textToSpeech,
            global::G.GenerateTextToSoundRequest? textToSound,
            global::G.GenerateImageRequest? image,
            global::G.GenerateImageUpscaleRequest? imageUpscale,
            global::G.GenerateVideoUpscaleRequest? videoUpscale,
            global::G.GenerateIsolatedAudioRequest? audioIsolation,
            global::G.GenerateSpeechToSpeechRequest? speechToSpeech,
            global::G.GenerateVoiceCloneRequest? voiceClone,
            global::G.GenerateAudioFromVideoRequest? audioFromVideo,
            global::G.GenerateVideoWithAudioRequest? videoWithAudio,
            global::G.GenerateVideoToVideoRequest? videoToVideo,
            global::G.GenerateMotionControlRequestOutput? motionControl
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
            global::System.Func<global::G.GenerateVideoRequestOutput?, TResult>? video = null,
            global::System.Func<global::G.GenerateTextToSpeechRequest?, TResult>? textToSpeech = null,
            global::System.Func<global::G.GenerateTextToSoundRequest?, TResult>? textToSound = null,
            global::System.Func<global::G.GenerateImageRequest?, TResult>? image = null,
            global::System.Func<global::G.GenerateImageUpscaleRequest?, TResult>? imageUpscale = null,
            global::System.Func<global::G.GenerateVideoUpscaleRequest?, TResult>? videoUpscale = null,
            global::System.Func<global::G.GenerateIsolatedAudioRequest?, TResult>? audioIsolation = null,
            global::System.Func<global::G.GenerateSpeechToSpeechRequest?, TResult>? speechToSpeech = null,
            global::System.Func<global::G.GenerateVoiceCloneRequest?, TResult>? voiceClone = null,
            global::System.Func<global::G.GenerateAudioFromVideoRequest?, TResult>? audioFromVideo = null,
            global::System.Func<global::G.GenerateVideoWithAudioRequest?, TResult>? videoWithAudio = null,
            global::System.Func<global::G.GenerateVideoToVideoRequest?, TResult>? videoToVideo = null,
            global::System.Func<global::G.GenerateMotionControlRequestOutput?, TResult>? motionControl = null,
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
            global::System.Action<global::G.GenerateVideoRequestOutput?>? video = null,
            global::System.Action<global::G.GenerateTextToSpeechRequest?>? textToSpeech = null,
            global::System.Action<global::G.GenerateTextToSoundRequest?>? textToSound = null,
            global::System.Action<global::G.GenerateImageRequest?>? image = null,
            global::System.Action<global::G.GenerateImageUpscaleRequest?>? imageUpscale = null,
            global::System.Action<global::G.GenerateVideoUpscaleRequest?>? videoUpscale = null,
            global::System.Action<global::G.GenerateIsolatedAudioRequest?>? audioIsolation = null,
            global::System.Action<global::G.GenerateSpeechToSpeechRequest?>? speechToSpeech = null,
            global::System.Action<global::G.GenerateVoiceCloneRequest?>? voiceClone = null,
            global::System.Action<global::G.GenerateAudioFromVideoRequest?>? audioFromVideo = null,
            global::System.Action<global::G.GenerateVideoWithAudioRequest?>? videoWithAudio = null,
            global::System.Action<global::G.GenerateVideoToVideoRequest?>? videoToVideo = null,
            global::System.Action<global::G.GenerateMotionControlRequestOutput?>? motionControl = null,
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
                typeof(global::G.GenerateVideoRequestOutput),
                TextToSpeech,
                typeof(global::G.GenerateTextToSpeechRequest),
                TextToSound,
                typeof(global::G.GenerateTextToSoundRequest),
                Image,
                typeof(global::G.GenerateImageRequest),
                ImageUpscale,
                typeof(global::G.GenerateImageUpscaleRequest),
                VideoUpscale,
                typeof(global::G.GenerateVideoUpscaleRequest),
                AudioIsolation,
                typeof(global::G.GenerateIsolatedAudioRequest),
                SpeechToSpeech,
                typeof(global::G.GenerateSpeechToSpeechRequest),
                VoiceClone,
                typeof(global::G.GenerateVoiceCloneRequest),
                AudioFromVideo,
                typeof(global::G.GenerateAudioFromVideoRequest),
                VideoWithAudio,
                typeof(global::G.GenerateVideoWithAudioRequest),
                VideoToVideo,
                typeof(global::G.GenerateVideoToVideoRequest),
                MotionControl,
                typeof(global::G.GenerateMotionControlRequestOutput),
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
        public bool Equals(Input other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.GenerateVideoRequestOutput?>.Default.Equals(Video, other.Video) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GenerateTextToSpeechRequest?>.Default.Equals(TextToSpeech, other.TextToSpeech) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GenerateTextToSoundRequest?>.Default.Equals(TextToSound, other.TextToSound) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GenerateImageRequest?>.Default.Equals(Image, other.Image) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GenerateImageUpscaleRequest?>.Default.Equals(ImageUpscale, other.ImageUpscale) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GenerateVideoUpscaleRequest?>.Default.Equals(VideoUpscale, other.VideoUpscale) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GenerateIsolatedAudioRequest?>.Default.Equals(AudioIsolation, other.AudioIsolation) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GenerateSpeechToSpeechRequest?>.Default.Equals(SpeechToSpeech, other.SpeechToSpeech) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GenerateVoiceCloneRequest?>.Default.Equals(VoiceClone, other.VoiceClone) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GenerateAudioFromVideoRequest?>.Default.Equals(AudioFromVideo, other.AudioFromVideo) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GenerateVideoWithAudioRequest?>.Default.Equals(VideoWithAudio, other.VideoWithAudio) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GenerateVideoToVideoRequest?>.Default.Equals(VideoToVideo, other.VideoToVideo) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GenerateMotionControlRequestOutput?>.Default.Equals(MotionControl, other.MotionControl) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Input obj1, Input obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Input>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Input obj1, Input obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Input o && Equals(o);
        }
    }
}
