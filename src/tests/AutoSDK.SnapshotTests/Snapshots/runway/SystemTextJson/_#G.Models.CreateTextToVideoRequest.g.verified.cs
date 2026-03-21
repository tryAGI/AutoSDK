//HintName: G.Models.CreateTextToVideoRequest.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CreateTextToVideoRequest : global::System.IEquatable<CreateTextToVideoRequest>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateTextToVideoRequestVeo31? Veo31 { get; init; }
#else
        public global::G.CreateTextToVideoRequestVeo31? Veo31 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Veo31))]
#endif
        public bool IsVeo31 => Veo31 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateTextToVideoRequestVeo31Fast? Veo31Fast { get; init; }
#else
        public global::G.CreateTextToVideoRequestVeo31Fast? Veo31Fast { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Veo31Fast))]
#endif
        public bool IsVeo31Fast => Veo31Fast != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateTextToVideoRequestVeo3? Veo3 { get; init; }
#else
        public global::G.CreateTextToVideoRequestVeo3? Veo3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Veo3))]
#endif
        public bool IsVeo3 => Veo3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateTextToVideoRequest(global::G.CreateTextToVideoRequestVeo31 value) => new CreateTextToVideoRequest((global::G.CreateTextToVideoRequestVeo31?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateTextToVideoRequestVeo31?(CreateTextToVideoRequest @this) => @this.Veo31;

        /// <summary>
        /// 
        /// </summary>
        public CreateTextToVideoRequest(global::G.CreateTextToVideoRequestVeo31? value)
        {
            Veo31 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateTextToVideoRequest(global::G.CreateTextToVideoRequestVeo31Fast value) => new CreateTextToVideoRequest((global::G.CreateTextToVideoRequestVeo31Fast?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateTextToVideoRequestVeo31Fast?(CreateTextToVideoRequest @this) => @this.Veo31Fast;

        /// <summary>
        /// 
        /// </summary>
        public CreateTextToVideoRequest(global::G.CreateTextToVideoRequestVeo31Fast? value)
        {
            Veo31Fast = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateTextToVideoRequest(global::G.CreateTextToVideoRequestVeo3 value) => new CreateTextToVideoRequest((global::G.CreateTextToVideoRequestVeo3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateTextToVideoRequestVeo3?(CreateTextToVideoRequest @this) => @this.Veo3;

        /// <summary>
        /// 
        /// </summary>
        public CreateTextToVideoRequest(global::G.CreateTextToVideoRequestVeo3? value)
        {
            Veo3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CreateTextToVideoRequest(
            global::G.CreateTextToVideoRequestVeo31? veo31,
            global::G.CreateTextToVideoRequestVeo31Fast? veo31Fast,
            global::G.CreateTextToVideoRequestVeo3? veo3
            )
        {
            Veo31 = veo31;
            Veo31Fast = veo31Fast;
            Veo3 = veo3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Veo3 as object ??
            Veo31Fast as object ??
            Veo31 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Veo31?.ToString() ??
            Veo31Fast?.ToString() ??
            Veo3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsVeo31 && !IsVeo31Fast && !IsVeo3 || !IsVeo31 && IsVeo31Fast && !IsVeo3 || !IsVeo31 && !IsVeo31Fast && IsVeo3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.CreateTextToVideoRequestVeo31?, TResult>? veo31 = null,
            global::System.Func<global::G.CreateTextToVideoRequestVeo31Fast?, TResult>? veo31Fast = null,
            global::System.Func<global::G.CreateTextToVideoRequestVeo3?, TResult>? veo3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVeo31 && veo31 != null)
            {
                return veo31(Veo31!);
            }
            else if (IsVeo31Fast && veo31Fast != null)
            {
                return veo31Fast(Veo31Fast!);
            }
            else if (IsVeo3 && veo3 != null)
            {
                return veo3(Veo3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.CreateTextToVideoRequestVeo31?>? veo31 = null,
            global::System.Action<global::G.CreateTextToVideoRequestVeo31Fast?>? veo31Fast = null,
            global::System.Action<global::G.CreateTextToVideoRequestVeo3?>? veo3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVeo31)
            {
                veo31?.Invoke(Veo31!);
            }
            else if (IsVeo31Fast)
            {
                veo31Fast?.Invoke(Veo31Fast!);
            }
            else if (IsVeo3)
            {
                veo3?.Invoke(Veo3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Veo31,
                typeof(global::G.CreateTextToVideoRequestVeo31),
                Veo31Fast,
                typeof(global::G.CreateTextToVideoRequestVeo31Fast),
                Veo3,
                typeof(global::G.CreateTextToVideoRequestVeo3),
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
        public bool Equals(CreateTextToVideoRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.CreateTextToVideoRequestVeo31?>.Default.Equals(Veo31, other.Veo31) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateTextToVideoRequestVeo31Fast?>.Default.Equals(Veo31Fast, other.Veo31Fast) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateTextToVideoRequestVeo3?>.Default.Equals(Veo3, other.Veo3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateTextToVideoRequest obj1, CreateTextToVideoRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateTextToVideoRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateTextToVideoRequest obj1, CreateTextToVideoRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateTextToVideoRequest o && Equals(o);
        }
    }
}
