//HintName: G.Models.CreateIceCandidateStreamRequest.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CreateIceCandidateStreamRequest : global::System.IEquatable<CreateIceCandidateStreamRequest>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AnyOf<global::G.CreateIceCandidateStreamRequestVariant1Variant1, object>? CreateIceCandidateStreamRequestVariant1 { get; init; }
#else
        public global::G.AnyOf<global::G.CreateIceCandidateStreamRequestVariant1Variant1, object>? CreateIceCandidateStreamRequestVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateIceCandidateStreamRequestVariant1))]
#endif
        public bool IsCreateIceCandidateStreamRequestVariant1 => CreateIceCandidateStreamRequestVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateIceCandidateStreamRequestVariant2? CreateIceCandidateStreamRequestVariant2 { get; init; }
#else
        public global::G.CreateIceCandidateStreamRequestVariant2? CreateIceCandidateStreamRequestVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateIceCandidateStreamRequestVariant2))]
#endif
        public bool IsCreateIceCandidateStreamRequestVariant2 => CreateIceCandidateStreamRequestVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateIceCandidateStreamRequest(global::G.AnyOf<global::G.CreateIceCandidateStreamRequestVariant1Variant1, object> value) => new CreateIceCandidateStreamRequest((global::G.AnyOf<global::G.CreateIceCandidateStreamRequestVariant1Variant1, object>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AnyOf<global::G.CreateIceCandidateStreamRequestVariant1Variant1, object>?(CreateIceCandidateStreamRequest @this) => @this.CreateIceCandidateStreamRequestVariant1;

        /// <summary>
        /// 
        /// </summary>
        public CreateIceCandidateStreamRequest(global::G.AnyOf<global::G.CreateIceCandidateStreamRequestVariant1Variant1, object>? value)
        {
            CreateIceCandidateStreamRequestVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateIceCandidateStreamRequest(global::G.CreateIceCandidateStreamRequestVariant2 value) => new CreateIceCandidateStreamRequest((global::G.CreateIceCandidateStreamRequestVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateIceCandidateStreamRequestVariant2?(CreateIceCandidateStreamRequest @this) => @this.CreateIceCandidateStreamRequestVariant2;

        /// <summary>
        /// 
        /// </summary>
        public CreateIceCandidateStreamRequest(global::G.CreateIceCandidateStreamRequestVariant2? value)
        {
            CreateIceCandidateStreamRequestVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CreateIceCandidateStreamRequest(
            global::G.AnyOf<global::G.CreateIceCandidateStreamRequestVariant1Variant1, object>? createIceCandidateStreamRequestVariant1,
            global::G.CreateIceCandidateStreamRequestVariant2? createIceCandidateStreamRequestVariant2
            )
        {
            CreateIceCandidateStreamRequestVariant1 = createIceCandidateStreamRequestVariant1;
            CreateIceCandidateStreamRequestVariant2 = createIceCandidateStreamRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CreateIceCandidateStreamRequestVariant2 as object ??
            CreateIceCandidateStreamRequestVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            CreateIceCandidateStreamRequestVariant1?.ToString() ??
            CreateIceCandidateStreamRequestVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCreateIceCandidateStreamRequestVariant1 && IsCreateIceCandidateStreamRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.AnyOf<global::G.CreateIceCandidateStreamRequestVariant1Variant1, object>?, TResult>? createIceCandidateStreamRequestVariant1 = null,
            global::System.Func<global::G.CreateIceCandidateStreamRequestVariant2?, TResult>? createIceCandidateStreamRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreateIceCandidateStreamRequestVariant1 && createIceCandidateStreamRequestVariant1 != null)
            {
                return createIceCandidateStreamRequestVariant1(CreateIceCandidateStreamRequestVariant1!);
            }
            else if (IsCreateIceCandidateStreamRequestVariant2 && createIceCandidateStreamRequestVariant2 != null)
            {
                return createIceCandidateStreamRequestVariant2(CreateIceCandidateStreamRequestVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.AnyOf<global::G.CreateIceCandidateStreamRequestVariant1Variant1, object>?>? createIceCandidateStreamRequestVariant1 = null,
            global::System.Action<global::G.CreateIceCandidateStreamRequestVariant2?>? createIceCandidateStreamRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreateIceCandidateStreamRequestVariant1)
            {
                createIceCandidateStreamRequestVariant1?.Invoke(CreateIceCandidateStreamRequestVariant1!);
            }
            else if (IsCreateIceCandidateStreamRequestVariant2)
            {
                createIceCandidateStreamRequestVariant2?.Invoke(CreateIceCandidateStreamRequestVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CreateIceCandidateStreamRequestVariant1,
                typeof(global::G.AnyOf<global::G.CreateIceCandidateStreamRequestVariant1Variant1, object>),
                CreateIceCandidateStreamRequestVariant2,
                typeof(global::G.CreateIceCandidateStreamRequestVariant2),
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
        public bool Equals(CreateIceCandidateStreamRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.AnyOf<global::G.CreateIceCandidateStreamRequestVariant1Variant1, object>?>.Default.Equals(CreateIceCandidateStreamRequestVariant1, other.CreateIceCandidateStreamRequestVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateIceCandidateStreamRequestVariant2?>.Default.Equals(CreateIceCandidateStreamRequestVariant2, other.CreateIceCandidateStreamRequestVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateIceCandidateStreamRequest obj1, CreateIceCandidateStreamRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateIceCandidateStreamRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateIceCandidateStreamRequest obj1, CreateIceCandidateStreamRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateIceCandidateStreamRequest o && Equals(o);
        }
    }
}
