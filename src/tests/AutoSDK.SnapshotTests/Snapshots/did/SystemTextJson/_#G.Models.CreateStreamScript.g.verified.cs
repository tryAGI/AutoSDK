//HintName: G.Models.CreateStreamScript.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CreateStreamScript : global::System.IEquatable<CreateStreamScript>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateStreamScriptText? Text { get; init; }
#else
        public global::G.CreateStreamScriptText? Text { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateStreamScriptAudio? Audio { get; init; }
#else
        public global::G.CreateStreamScriptAudio? Audio { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Audio))]
#endif
        public bool IsAudio => Audio != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateStreamScript(global::G.CreateStreamScriptText value) => new CreateStreamScript((global::G.CreateStreamScriptText?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateStreamScriptText?(CreateStreamScript @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public CreateStreamScript(global::G.CreateStreamScriptText? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateStreamScript(global::G.CreateStreamScriptAudio value) => new CreateStreamScript((global::G.CreateStreamScriptAudio?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateStreamScriptAudio?(CreateStreamScript @this) => @this.Audio;

        /// <summary>
        /// 
        /// </summary>
        public CreateStreamScript(global::G.CreateStreamScriptAudio? value)
        {
            Audio = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CreateStreamScript(
            global::G.CreateStreamScriptText? text,
            global::G.CreateStreamScriptAudio? audio
            )
        {
            Text = text;
            Audio = audio;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Audio as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            Audio?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText || IsAudio;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.CreateStreamScriptText?, TResult>? text = null,
            global::System.Func<global::G.CreateStreamScriptAudio?, TResult>? audio = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText && text != null)
            {
                return text(Text!);
            }
            else if (IsAudio && audio != null)
            {
                return audio(Audio!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.CreateStreamScriptText?>? text = null,
            global::System.Action<global::G.CreateStreamScriptAudio?>? audio = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsAudio)
            {
                audio?.Invoke(Audio!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Text,
                typeof(global::G.CreateStreamScriptText),
                Audio,
                typeof(global::G.CreateStreamScriptAudio),
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
        public bool Equals(CreateStreamScript other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.CreateStreamScriptText?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateStreamScriptAudio?>.Default.Equals(Audio, other.Audio) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateStreamScript obj1, CreateStreamScript obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateStreamScript>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateStreamScript obj1, CreateStreamScript obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateStreamScript o && Equals(o);
        }
    }
}
