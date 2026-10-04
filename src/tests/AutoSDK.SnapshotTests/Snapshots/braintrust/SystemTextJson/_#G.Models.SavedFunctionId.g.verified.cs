//HintName: G.Models.SavedFunctionId.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Optional function identifier that produced the classification
    /// </summary>
    public readonly partial struct SavedFunctionId : global::System.IEquatable<SavedFunctionId>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.SavedFunctionIdFunction? Function { get; init; }
#else
        public global::G.SavedFunctionIdFunction? Function { get; }
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
            out global::G.SavedFunctionIdFunction? value)
        {
            value = Function;
            return IsFunction;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.SavedFunctionIdFunction PickFunction() => Function is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Function' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.SavedFunctionIdGlobal? Global { get; init; }
#else
        public global::G.SavedFunctionIdGlobal? Global { get; }
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
            out global::G.SavedFunctionIdGlobal? value)
        {
            value = Global;
            return IsGlobal;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.SavedFunctionIdGlobal PickGlobal() => Global is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Global' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SavedFunctionId(global::G.SavedFunctionIdFunction value) => new SavedFunctionId((global::G.SavedFunctionIdFunction?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SavedFunctionIdFunction?(SavedFunctionId @this) => @this.Function;

        /// <summary>
        /// 
        /// </summary>
        public SavedFunctionId(global::G.SavedFunctionIdFunction? value)
        {
            Function = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SavedFunctionId FromFunction(global::G.SavedFunctionIdFunction? value) => new SavedFunctionId(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SavedFunctionId(global::G.SavedFunctionIdGlobal value) => new SavedFunctionId((global::G.SavedFunctionIdGlobal?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SavedFunctionIdGlobal?(SavedFunctionId @this) => @this.Global;

        /// <summary>
        /// 
        /// </summary>
        public SavedFunctionId(global::G.SavedFunctionIdGlobal? value)
        {
            Global = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SavedFunctionId FromGlobal(global::G.SavedFunctionIdGlobal? value) => new SavedFunctionId(value);

        /// <summary>
        /// 
        /// </summary>
        public SavedFunctionId(
            global::G.SavedFunctionIdFunction? function,
            global::G.SavedFunctionIdGlobal? global
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
            global::System.Func<global::G.SavedFunctionIdFunction, TResult>? function = null,
            global::System.Func<global::G.SavedFunctionIdGlobal, TResult>? global = null,
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
            global::System.Action<global::G.SavedFunctionIdFunction>? function = null,

            global::System.Action<global::G.SavedFunctionIdGlobal>? global = null,
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
            global::System.Action<global::G.SavedFunctionIdFunction>? function = null,
            global::System.Action<global::G.SavedFunctionIdGlobal>? global = null,
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
                typeof(global::G.SavedFunctionIdFunction),
                Global,
                typeof(global::G.SavedFunctionIdGlobal),
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
        public bool Equals(SavedFunctionId other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.SavedFunctionIdFunction?>.Default.Equals(Function, other.Function) &&
                global::System.Collections.Generic.EqualityComparer<global::G.SavedFunctionIdGlobal?>.Default.Equals(Global, other.Global) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SavedFunctionId obj1, SavedFunctionId obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SavedFunctionId>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SavedFunctionId obj1, SavedFunctionId obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SavedFunctionId o && Equals(o);
        }
    }
}
