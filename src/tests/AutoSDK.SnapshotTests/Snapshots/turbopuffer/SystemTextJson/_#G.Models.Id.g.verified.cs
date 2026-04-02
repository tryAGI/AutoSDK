//HintName: G.Models.Id.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// An identifier for a document.
    /// </summary>
    public readonly partial struct Id : global::System.IEquatable<Id>
    {
        /// <summary>
        /// A UUID.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Guid? Guid { get; init; }
#else
        public global::System.Guid? Guid { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Guid))]
#endif
        public bool IsGuid => Guid != null;

        /// <summary>
        /// A string ID.
        /// </summary>
#if NET6_0_OR_GREATER
        public string? IdVariant2 { get; init; }
#else
        public string? IdVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(IdVariant2))]
#endif
        public bool IsIdVariant2 => IdVariant2 != null;

        /// <summary>
        /// An integer ID.
        /// </summary>
#if NET6_0_OR_GREATER
        public int? IdVariant3 { get; init; }
#else
        public int? IdVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(IdVariant3))]
#endif
        public bool IsIdVariant3 => IdVariant3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Id(global::System.Guid value) => new Id((global::System.Guid?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::System.Guid?(Id @this) => @this.Guid;

        /// <summary>
        /// 
        /// </summary>
        public Id(global::System.Guid? value)
        {
            Guid = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Id(string value) => new Id((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(Id @this) => @this.IdVariant2;

        /// <summary>
        /// 
        /// </summary>
        public Id(string? value)
        {
            IdVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Id(int value) => new Id((int?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator int?(Id @this) => @this.IdVariant3;

        /// <summary>
        /// 
        /// </summary>
        public Id(int? value)
        {
            IdVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Id(
            global::System.Guid? guid,
            string? idVariant2,
            int? idVariant3
            )
        {
            Guid = guid;
            IdVariant2 = idVariant2;
            IdVariant3 = idVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            IdVariant3 as object ??
            IdVariant2 as object ??
            Guid as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Guid?.ToString() ??
            IdVariant2?.ToString() ??
            IdVariant3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsGuid || IsIdVariant2 || IsIdVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::System.Guid?, TResult>? guid = null,
            global::System.Func<string?, TResult>? idVariant2 = null,
            global::System.Func<int?, TResult>? idVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGuid && guid != null)
            {
                return guid(Guid!);
            }
            else if (IsIdVariant2 && idVariant2 != null)
            {
                return idVariant2(IdVariant2!);
            }
            else if (IsIdVariant3 && idVariant3 != null)
            {
                return idVariant3(IdVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::System.Guid?>? guid = null,
            global::System.Action<string?>? idVariant2 = null,
            global::System.Action<int?>? idVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGuid)
            {
                guid?.Invoke(Guid!);
            }
            else if (IsIdVariant2)
            {
                idVariant2?.Invoke(IdVariant2!);
            }
            else if (IsIdVariant3)
            {
                idVariant3?.Invoke(IdVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Guid,
                typeof(global::System.Guid),
                IdVariant2,
                typeof(string),
                IdVariant3,
                typeof(int),
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
        public bool Equals(Id other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::System.Guid?>.Default.Equals(Guid, other.Guid) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(IdVariant2, other.IdVariant2) &&
                global::System.Collections.Generic.EqualityComparer<int?>.Default.Equals(IdVariant3, other.IdVariant3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Id obj1, Id obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Id>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Id obj1, Id obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Id o && Equals(o);
        }
    }
}
