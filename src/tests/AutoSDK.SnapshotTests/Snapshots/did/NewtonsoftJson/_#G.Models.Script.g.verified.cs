//HintName: G.Models.Script.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Script : global::System.IEquatable<Script>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ScriptVariant1? ScriptVariant1 { get; init; }
#else
        public global::G.ScriptVariant1? ScriptVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ScriptVariant1))]
#endif
        public bool IsScriptVariant1 => ScriptVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ScriptVariant2? ScriptVariant2 { get; init; }
#else
        public global::G.ScriptVariant2? ScriptVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ScriptVariant2))]
#endif
        public bool IsScriptVariant2 => ScriptVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Script(global::G.ScriptVariant1 value) => new Script((global::G.ScriptVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ScriptVariant1?(Script @this) => @this.ScriptVariant1;

        /// <summary>
        /// 
        /// </summary>
        public Script(global::G.ScriptVariant1? value)
        {
            ScriptVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Script(global::G.ScriptVariant2 value) => new Script((global::G.ScriptVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ScriptVariant2?(Script @this) => @this.ScriptVariant2;

        /// <summary>
        /// 
        /// </summary>
        public Script(global::G.ScriptVariant2? value)
        {
            ScriptVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Script(
            global::G.ScriptVariant1? scriptVariant1,
            global::G.ScriptVariant2? scriptVariant2
            )
        {
            ScriptVariant1 = scriptVariant1;
            ScriptVariant2 = scriptVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ScriptVariant2 as object ??
            ScriptVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ScriptVariant1?.ToString() ??
            ScriptVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsScriptVariant1 || IsScriptVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ScriptVariant1?, TResult>? scriptVariant1 = null,
            global::System.Func<global::G.ScriptVariant2?, TResult>? scriptVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsScriptVariant1 && scriptVariant1 != null)
            {
                return scriptVariant1(ScriptVariant1!);
            }
            else if (IsScriptVariant2 && scriptVariant2 != null)
            {
                return scriptVariant2(ScriptVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ScriptVariant1?>? scriptVariant1 = null,
            global::System.Action<global::G.ScriptVariant2?>? scriptVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsScriptVariant1)
            {
                scriptVariant1?.Invoke(ScriptVariant1!);
            }
            else if (IsScriptVariant2)
            {
                scriptVariant2?.Invoke(ScriptVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ScriptVariant1,
                typeof(global::G.ScriptVariant1),
                ScriptVariant2,
                typeof(global::G.ScriptVariant2),
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
        public bool Equals(Script other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ScriptVariant1?>.Default.Equals(ScriptVariant1, other.ScriptVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ScriptVariant2?>.Default.Equals(ScriptVariant2, other.ScriptVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Script obj1, Script obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Script>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Script obj1, Script obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Script o && Equals(o);
        }
    }
}
