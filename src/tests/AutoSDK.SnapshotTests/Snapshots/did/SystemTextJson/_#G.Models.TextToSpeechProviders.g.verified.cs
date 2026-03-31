//HintName: G.Models.TextToSpeechProviders.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct TextToSpeechProviders : global::System.IEquatable<TextToSpeechProviders>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TextToSpeechProvidersMicrosoft? Microsoft { get; init; }
#else
        public global::G.TextToSpeechProvidersMicrosoft? Microsoft { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Microsoft))]
#endif
        public bool IsMicrosoft => Microsoft != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TextToSpeechProvidersElevenLabs? ElevenLabs { get; init; }
#else
        public global::G.TextToSpeechProvidersElevenLabs? ElevenLabs { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ElevenLabs))]
#endif
        public bool IsElevenLabs => ElevenLabs != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TextToSpeechProvidersAmazon? Amazon { get; init; }
#else
        public global::G.TextToSpeechProvidersAmazon? Amazon { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Amazon))]
#endif
        public bool IsAmazon => Amazon != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TextToSpeechProvidersGoogle? Google { get; init; }
#else
        public global::G.TextToSpeechProvidersGoogle? Google { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Google))]
#endif
        public bool IsGoogle => Google != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TextToSpeechProvidersOpenAI? OpenAI { get; init; }
#else
        public global::G.TextToSpeechProvidersOpenAI? OpenAI { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenAI))]
#endif
        public bool IsOpenAI => OpenAI != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TextToSpeechProviders(global::G.TextToSpeechProvidersMicrosoft value) => new TextToSpeechProviders((global::G.TextToSpeechProvidersMicrosoft?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TextToSpeechProvidersMicrosoft?(TextToSpeechProviders @this) => @this.Microsoft;

        /// <summary>
        /// 
        /// </summary>
        public TextToSpeechProviders(global::G.TextToSpeechProvidersMicrosoft? value)
        {
            Microsoft = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TextToSpeechProviders(global::G.TextToSpeechProvidersElevenLabs value) => new TextToSpeechProviders((global::G.TextToSpeechProvidersElevenLabs?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TextToSpeechProvidersElevenLabs?(TextToSpeechProviders @this) => @this.ElevenLabs;

        /// <summary>
        /// 
        /// </summary>
        public TextToSpeechProviders(global::G.TextToSpeechProvidersElevenLabs? value)
        {
            ElevenLabs = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TextToSpeechProviders(global::G.TextToSpeechProvidersAmazon value) => new TextToSpeechProviders((global::G.TextToSpeechProvidersAmazon?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TextToSpeechProvidersAmazon?(TextToSpeechProviders @this) => @this.Amazon;

        /// <summary>
        /// 
        /// </summary>
        public TextToSpeechProviders(global::G.TextToSpeechProvidersAmazon? value)
        {
            Amazon = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TextToSpeechProviders(global::G.TextToSpeechProvidersGoogle value) => new TextToSpeechProviders((global::G.TextToSpeechProvidersGoogle?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TextToSpeechProvidersGoogle?(TextToSpeechProviders @this) => @this.Google;

        /// <summary>
        /// 
        /// </summary>
        public TextToSpeechProviders(global::G.TextToSpeechProvidersGoogle? value)
        {
            Google = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TextToSpeechProviders(global::G.TextToSpeechProvidersOpenAI value) => new TextToSpeechProviders((global::G.TextToSpeechProvidersOpenAI?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TextToSpeechProvidersOpenAI?(TextToSpeechProviders @this) => @this.OpenAI;

        /// <summary>
        /// 
        /// </summary>
        public TextToSpeechProviders(global::G.TextToSpeechProvidersOpenAI? value)
        {
            OpenAI = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public TextToSpeechProviders(
            global::G.TextToSpeechProvidersMicrosoft? microsoft,
            global::G.TextToSpeechProvidersElevenLabs? elevenLabs,
            global::G.TextToSpeechProvidersAmazon? amazon,
            global::G.TextToSpeechProvidersGoogle? google,
            global::G.TextToSpeechProvidersOpenAI? openAI
            )
        {
            Microsoft = microsoft;
            ElevenLabs = elevenLabs;
            Amazon = amazon;
            Google = google;
            OpenAI = openAI;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            OpenAI as object ??
            Google as object ??
            Amazon as object ??
            ElevenLabs as object ??
            Microsoft as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Microsoft?.ToString() ??
            ElevenLabs?.ToString() ??
            Amazon?.ToString() ??
            Google?.ToString() ??
            OpenAI?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMicrosoft || IsElevenLabs || IsAmazon || IsGoogle || IsOpenAI;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.TextToSpeechProvidersMicrosoft?, TResult>? microsoft = null,
            global::System.Func<global::G.TextToSpeechProvidersElevenLabs?, TResult>? elevenLabs = null,
            global::System.Func<global::G.TextToSpeechProvidersAmazon?, TResult>? amazon = null,
            global::System.Func<global::G.TextToSpeechProvidersGoogle?, TResult>? google = null,
            global::System.Func<global::G.TextToSpeechProvidersOpenAI?, TResult>? openAI = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMicrosoft && microsoft != null)
            {
                return microsoft(Microsoft!);
            }
            else if (IsElevenLabs && elevenLabs != null)
            {
                return elevenLabs(ElevenLabs!);
            }
            else if (IsAmazon && amazon != null)
            {
                return amazon(Amazon!);
            }
            else if (IsGoogle && google != null)
            {
                return google(Google!);
            }
            else if (IsOpenAI && openAI != null)
            {
                return openAI(OpenAI!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.TextToSpeechProvidersMicrosoft?>? microsoft = null,
            global::System.Action<global::G.TextToSpeechProvidersElevenLabs?>? elevenLabs = null,
            global::System.Action<global::G.TextToSpeechProvidersAmazon?>? amazon = null,
            global::System.Action<global::G.TextToSpeechProvidersGoogle?>? google = null,
            global::System.Action<global::G.TextToSpeechProvidersOpenAI?>? openAI = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMicrosoft)
            {
                microsoft?.Invoke(Microsoft!);
            }
            else if (IsElevenLabs)
            {
                elevenLabs?.Invoke(ElevenLabs!);
            }
            else if (IsAmazon)
            {
                amazon?.Invoke(Amazon!);
            }
            else if (IsGoogle)
            {
                google?.Invoke(Google!);
            }
            else if (IsOpenAI)
            {
                openAI?.Invoke(OpenAI!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Microsoft,
                typeof(global::G.TextToSpeechProvidersMicrosoft),
                ElevenLabs,
                typeof(global::G.TextToSpeechProvidersElevenLabs),
                Amazon,
                typeof(global::G.TextToSpeechProvidersAmazon),
                Google,
                typeof(global::G.TextToSpeechProvidersGoogle),
                OpenAI,
                typeof(global::G.TextToSpeechProvidersOpenAI),
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
        public bool Equals(TextToSpeechProviders other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.TextToSpeechProvidersMicrosoft?>.Default.Equals(Microsoft, other.Microsoft) &&
                global::System.Collections.Generic.EqualityComparer<global::G.TextToSpeechProvidersElevenLabs?>.Default.Equals(ElevenLabs, other.ElevenLabs) &&
                global::System.Collections.Generic.EqualityComparer<global::G.TextToSpeechProvidersAmazon?>.Default.Equals(Amazon, other.Amazon) &&
                global::System.Collections.Generic.EqualityComparer<global::G.TextToSpeechProvidersGoogle?>.Default.Equals(Google, other.Google) &&
                global::System.Collections.Generic.EqualityComparer<global::G.TextToSpeechProvidersOpenAI?>.Default.Equals(OpenAI, other.OpenAI) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TextToSpeechProviders obj1, TextToSpeechProviders obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TextToSpeechProviders>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TextToSpeechProviders obj1, TextToSpeechProviders obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TextToSpeechProviders o && Equals(o);
        }
    }
}
