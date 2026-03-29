//HintName: G.Models.EasyInputMessageContentOneOf0Items.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct EasyInputMessageContentOneOf0Items : global::System.IEquatable<EasyInputMessageContentOneOf0Items>
    {
        /// <summary>
        /// Text input content item
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.InputText? InputText { get; init; }
#else
        public global::G.InputText? InputText { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputText))]
#endif
        public bool IsInputText => InputText != null;

        /// <summary>
        /// Image input content item
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.EasyInputMessageContentOneOf0Items1? EasyInputMessageContentOneOf0Items1 { get; init; }
#else
        public global::G.EasyInputMessageContentOneOf0Items1? EasyInputMessageContentOneOf0Items1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EasyInputMessageContentOneOf0Items1))]
#endif
        public bool IsEasyInputMessageContentOneOf0Items1 => EasyInputMessageContentOneOf0Items1 != null;

        /// <summary>
        /// File input content item
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.InputFile? InputFile { get; init; }
#else
        public global::G.InputFile? InputFile { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputFile))]
#endif
        public bool IsInputFile => InputFile != null;

        /// <summary>
        /// Audio input content item
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.InputAudio? InputAudio { get; init; }
#else
        public global::G.InputAudio? InputAudio { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputAudio))]
#endif
        public bool IsInputAudio => InputAudio != null;

        /// <summary>
        /// Video input content item
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.InputVideo? InputVideo { get; init; }
#else
        public global::G.InputVideo? InputVideo { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputVideo))]
#endif
        public bool IsInputVideo => InputVideo != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EasyInputMessageContentOneOf0Items(global::G.InputText value) => new EasyInputMessageContentOneOf0Items((global::G.InputText?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InputText?(EasyInputMessageContentOneOf0Items @this) => @this.InputText;

        /// <summary>
        /// 
        /// </summary>
        public EasyInputMessageContentOneOf0Items(global::G.InputText? value)
        {
            InputText = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EasyInputMessageContentOneOf0Items(global::G.EasyInputMessageContentOneOf0Items1 value) => new EasyInputMessageContentOneOf0Items((global::G.EasyInputMessageContentOneOf0Items1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.EasyInputMessageContentOneOf0Items1?(EasyInputMessageContentOneOf0Items @this) => @this.EasyInputMessageContentOneOf0Items1;

        /// <summary>
        /// 
        /// </summary>
        public EasyInputMessageContentOneOf0Items(global::G.EasyInputMessageContentOneOf0Items1? value)
        {
            EasyInputMessageContentOneOf0Items1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EasyInputMessageContentOneOf0Items(global::G.InputFile value) => new EasyInputMessageContentOneOf0Items((global::G.InputFile?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InputFile?(EasyInputMessageContentOneOf0Items @this) => @this.InputFile;

        /// <summary>
        /// 
        /// </summary>
        public EasyInputMessageContentOneOf0Items(global::G.InputFile? value)
        {
            InputFile = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EasyInputMessageContentOneOf0Items(global::G.InputAudio value) => new EasyInputMessageContentOneOf0Items((global::G.InputAudio?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InputAudio?(EasyInputMessageContentOneOf0Items @this) => @this.InputAudio;

        /// <summary>
        /// 
        /// </summary>
        public EasyInputMessageContentOneOf0Items(global::G.InputAudio? value)
        {
            InputAudio = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EasyInputMessageContentOneOf0Items(global::G.InputVideo value) => new EasyInputMessageContentOneOf0Items((global::G.InputVideo?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InputVideo?(EasyInputMessageContentOneOf0Items @this) => @this.InputVideo;

        /// <summary>
        /// 
        /// </summary>
        public EasyInputMessageContentOneOf0Items(global::G.InputVideo? value)
        {
            InputVideo = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public EasyInputMessageContentOneOf0Items(
            global::G.InputText? inputText,
            global::G.EasyInputMessageContentOneOf0Items1? easyInputMessageContentOneOf0Items1,
            global::G.InputFile? inputFile,
            global::G.InputAudio? inputAudio,
            global::G.InputVideo? inputVideo
            )
        {
            InputText = inputText;
            EasyInputMessageContentOneOf0Items1 = easyInputMessageContentOneOf0Items1;
            InputFile = inputFile;
            InputAudio = inputAudio;
            InputVideo = inputVideo;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            InputVideo as object ??
            InputAudio as object ??
            InputFile as object ??
            EasyInputMessageContentOneOf0Items1 as object ??
            InputText as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            InputText?.ToString() ??
            EasyInputMessageContentOneOf0Items1?.ToString() ??
            InputFile?.ToString() ??
            InputAudio?.ToString() ??
            InputVideo?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsInputText && !IsEasyInputMessageContentOneOf0Items1 && !IsInputFile && !IsInputAudio && !IsInputVideo || !IsInputText && IsEasyInputMessageContentOneOf0Items1 && !IsInputFile && !IsInputAudio && !IsInputVideo || !IsInputText && !IsEasyInputMessageContentOneOf0Items1 && IsInputFile && !IsInputAudio && !IsInputVideo || !IsInputText && !IsEasyInputMessageContentOneOf0Items1 && !IsInputFile && IsInputAudio && !IsInputVideo || !IsInputText && !IsEasyInputMessageContentOneOf0Items1 && !IsInputFile && !IsInputAudio && IsInputVideo;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.InputText?, TResult>? inputText = null,
            global::System.Func<global::G.EasyInputMessageContentOneOf0Items1?, TResult>? easyInputMessageContentOneOf0Items1 = null,
            global::System.Func<global::G.InputFile?, TResult>? inputFile = null,
            global::System.Func<global::G.InputAudio?, TResult>? inputAudio = null,
            global::System.Func<global::G.InputVideo?, TResult>? inputVideo = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputText && inputText != null)
            {
                return inputText(InputText!);
            }
            else if (IsEasyInputMessageContentOneOf0Items1 && easyInputMessageContentOneOf0Items1 != null)
            {
                return easyInputMessageContentOneOf0Items1(EasyInputMessageContentOneOf0Items1!);
            }
            else if (IsInputFile && inputFile != null)
            {
                return inputFile(InputFile!);
            }
            else if (IsInputAudio && inputAudio != null)
            {
                return inputAudio(InputAudio!);
            }
            else if (IsInputVideo && inputVideo != null)
            {
                return inputVideo(InputVideo!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.InputText?>? inputText = null,
            global::System.Action<global::G.EasyInputMessageContentOneOf0Items1?>? easyInputMessageContentOneOf0Items1 = null,
            global::System.Action<global::G.InputFile?>? inputFile = null,
            global::System.Action<global::G.InputAudio?>? inputAudio = null,
            global::System.Action<global::G.InputVideo?>? inputVideo = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputText)
            {
                inputText?.Invoke(InputText!);
            }
            else if (IsEasyInputMessageContentOneOf0Items1)
            {
                easyInputMessageContentOneOf0Items1?.Invoke(EasyInputMessageContentOneOf0Items1!);
            }
            else if (IsInputFile)
            {
                inputFile?.Invoke(InputFile!);
            }
            else if (IsInputAudio)
            {
                inputAudio?.Invoke(InputAudio!);
            }
            else if (IsInputVideo)
            {
                inputVideo?.Invoke(InputVideo!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                InputText,
                typeof(global::G.InputText),
                EasyInputMessageContentOneOf0Items1,
                typeof(global::G.EasyInputMessageContentOneOf0Items1),
                InputFile,
                typeof(global::G.InputFile),
                InputAudio,
                typeof(global::G.InputAudio),
                InputVideo,
                typeof(global::G.InputVideo),
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
        public bool Equals(EasyInputMessageContentOneOf0Items other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.InputText?>.Default.Equals(InputText, other.InputText) &&
                global::System.Collections.Generic.EqualityComparer<global::G.EasyInputMessageContentOneOf0Items1?>.Default.Equals(EasyInputMessageContentOneOf0Items1, other.EasyInputMessageContentOneOf0Items1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.InputFile?>.Default.Equals(InputFile, other.InputFile) &&
                global::System.Collections.Generic.EqualityComparer<global::G.InputAudio?>.Default.Equals(InputAudio, other.InputAudio) &&
                global::System.Collections.Generic.EqualityComparer<global::G.InputVideo?>.Default.Equals(InputVideo, other.InputVideo) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(EasyInputMessageContentOneOf0Items obj1, EasyInputMessageContentOneOf0Items obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EasyInputMessageContentOneOf0Items>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(EasyInputMessageContentOneOf0Items obj1, EasyInputMessageContentOneOf0Items obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EasyInputMessageContentOneOf0Items o && Equals(o);
        }
    }
}
