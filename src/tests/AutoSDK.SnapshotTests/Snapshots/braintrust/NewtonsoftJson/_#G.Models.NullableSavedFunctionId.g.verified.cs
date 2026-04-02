//HintName: G.Models.NullableSavedFunctionId.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Default preprocessor for this project. When set, functions that use preprocessors will use this instead of their built-in default.
    /// </summary>
    public readonly partial struct NullableSavedFunctionId : global::System.IEquatable<NullableSavedFunctionId>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.NullableSavedFunctionIdFunction? Function { get; init; }
#else
        public global::G.NullableSavedFunctionIdFunction? Function { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Function))]
#endif
        public bool IsFunction => Function != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.NullableSavedFunctionIdGlobal? Global { get; init; }
#else
        public global::G.NullableSavedFunctionIdGlobal? Global { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Global))]
#endif
        public bool IsGlobal => Global != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public object? NullableSavedFunctionIdVariant3 { get; init; }
#else
        public object? NullableSavedFunctionIdVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NullableSavedFunctionIdVariant3))]
#endif
        public bool IsNullableSavedFunctionIdVariant3 => NullableSavedFunctionIdVariant3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NullableSavedFunctionId(global::G.NullableSavedFunctionIdFunction value) => new NullableSavedFunctionId((global::G.NullableSavedFunctionIdFunction?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.NullableSavedFunctionIdFunction?(NullableSavedFunctionId @this) => @this.Function;

        /// <summary>
        /// 
        /// </summary>
        public NullableSavedFunctionId(global::G.NullableSavedFunctionIdFunction? value)
        {
            Function = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NullableSavedFunctionId(global::G.NullableSavedFunctionIdGlobal value) => new NullableSavedFunctionId((global::G.NullableSavedFunctionIdGlobal?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.NullableSavedFunctionIdGlobal?(NullableSavedFunctionId @this) => @this.Global;

        /// <summary>
        /// 
        /// </summary>
        public NullableSavedFunctionId(global::G.NullableSavedFunctionIdGlobal? value)
        {
            Global = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public NullableSavedFunctionId(
            global::G.NullableSavedFunctionIdFunction? function,
            global::G.NullableSavedFunctionIdGlobal? global,
            object? nullableSavedFunctionIdVariant3
            )
        {
            Function = function;
            Global = global;
            NullableSavedFunctionIdVariant3 = nullableSavedFunctionIdVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            NullableSavedFunctionIdVariant3 as object ??
            Global as object ??
            Function as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Function?.ToString() ??
            Global?.ToString() ??
            NullableSavedFunctionIdVariant3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsFunction || IsGlobal || IsNullableSavedFunctionIdVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.NullableSavedFunctionIdFunction?, TResult>? function = null,
            global::System.Func<global::G.NullableSavedFunctionIdGlobal?, TResult>? global = null,
            global::System.Func<object?, TResult>? nullableSavedFunctionIdVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFunction && function != null)
            {
                return function(Function!);
            }
            else if (IsGlobal && global != null)
            {
                return global(Global!);
            }
            else if (IsNullableSavedFunctionIdVariant3 && nullableSavedFunctionIdVariant3 != null)
            {
                return nullableSavedFunctionIdVariant3(NullableSavedFunctionIdVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.NullableSavedFunctionIdFunction?>? function = null,
            global::System.Action<global::G.NullableSavedFunctionIdGlobal?>? global = null,
            global::System.Action<object?>? nullableSavedFunctionIdVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFunction)
            {
                function?.Invoke(Function!);
            }
            else if (IsGlobal)
            {
                global?.Invoke(Global!);
            }
            else if (IsNullableSavedFunctionIdVariant3)
            {
                nullableSavedFunctionIdVariant3?.Invoke(NullableSavedFunctionIdVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Function,
                typeof(global::G.NullableSavedFunctionIdFunction),
                Global,
                typeof(global::G.NullableSavedFunctionIdGlobal),
                NullableSavedFunctionIdVariant3,
                typeof(object),
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
        public bool Equals(NullableSavedFunctionId other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.NullableSavedFunctionIdFunction?>.Default.Equals(Function, other.Function) &&
                global::System.Collections.Generic.EqualityComparer<global::G.NullableSavedFunctionIdGlobal?>.Default.Equals(Global, other.Global) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(NullableSavedFunctionIdVariant3, other.NullableSavedFunctionIdVariant3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(NullableSavedFunctionId obj1, NullableSavedFunctionId obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<NullableSavedFunctionId>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(NullableSavedFunctionId obj1, NullableSavedFunctionId obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is NullableSavedFunctionId o && Equals(o);
        }
    }
}
