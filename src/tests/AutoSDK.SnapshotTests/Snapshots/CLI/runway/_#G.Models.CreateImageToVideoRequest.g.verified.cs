//HintName: G.Models.CreateImageToVideoRequest.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CreateImageToVideoRequest : global::System.IEquatable<CreateImageToVideoRequest>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateImageToVideoRequestGen4Turbo? Gen4Turbo { get; init; }
#else
        public global::G.CreateImageToVideoRequestGen4Turbo? Gen4Turbo { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Gen4Turbo))]
#endif
        public bool IsGen4Turbo => Gen4Turbo != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateImageToVideoRequestVeo31? Veo31 { get; init; }
#else
        public global::G.CreateImageToVideoRequestVeo31? Veo31 { get; }
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
        public global::G.CreateImageToVideoRequestGen3aTurbo? Gen3aTurbo { get; init; }
#else
        public global::G.CreateImageToVideoRequestGen3aTurbo? Gen3aTurbo { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Gen3aTurbo))]
#endif
        public bool IsGen3aTurbo => Gen3aTurbo != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateImageToVideoRequestVeo31Fast? Veo31Fast { get; init; }
#else
        public global::G.CreateImageToVideoRequestVeo31Fast? Veo31Fast { get; }
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
        public global::G.CreateImageToVideoRequestVeo3? Veo3 { get; init; }
#else
        public global::G.CreateImageToVideoRequestVeo3? Veo3 { get; }
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
        public static implicit operator CreateImageToVideoRequest(global::G.CreateImageToVideoRequestGen4Turbo value) => new CreateImageToVideoRequest((global::G.CreateImageToVideoRequestGen4Turbo?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateImageToVideoRequestGen4Turbo?(CreateImageToVideoRequest @this) => @this.Gen4Turbo;

        /// <summary>
        /// 
        /// </summary>
        public CreateImageToVideoRequest(global::G.CreateImageToVideoRequestGen4Turbo? value)
        {
            Gen4Turbo = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateImageToVideoRequest(global::G.CreateImageToVideoRequestVeo31 value) => new CreateImageToVideoRequest((global::G.CreateImageToVideoRequestVeo31?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateImageToVideoRequestVeo31?(CreateImageToVideoRequest @this) => @this.Veo31;

        /// <summary>
        /// 
        /// </summary>
        public CreateImageToVideoRequest(global::G.CreateImageToVideoRequestVeo31? value)
        {
            Veo31 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateImageToVideoRequest(global::G.CreateImageToVideoRequestGen3aTurbo value) => new CreateImageToVideoRequest((global::G.CreateImageToVideoRequestGen3aTurbo?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateImageToVideoRequestGen3aTurbo?(CreateImageToVideoRequest @this) => @this.Gen3aTurbo;

        /// <summary>
        /// 
        /// </summary>
        public CreateImageToVideoRequest(global::G.CreateImageToVideoRequestGen3aTurbo? value)
        {
            Gen3aTurbo = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateImageToVideoRequest(global::G.CreateImageToVideoRequestVeo31Fast value) => new CreateImageToVideoRequest((global::G.CreateImageToVideoRequestVeo31Fast?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateImageToVideoRequestVeo31Fast?(CreateImageToVideoRequest @this) => @this.Veo31Fast;

        /// <summary>
        /// 
        /// </summary>
        public CreateImageToVideoRequest(global::G.CreateImageToVideoRequestVeo31Fast? value)
        {
            Veo31Fast = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateImageToVideoRequest(global::G.CreateImageToVideoRequestVeo3 value) => new CreateImageToVideoRequest((global::G.CreateImageToVideoRequestVeo3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateImageToVideoRequestVeo3?(CreateImageToVideoRequest @this) => @this.Veo3;

        /// <summary>
        /// 
        /// </summary>
        public CreateImageToVideoRequest(global::G.CreateImageToVideoRequestVeo3? value)
        {
            Veo3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CreateImageToVideoRequest(
            global::G.CreateImageToVideoRequestGen4Turbo? gen4Turbo,
            global::G.CreateImageToVideoRequestVeo31? veo31,
            global::G.CreateImageToVideoRequestGen3aTurbo? gen3aTurbo,
            global::G.CreateImageToVideoRequestVeo31Fast? veo31Fast,
            global::G.CreateImageToVideoRequestVeo3? veo3
            )
        {
            Gen4Turbo = gen4Turbo;
            Veo31 = veo31;
            Gen3aTurbo = gen3aTurbo;
            Veo31Fast = veo31Fast;
            Veo3 = veo3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Veo3 as object ??
            Veo31Fast as object ??
            Gen3aTurbo as object ??
            Veo31 as object ??
            Gen4Turbo as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Gen4Turbo?.ToString() ??
            Veo31?.ToString() ??
            Gen3aTurbo?.ToString() ??
            Veo31Fast?.ToString() ??
            Veo3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsGen4Turbo && !IsVeo31 && !IsGen3aTurbo && !IsVeo31Fast && !IsVeo3 || !IsGen4Turbo && IsVeo31 && !IsGen3aTurbo && !IsVeo31Fast && !IsVeo3 || !IsGen4Turbo && !IsVeo31 && IsGen3aTurbo && !IsVeo31Fast && !IsVeo3 || !IsGen4Turbo && !IsVeo31 && !IsGen3aTurbo && IsVeo31Fast && !IsVeo3 || !IsGen4Turbo && !IsVeo31 && !IsGen3aTurbo && !IsVeo31Fast && IsVeo3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.CreateImageToVideoRequestGen4Turbo?, TResult>? gen4Turbo = null,
            global::System.Func<global::G.CreateImageToVideoRequestVeo31?, TResult>? veo31 = null,
            global::System.Func<global::G.CreateImageToVideoRequestGen3aTurbo?, TResult>? gen3aTurbo = null,
            global::System.Func<global::G.CreateImageToVideoRequestVeo31Fast?, TResult>? veo31Fast = null,
            global::System.Func<global::G.CreateImageToVideoRequestVeo3?, TResult>? veo3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGen4Turbo && gen4Turbo != null)
            {
                return gen4Turbo(Gen4Turbo!);
            }
            else if (IsVeo31 && veo31 != null)
            {
                return veo31(Veo31!);
            }
            else if (IsGen3aTurbo && gen3aTurbo != null)
            {
                return gen3aTurbo(Gen3aTurbo!);
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
            global::System.Action<global::G.CreateImageToVideoRequestGen4Turbo?>? gen4Turbo = null,
            global::System.Action<global::G.CreateImageToVideoRequestVeo31?>? veo31 = null,
            global::System.Action<global::G.CreateImageToVideoRequestGen3aTurbo?>? gen3aTurbo = null,
            global::System.Action<global::G.CreateImageToVideoRequestVeo31Fast?>? veo31Fast = null,
            global::System.Action<global::G.CreateImageToVideoRequestVeo3?>? veo3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGen4Turbo)
            {
                gen4Turbo?.Invoke(Gen4Turbo!);
            }
            else if (IsVeo31)
            {
                veo31?.Invoke(Veo31!);
            }
            else if (IsGen3aTurbo)
            {
                gen3aTurbo?.Invoke(Gen3aTurbo!);
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
                Gen4Turbo,
                typeof(global::G.CreateImageToVideoRequestGen4Turbo),
                Veo31,
                typeof(global::G.CreateImageToVideoRequestVeo31),
                Gen3aTurbo,
                typeof(global::G.CreateImageToVideoRequestGen3aTurbo),
                Veo31Fast,
                typeof(global::G.CreateImageToVideoRequestVeo31Fast),
                Veo3,
                typeof(global::G.CreateImageToVideoRequestVeo3),
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
        public bool Equals(CreateImageToVideoRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.CreateImageToVideoRequestGen4Turbo?>.Default.Equals(Gen4Turbo, other.Gen4Turbo) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateImageToVideoRequestVeo31?>.Default.Equals(Veo31, other.Veo31) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateImageToVideoRequestGen3aTurbo?>.Default.Equals(Gen3aTurbo, other.Gen3aTurbo) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateImageToVideoRequestVeo31Fast?>.Default.Equals(Veo31Fast, other.Veo31Fast) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateImageToVideoRequestVeo3?>.Default.Equals(Veo3, other.Veo3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateImageToVideoRequest obj1, CreateImageToVideoRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateImageToVideoRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateImageToVideoRequest obj1, CreateImageToVideoRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateImageToVideoRequest o && Equals(o);
        }
    }
}
