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
        public object? Value3 { get; init; }
#else
        public object? Value3 { get; }
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
            object? value3
            )
        {
            Function = function;
            Global = global;
            Value3 = value3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value3 as object ??
            Global as object ??
            Function as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Function?.ToString() ??
            Global?.ToString() ??
            Value3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsFunction || IsGlobal || IsValue3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.NullableSavedFunctionIdFunction?, TResult>? function = null,
            global::System.Func<global::G.NullableSavedFunctionIdGlobal?, TResult>? global = null,
            global::System.Func<object?, TResult>? value3 = null,
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
            else if (IsValue3 && value3 != null)
            {
                return value3(Value3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.NullableSavedFunctionIdFunction?>? function = null,
            global::System.Action<global::G.NullableSavedFunctionIdGlobal?>? global = null,
            global::System.Action<object?>? value3 = null,
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
            else if (IsValue3)
            {
                value3?.Invoke(Value3!);
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
                Value3,
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
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(Value3, other.Value3) 
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
