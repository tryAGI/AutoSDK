//HintName: G.Models.CreateCharacterPerformanceRequest.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CreateCharacterPerformanceRequest : global::System.IEquatable<CreateCharacterPerformanceRequest>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateCharacterPerformanceRequestActTwo? ActTwo { get; init; }
#else
        public global::G.CreateCharacterPerformanceRequestActTwo? ActTwo { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ActTwo))]
#endif
        public bool IsActTwo => ActTwo != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateCharacterPerformanceRequest(global::G.CreateCharacterPerformanceRequestActTwo value) => new CreateCharacterPerformanceRequest((global::G.CreateCharacterPerformanceRequestActTwo?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateCharacterPerformanceRequestActTwo?(CreateCharacterPerformanceRequest @this) => @this.ActTwo;

        /// <summary>
        /// 
        /// </summary>
        public CreateCharacterPerformanceRequest(global::G.CreateCharacterPerformanceRequestActTwo? value)
        {
            ActTwo = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ActTwo as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ActTwo?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsActTwo;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.CreateCharacterPerformanceRequestActTwo?, TResult>? actTwo = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsActTwo && actTwo != null)
            {
                return actTwo(ActTwo!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.CreateCharacterPerformanceRequestActTwo?>? actTwo = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsActTwo)
            {
                actTwo?.Invoke(ActTwo!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ActTwo,
                typeof(global::G.CreateCharacterPerformanceRequestActTwo),
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
        public bool Equals(CreateCharacterPerformanceRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.CreateCharacterPerformanceRequestActTwo?>.Default.Equals(ActTwo, other.ActTwo) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateCharacterPerformanceRequest obj1, CreateCharacterPerformanceRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateCharacterPerformanceRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateCharacterPerformanceRequest obj1, CreateCharacterPerformanceRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateCharacterPerformanceRequest o && Equals(o);
        }
    }
}
