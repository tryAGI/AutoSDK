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
        public bool TryPickFunction(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.NullableSavedFunctionIdFunction? value)
        {
            value = Function;
            return IsFunction;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.NullableSavedFunctionIdFunction PickFunction() => Function is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Function' but the value was {ToString()}.");

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
        public bool TryPickGlobal(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.NullableSavedFunctionIdGlobal? value)
        {
            value = Global;
            return IsGlobal;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.NullableSavedFunctionIdGlobal PickGlobal() => Global is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Global' but the value was {ToString()}.");
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
        public static NullableSavedFunctionId FromFunction(global::G.NullableSavedFunctionIdFunction? value) => new NullableSavedFunctionId(value);

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
        public static NullableSavedFunctionId FromGlobal(global::G.NullableSavedFunctionIdGlobal? value) => new NullableSavedFunctionId(value);

        /// <summary>
        /// 
        /// </summary>
        public NullableSavedFunctionId(
            global::G.NullableSavedFunctionIdFunction? function,
            global::G.NullableSavedFunctionIdGlobal? global
            )
        {
            Function = function;
            Global = global;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Global as object ??
            Function as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Function?.ToString() ??
            Global?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsFunction || IsGlobal;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.NullableSavedFunctionIdFunction, TResult>? function = null,
            global::System.Func<global::G.NullableSavedFunctionIdGlobal, TResult>? global = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Function is { } __value0 && function != null)
            {
                return function(__value0);
            }
            else if (Global is { } __value1 && global != null)
            {
                return global(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.NullableSavedFunctionIdFunction>? function = null,

            global::System.Action<global::G.NullableSavedFunctionIdGlobal>? global = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Function is { } __value0)
            {
                function?.Invoke(__value0);
            }
            else if (Global is { } __value1)
            {
                global?.Invoke(__value1);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::G.NullableSavedFunctionIdFunction>? function = null,
            global::System.Action<global::G.NullableSavedFunctionIdGlobal>? global = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Function is { } __value0)
            {
                function?.Invoke(__value0);
            }
            else if (Global is { } __value1)
            {
                global?.Invoke(__value1);
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
                global::System.Collections.Generic.EqualityComparer<global::G.NullableSavedFunctionIdGlobal?>.Default.Equals(Global, other.Global) 
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
