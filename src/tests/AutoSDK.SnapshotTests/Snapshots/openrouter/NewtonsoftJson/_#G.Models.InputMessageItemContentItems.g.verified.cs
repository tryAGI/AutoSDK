//HintName: G.Models.InputMessageItemContentItems.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct InputMessageItemContentItems : global::System.IEquatable<InputMessageItemContentItems>
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
        public global::G.InputMessageItemContentItems1? InputMessageItemContentItems1 { get; init; }
#else
        public global::G.InputMessageItemContentItems1? InputMessageItemContentItems1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputMessageItemContentItems1))]
#endif
        public bool IsInputMessageItemContentItems1 => InputMessageItemContentItems1 != null;

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
        public static implicit operator InputMessageItemContentItems(global::G.InputText value) => new InputMessageItemContentItems((global::G.InputText?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InputText?(InputMessageItemContentItems @this) => @this.InputText;

        /// <summary>
        /// 
        /// </summary>
        public InputMessageItemContentItems(global::G.InputText? value)
        {
            InputText = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputMessageItemContentItems(global::G.InputMessageItemContentItems1 value) => new InputMessageItemContentItems((global::G.InputMessageItemContentItems1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InputMessageItemContentItems1?(InputMessageItemContentItems @this) => @this.InputMessageItemContentItems1;

        /// <summary>
        /// 
        /// </summary>
        public InputMessageItemContentItems(global::G.InputMessageItemContentItems1? value)
        {
            InputMessageItemContentItems1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputMessageItemContentItems(global::G.InputFile value) => new InputMessageItemContentItems((global::G.InputFile?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InputFile?(InputMessageItemContentItems @this) => @this.InputFile;

        /// <summary>
        /// 
        /// </summary>
        public InputMessageItemContentItems(global::G.InputFile? value)
        {
            InputFile = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputMessageItemContentItems(global::G.InputAudio value) => new InputMessageItemContentItems((global::G.InputAudio?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InputAudio?(InputMessageItemContentItems @this) => @this.InputAudio;

        /// <summary>
        /// 
        /// </summary>
        public InputMessageItemContentItems(global::G.InputAudio? value)
        {
            InputAudio = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputMessageItemContentItems(global::G.InputVideo value) => new InputMessageItemContentItems((global::G.InputVideo?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InputVideo?(InputMessageItemContentItems @this) => @this.InputVideo;

        /// <summary>
        /// 
        /// </summary>
        public InputMessageItemContentItems(global::G.InputVideo? value)
        {
            InputVideo = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public InputMessageItemContentItems(
            global::G.InputText? inputText,
            global::G.InputMessageItemContentItems1? inputMessageItemContentItems1,
            global::G.InputFile? inputFile,
            global::G.InputAudio? inputAudio,
            global::G.InputVideo? inputVideo
            )
        {
            InputText = inputText;
            InputMessageItemContentItems1 = inputMessageItemContentItems1;
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
            InputMessageItemContentItems1 as object ??
            InputText as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            InputText?.ToString() ??
            InputMessageItemContentItems1?.ToString() ??
            InputFile?.ToString() ??
            InputAudio?.ToString() ??
            InputVideo?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsInputText && !IsInputMessageItemContentItems1 && !IsInputFile && !IsInputAudio && !IsInputVideo || !IsInputText && IsInputMessageItemContentItems1 && !IsInputFile && !IsInputAudio && !IsInputVideo || !IsInputText && !IsInputMessageItemContentItems1 && IsInputFile && !IsInputAudio && !IsInputVideo || !IsInputText && !IsInputMessageItemContentItems1 && !IsInputFile && IsInputAudio && !IsInputVideo || !IsInputText && !IsInputMessageItemContentItems1 && !IsInputFile && !IsInputAudio && IsInputVideo;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.InputText?, TResult>? inputText = null,
            global::System.Func<global::G.InputMessageItemContentItems1?, TResult>? inputMessageItemContentItems1 = null,
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
            else if (IsInputMessageItemContentItems1 && inputMessageItemContentItems1 != null)
            {
                return inputMessageItemContentItems1(InputMessageItemContentItems1!);
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
            global::System.Action<global::G.InputMessageItemContentItems1?>? inputMessageItemContentItems1 = null,
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
            else if (IsInputMessageItemContentItems1)
            {
                inputMessageItemContentItems1?.Invoke(InputMessageItemContentItems1!);
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
                InputMessageItemContentItems1,
                typeof(global::G.InputMessageItemContentItems1),
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
        public bool Equals(InputMessageItemContentItems other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.InputText?>.Default.Equals(InputText, other.InputText) &&
                global::System.Collections.Generic.EqualityComparer<global::G.InputMessageItemContentItems1?>.Default.Equals(InputMessageItemContentItems1, other.InputMessageItemContentItems1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.InputFile?>.Default.Equals(InputFile, other.InputFile) &&
                global::System.Collections.Generic.EqualityComparer<global::G.InputAudio?>.Default.Equals(InputAudio, other.InputAudio) &&
                global::System.Collections.Generic.EqualityComparer<global::G.InputVideo?>.Default.Equals(InputVideo, other.InputVideo) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(InputMessageItemContentItems obj1, InputMessageItemContentItems obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<InputMessageItemContentItems>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(InputMessageItemContentItems obj1, InputMessageItemContentItems obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InputMessageItemContentItems o && Equals(o);
        }
    }
}
