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
        /// 
        /// </summary>
        public bool TryPickInputText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.InputText? value)
        {
            value = InputText;
            return IsInputText;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.InputText PickInputText() => InputText is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputText' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickEasyInputMessageContentOneOf0Items1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.EasyInputMessageContentOneOf0Items1? value)
        {
            value = EasyInputMessageContentOneOf0Items1;
            return IsEasyInputMessageContentOneOf0Items1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.EasyInputMessageContentOneOf0Items1 PickEasyInputMessageContentOneOf0Items1() => EasyInputMessageContentOneOf0Items1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'EasyInputMessageContentOneOf0Items1' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickInputFile(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.InputFile? value)
        {
            value = InputFile;
            return IsInputFile;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.InputFile PickInputFile() => InputFile is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputFile' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickInputAudio(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.InputAudio? value)
        {
            value = InputAudio;
            return IsInputAudio;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.InputAudio PickInputAudio() => InputAudio is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputAudio' but the value was {ToString()}.");

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
        public bool TryPickInputVideo(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.InputVideo? value)
        {
            value = InputVideo;
            return IsInputVideo;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.InputVideo PickInputVideo() => InputVideo is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputVideo' but the value was {ToString()}.");
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
        public static EasyInputMessageContentOneOf0Items FromInputText(global::G.InputText? value) => new EasyInputMessageContentOneOf0Items(value);

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
        public static EasyInputMessageContentOneOf0Items FromEasyInputMessageContentOneOf0Items1(global::G.EasyInputMessageContentOneOf0Items1? value) => new EasyInputMessageContentOneOf0Items(value);

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
        public static EasyInputMessageContentOneOf0Items FromInputFile(global::G.InputFile? value) => new EasyInputMessageContentOneOf0Items(value);

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
        public static EasyInputMessageContentOneOf0Items FromInputAudio(global::G.InputAudio? value) => new EasyInputMessageContentOneOf0Items(value);

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
        public static EasyInputMessageContentOneOf0Items FromInputVideo(global::G.InputVideo? value) => new EasyInputMessageContentOneOf0Items(value);

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
            global::System.Func<global::G.InputText, TResult>? inputText = null,
            global::System.Func<global::G.EasyInputMessageContentOneOf0Items1, TResult>? easyInputMessageContentOneOf0Items1 = null,
            global::System.Func<global::G.InputFile, TResult>? inputFile = null,
            global::System.Func<global::G.InputAudio, TResult>? inputAudio = null,
            global::System.Func<global::G.InputVideo, TResult>? inputVideo = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (InputText is { } __value0 && inputText != null)
            {
                return inputText(__value0);
            }
            else if (EasyInputMessageContentOneOf0Items1 is { } __value1 && easyInputMessageContentOneOf0Items1 != null)
            {
                return easyInputMessageContentOneOf0Items1(__value1);
            }
            else if (InputFile is { } __value2 && inputFile != null)
            {
                return inputFile(__value2);
            }
            else if (InputAudio is { } __value3 && inputAudio != null)
            {
                return inputAudio(__value3);
            }
            else if (InputVideo is { } __value4 && inputVideo != null)
            {
                return inputVideo(__value4);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.InputText>? inputText = null,

            global::System.Action<global::G.EasyInputMessageContentOneOf0Items1>? easyInputMessageContentOneOf0Items1 = null,

            global::System.Action<global::G.InputFile>? inputFile = null,

            global::System.Action<global::G.InputAudio>? inputAudio = null,

            global::System.Action<global::G.InputVideo>? inputVideo = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (InputText is { } __value0)
            {
                inputText?.Invoke(__value0);
            }
            else if (EasyInputMessageContentOneOf0Items1 is { } __value1)
            {
                easyInputMessageContentOneOf0Items1?.Invoke(__value1);
            }
            else if (InputFile is { } __value2)
            {
                inputFile?.Invoke(__value2);
            }
            else if (InputAudio is { } __value3)
            {
                inputAudio?.Invoke(__value3);
            }
            else if (InputVideo is { } __value4)
            {
                inputVideo?.Invoke(__value4);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::G.InputText>? inputText = null,
            global::System.Action<global::G.EasyInputMessageContentOneOf0Items1>? easyInputMessageContentOneOf0Items1 = null,
            global::System.Action<global::G.InputFile>? inputFile = null,
            global::System.Action<global::G.InputAudio>? inputAudio = null,
            global::System.Action<global::G.InputVideo>? inputVideo = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (InputText is { } __value0)
            {
                inputText?.Invoke(__value0);
            }
            else if (EasyInputMessageContentOneOf0Items1 is { } __value1)
            {
                easyInputMessageContentOneOf0Items1?.Invoke(__value1);
            }
            else if (InputFile is { } __value2)
            {
                inputFile?.Invoke(__value2);
            }
            else if (InputAudio is { } __value3)
            {
                inputAudio?.Invoke(__value3);
            }
            else if (InputVideo is { } __value4)
            {
                inputVideo?.Invoke(__value4);
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
