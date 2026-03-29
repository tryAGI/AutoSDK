//HintName: G.Models.ElevenLabsGeneratedAssetOptions.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Generate assets using the third party ElevenLabs provider AI services.<br/>
    /// The following AI generation services are available: &lt;ul&gt;<br/>
    ///   &lt;li&gt;&lt;a href="#tocs_elevenlabstexttospeechoptions"&gt;ElevenLabsTextToSpeechOptions&lt;/a&gt;&lt;/li&gt;<br/>
    /// &lt;/ul&gt;
    /// </summary>
    public readonly partial struct ElevenLabsGeneratedAssetOptions : global::System.IEquatable<ElevenLabsGeneratedAssetOptions>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.ElevenLabsGeneratedAssetOptionsDiscriminatorType? Type { get; }

        /// <summary>
        /// Options for the ElevenLabs text-to-speech service. Set the text to be converted to speech and choose a voice to set the speaking style. The output will be generated as an MP3 audio file available at the URL returned in the response.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ElevenLabsTextToSpeechOptions? TextToSpeech { get; init; }
#else
        public global::G.ElevenLabsTextToSpeechOptions? TextToSpeech { get; }
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
        public static implicit operator ElevenLabsGeneratedAssetOptions(global::G.ElevenLabsTextToSpeechOptions value) => new ElevenLabsGeneratedAssetOptions((global::G.ElevenLabsTextToSpeechOptions?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ElevenLabsTextToSpeechOptions?(ElevenLabsGeneratedAssetOptions @this) => @this.TextToSpeech;

        /// <summary>
        /// 
        /// </summary>
        public ElevenLabsGeneratedAssetOptions(global::G.ElevenLabsTextToSpeechOptions? value)
        {
            TextToSpeech = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ElevenLabsGeneratedAssetOptions(
            global::G.ElevenLabsGeneratedAssetOptionsDiscriminatorType? type,
            global::G.ElevenLabsTextToSpeechOptions? textToSpeech
            )
        {
            Type = type;

            TextToSpeech = textToSpeech;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TextToSpeech as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            TextToSpeech?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTextToSpeech;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ElevenLabsTextToSpeechOptions?, TResult>? textToSpeech = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTextToSpeech && textToSpeech != null)
            {
                return textToSpeech(TextToSpeech!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ElevenLabsTextToSpeechOptions?>? textToSpeech = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTextToSpeech)
            {
                textToSpeech?.Invoke(TextToSpeech!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TextToSpeech,
                typeof(global::G.ElevenLabsTextToSpeechOptions),
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
        public bool Equals(ElevenLabsGeneratedAssetOptions other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ElevenLabsTextToSpeechOptions?>.Default.Equals(TextToSpeech, other.TextToSpeech) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ElevenLabsGeneratedAssetOptions obj1, ElevenLabsGeneratedAssetOptions obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ElevenLabsGeneratedAssetOptions>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ElevenLabsGeneratedAssetOptions obj1, ElevenLabsGeneratedAssetOptions obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ElevenLabsGeneratedAssetOptions o && Equals(o);
        }
    }
}
