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
#if NET6_0_OR_GREATER
        public object? SavedFunctionIdVariant3 { get; init; }
#else
        public object? SavedFunctionIdVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SavedFunctionIdVariant3))]
#endif
        public bool IsSavedFunctionIdVariant3 => SavedFunctionIdVariant3 != null;
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
        public SavedFunctionId(
            global::G.SavedFunctionIdFunction? function,
            global::G.SavedFunctionIdGlobal? global,
            object? savedFunctionIdVariant3
            )
        {
            Function = function;
            Global = global;
            SavedFunctionIdVariant3 = savedFunctionIdVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SavedFunctionIdVariant3 as object ??
            Global as object ??
            Function as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Function?.ToString() ??
            Global?.ToString() ??
            SavedFunctionIdVariant3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsFunction || IsGlobal || IsSavedFunctionIdVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.SavedFunctionIdFunction?, TResult>? function = null,
            global::System.Func<global::G.SavedFunctionIdGlobal?, TResult>? global = null,
            global::System.Func<object?, TResult>? savedFunctionIdVariant3 = null,
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
            else if (IsSavedFunctionIdVariant3 && savedFunctionIdVariant3 != null)
            {
                return savedFunctionIdVariant3(SavedFunctionIdVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.SavedFunctionIdFunction?>? function = null,
            global::System.Action<global::G.SavedFunctionIdGlobal?>? global = null,
            global::System.Action<object?>? savedFunctionIdVariant3 = null,
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
            else if (IsSavedFunctionIdVariant3)
            {
                savedFunctionIdVariant3?.Invoke(SavedFunctionIdVariant3!);
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
                SavedFunctionIdVariant3,
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
        public bool Equals(SavedFunctionId other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.SavedFunctionIdFunction?>.Default.Equals(Function, other.Function) &&
                global::System.Collections.Generic.EqualityComparer<global::G.SavedFunctionIdGlobal?>.Default.Equals(Global, other.Global) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(SavedFunctionIdVariant3, other.SavedFunctionIdVariant3) 
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
