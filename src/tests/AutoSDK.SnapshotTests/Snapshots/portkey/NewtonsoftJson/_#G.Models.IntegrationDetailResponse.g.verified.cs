//HintName: G.Models.IntegrationDetailResponse.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct IntegrationDetailResponse : global::System.IEquatable<IntegrationDetailResponse>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.IntegrationList? List { get; init; }
#else
        public global::G.IntegrationList? List { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(List))]
#endif
        public bool IsList => List != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.IntegrationDetailResponseVariant2? IntegrationDetailResponseVariant2 { get; init; }
#else
        public global::G.IntegrationDetailResponseVariant2? IntegrationDetailResponseVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(IntegrationDetailResponseVariant2))]
#endif
        public bool IsIntegrationDetailResponseVariant2 => IntegrationDetailResponseVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IntegrationDetailResponse(global::G.IntegrationList value) => new IntegrationDetailResponse((global::G.IntegrationList?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.IntegrationList?(IntegrationDetailResponse @this) => @this.List;

        /// <summary>
        /// 
        /// </summary>
        public IntegrationDetailResponse(global::G.IntegrationList? value)
        {
            List = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IntegrationDetailResponse(global::G.IntegrationDetailResponseVariant2 value) => new IntegrationDetailResponse((global::G.IntegrationDetailResponseVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.IntegrationDetailResponseVariant2?(IntegrationDetailResponse @this) => @this.IntegrationDetailResponseVariant2;

        /// <summary>
        /// 
        /// </summary>
        public IntegrationDetailResponse(global::G.IntegrationDetailResponseVariant2? value)
        {
            IntegrationDetailResponseVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public IntegrationDetailResponse(
            global::G.IntegrationList? list,
            global::G.IntegrationDetailResponseVariant2? integrationDetailResponseVariant2
            )
        {
            List = list;
            IntegrationDetailResponseVariant2 = integrationDetailResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            IntegrationDetailResponseVariant2 as object ??
            List as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            List?.ToString() ??
            IntegrationDetailResponseVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsList && IsIntegrationDetailResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.IntegrationList?, TResult>? list = null,
            global::System.Func<global::G.IntegrationDetailResponseVariant2?, TResult>? integrationDetailResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsList && list != null)
            {
                return list(List!);
            }
            else if (IsIntegrationDetailResponseVariant2 && integrationDetailResponseVariant2 != null)
            {
                return integrationDetailResponseVariant2(IntegrationDetailResponseVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.IntegrationList?>? list = null,
            global::System.Action<global::G.IntegrationDetailResponseVariant2?>? integrationDetailResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsList)
            {
                list?.Invoke(List!);
            }
            else if (IsIntegrationDetailResponseVariant2)
            {
                integrationDetailResponseVariant2?.Invoke(IntegrationDetailResponseVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                List,
                typeof(global::G.IntegrationList),
                IntegrationDetailResponseVariant2,
                typeof(global::G.IntegrationDetailResponseVariant2),
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
        public bool Equals(IntegrationDetailResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.IntegrationList?>.Default.Equals(List, other.List) &&
                global::System.Collections.Generic.EqualityComparer<global::G.IntegrationDetailResponseVariant2?>.Default.Equals(IntegrationDetailResponseVariant2, other.IntegrationDetailResponseVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(IntegrationDetailResponse obj1, IntegrationDetailResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IntegrationDetailResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(IntegrationDetailResponse obj1, IntegrationDetailResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IntegrationDetailResponse o && Equals(o);
        }
    }
}
