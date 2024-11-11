//HintName: G.Models.ReposGetContentResponse.g.cs
using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ReposGetContentResponse : global::System.IEquatable<ReposGetContentResponse>
    {
        /// <summary>
        /// A list of directory items
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::G.ContentDirectoryItem>? Value1 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::G.ContentDirectoryItem>? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        /// <summary>
        /// 
        /// </summary>
        public ReposGetContentResponse(global::System.Collections.Generic.IList<global::G.ContentDirectoryItem>? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// Content File
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ContentFile? Value2 { get; init; }
#else
        public global::G.ContentFile? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ReposGetContentResponse(global::G.ContentFile value) => new ReposGetContentResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ContentFile?(ReposGetContentResponse @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public ReposGetContentResponse(global::G.ContentFile? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// An object describing a symlink
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ContentSymlink? Value3 { get; init; }
#else
        public global::G.ContentSymlink? Value3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value3))]
#endif
        public bool IsValue3 => Value3 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ReposGetContentResponse(global::G.ContentSymlink value) => new ReposGetContentResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ContentSymlink?(ReposGetContentResponse @this) => @this.Value3;

        /// <summary>
        /// 
        /// </summary>
        public ReposGetContentResponse(global::G.ContentSymlink? value)
        {
            Value3 = value;
        }

        /// <summary>
        /// An object describing a submodule
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ContentSubmodule? Value4 { get; init; }
#else
        public global::G.ContentSubmodule? Value4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value4))]
#endif
        public bool IsValue4 => Value4 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ReposGetContentResponse(global::G.ContentSubmodule value) => new ReposGetContentResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ContentSubmodule?(ReposGetContentResponse @this) => @this.Value4;

        /// <summary>
        /// 
        /// </summary>
        public ReposGetContentResponse(global::G.ContentSubmodule? value)
        {
            Value4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ReposGetContentResponse(
            global::System.Collections.Generic.IList<global::G.ContentDirectoryItem>? value1,
            global::G.ContentFile? value2,
            global::G.ContentSymlink? value3,
            global::G.ContentSubmodule? value4
            )
        {
            Value1 = value1;
            Value2 = value2;
            Value3 = value3;
            Value4 = value4;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value4 as object ??
            Value3 as object ??
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 || !IsValue1 && IsValue2 && !IsValue3 && !IsValue4 || !IsValue1 && !IsValue2 && IsValue3 && !IsValue4 || !IsValue1 && !IsValue2 && !IsValue3 && IsValue4;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::System.Collections.Generic.IList<global::G.ContentDirectoryItem>?, TResult>? value1 = null,
            global::System.Func<global::G.ContentFile?, TResult>? value2 = null,
            global::System.Func<global::G.ContentSymlink?, TResult>? value3 = null,
            global::System.Func<global::G.ContentSubmodule?, TResult>? value4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1 && value1 != null)
            {
                return value1(Value1!);
            }
            else if (IsValue2 && value2 != null)
            {
                return value2(Value2!);
            }
            else if (IsValue3 && value3 != null)
            {
                return value3(Value3!);
            }
            else if (IsValue4 && value4 != null)
            {
                return value4(Value4!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::System.Collections.Generic.IList<global::G.ContentDirectoryItem>?>? value1 = null,
            global::System.Action<global::G.ContentFile?>? value2 = null,
            global::System.Action<global::G.ContentSymlink?>? value3 = null,
            global::System.Action<global::G.ContentSubmodule?>? value4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1)
            {
                value1?.Invoke(Value1!);
            }
            else if (IsValue2)
            {
                value2?.Invoke(Value2!);
            }
            else if (IsValue3)
            {
                value3?.Invoke(Value3!);
            }
            else if (IsValue4)
            {
                value4?.Invoke(Value4!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(global::System.Collections.Generic.IList<global::G.ContentDirectoryItem>),
                Value2,
                typeof(global::G.ContentFile),
                Value3,
                typeof(global::G.ContentSymlink),
                Value4,
                typeof(global::G.ContentSubmodule),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;
            return fields.Aggregate(offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(ReposGetContentResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::G.ContentDirectoryItem>?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ContentFile?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ContentSymlink?>.Default.Equals(Value3, other.Value3) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ContentSubmodule?>.Default.Equals(Value4, other.Value4) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ReposGetContentResponse obj1, ReposGetContentResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ReposGetContentResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ReposGetContentResponse obj1, ReposGetContentResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ReposGetContentResponse o && Equals(o);
        }
    }
}
