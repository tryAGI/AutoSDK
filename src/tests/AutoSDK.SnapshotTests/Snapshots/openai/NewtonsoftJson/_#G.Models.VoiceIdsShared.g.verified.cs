//HintName: G.Models.VoiceIdsShared.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Example: ash
    /// </summary>
    public readonly partial struct VoiceIdsShared : global::System.IEquatable<VoiceIdsShared>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? VoiceIdsSharedVariant1 { get; init; }
#else
        public string? VoiceIdsSharedVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VoiceIdsSharedVariant1))]
#endif
        public bool IsVoiceIdsSharedVariant1 => VoiceIdsSharedVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.VoiceIdsSharedEnum? Enum { get; init; }
#else
        public global::G.VoiceIdsSharedEnum? Enum { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Enum))]
#endif
        public bool IsEnum => Enum != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VoiceIdsShared(string value) => new VoiceIdsShared((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(VoiceIdsShared @this) => @this.VoiceIdsSharedVariant1;

        /// <summary>
        /// 
        /// </summary>
        public VoiceIdsShared(string? value)
        {
            VoiceIdsSharedVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VoiceIdsShared(global::G.VoiceIdsSharedEnum value) => new VoiceIdsShared((global::G.VoiceIdsSharedEnum?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.VoiceIdsSharedEnum?(VoiceIdsShared @this) => @this.Enum;

        /// <summary>
        /// 
        /// </summary>
        public VoiceIdsShared(global::G.VoiceIdsSharedEnum? value)
        {
            Enum = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public VoiceIdsShared(
            string? voiceIdsSharedVariant1,
            global::G.VoiceIdsSharedEnum? @enum
            )
        {
            VoiceIdsSharedVariant1 = voiceIdsSharedVariant1;
            Enum = @enum;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Enum as object ??
            VoiceIdsSharedVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            VoiceIdsSharedVariant1?.ToString() ??
            Enum?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsVoiceIdsSharedVariant1 || IsEnum;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? voiceIdsSharedVariant1 = null,
            global::System.Func<global::G.VoiceIdsSharedEnum?, TResult>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVoiceIdsSharedVariant1 && voiceIdsSharedVariant1 != null)
            {
                return voiceIdsSharedVariant1(VoiceIdsSharedVariant1!);
            }
            else if (IsEnum && @enum != null)
            {
                return @enum(Enum!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? voiceIdsSharedVariant1 = null,
            global::System.Action<global::G.VoiceIdsSharedEnum?>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVoiceIdsSharedVariant1)
            {
                voiceIdsSharedVariant1?.Invoke(VoiceIdsSharedVariant1!);
            }
            else if (IsEnum)
            {
                @enum?.Invoke(Enum!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                VoiceIdsSharedVariant1,
                typeof(string),
                Enum,
                typeof(global::G.VoiceIdsSharedEnum),
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
        public bool Equals(VoiceIdsShared other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(VoiceIdsSharedVariant1, other.VoiceIdsSharedVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.VoiceIdsSharedEnum?>.Default.Equals(Enum, other.Enum) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(VoiceIdsShared obj1, VoiceIdsShared obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<VoiceIdsShared>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(VoiceIdsShared obj1, VoiceIdsShared obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is VoiceIdsShared o && Equals(o);
        }
    }
}
