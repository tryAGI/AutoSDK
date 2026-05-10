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
        public global::G.CreateCharacterPerformanceRequestDiscriminatorModel? Model { get; }

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
        public bool TryPickActTwo(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CreateCharacterPerformanceRequestActTwo? value)
        {
            value = ActTwo;
            return IsActTwo;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateCharacterPerformanceRequestActTwo PickActTwo() => IsActTwo
            ? ActTwo!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ActTwo' but the value was {ToString()}.");
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
        public static CreateCharacterPerformanceRequest FromActTwo(global::G.CreateCharacterPerformanceRequestActTwo? value) => new CreateCharacterPerformanceRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public CreateCharacterPerformanceRequest(
            global::G.CreateCharacterPerformanceRequestDiscriminatorModel? model,
            global::G.CreateCharacterPerformanceRequestActTwo? actTwo
            )
        {
            Model = model;

            ActTwo = actTwo;
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
            global::System.Func<global::G.CreateCharacterPerformanceRequestActTwo, TResult>? actTwo = null,
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
            global::System.Action<global::G.CreateCharacterPerformanceRequestActTwo>? actTwo = null,
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
        public void Switch(
            global::System.Action<global::G.CreateCharacterPerformanceRequestActTwo>? actTwo = null,
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
