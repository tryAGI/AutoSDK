//HintName: G.Models.RunStreamEvent.g.cs
using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly struct RunStreamEvent : global::System.IEquatable<RunStreamEvent>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RunStreamEventVariant1? Value1 { get; init; }
#else
        public global::G.RunStreamEventVariant1? Value1 { get; }
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
        public static implicit operator RunStreamEvent(global::G.RunStreamEventVariant1 value) => new RunStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RunStreamEventVariant1?(RunStreamEvent @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public RunStreamEvent(global::G.RunStreamEventVariant1? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RunStreamEventVariant2? Value2 { get; init; }
#else
        public global::G.RunStreamEventVariant2? Value2 { get; }
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
        public static implicit operator RunStreamEvent(global::G.RunStreamEventVariant2 value) => new RunStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RunStreamEventVariant2?(RunStreamEvent @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public RunStreamEvent(global::G.RunStreamEventVariant2? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RunStreamEventVariant3? Value3 { get; init; }
#else
        public global::G.RunStreamEventVariant3? Value3 { get; }
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
        public static implicit operator RunStreamEvent(global::G.RunStreamEventVariant3 value) => new RunStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RunStreamEventVariant3?(RunStreamEvent @this) => @this.Value3;

        /// <summary>
        /// 
        /// </summary>
        public RunStreamEvent(global::G.RunStreamEventVariant3? value)
        {
            Value3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RunStreamEventVariant4? Value4 { get; init; }
#else
        public global::G.RunStreamEventVariant4? Value4 { get; }
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
        public static implicit operator RunStreamEvent(global::G.RunStreamEventVariant4 value) => new RunStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RunStreamEventVariant4?(RunStreamEvent @this) => @this.Value4;

        /// <summary>
        /// 
        /// </summary>
        public RunStreamEvent(global::G.RunStreamEventVariant4? value)
        {
            Value4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RunStreamEventVariant5? Value5 { get; init; }
#else
        public global::G.RunStreamEventVariant5? Value5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value5))]
#endif
        public bool IsValue5 => Value5 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RunStreamEvent(global::G.RunStreamEventVariant5 value) => new RunStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RunStreamEventVariant5?(RunStreamEvent @this) => @this.Value5;

        /// <summary>
        /// 
        /// </summary>
        public RunStreamEvent(global::G.RunStreamEventVariant5? value)
        {
            Value5 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RunStreamEventVariant6? Value6 { get; init; }
#else
        public global::G.RunStreamEventVariant6? Value6 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value6))]
#endif
        public bool IsValue6 => Value6 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RunStreamEvent(global::G.RunStreamEventVariant6 value) => new RunStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RunStreamEventVariant6?(RunStreamEvent @this) => @this.Value6;

        /// <summary>
        /// 
        /// </summary>
        public RunStreamEvent(global::G.RunStreamEventVariant6? value)
        {
            Value6 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RunStreamEventVariant7? Value7 { get; init; }
#else
        public global::G.RunStreamEventVariant7? Value7 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value7))]
#endif
        public bool IsValue7 => Value7 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RunStreamEvent(global::G.RunStreamEventVariant7 value) => new RunStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RunStreamEventVariant7?(RunStreamEvent @this) => @this.Value7;

        /// <summary>
        /// 
        /// </summary>
        public RunStreamEvent(global::G.RunStreamEventVariant7? value)
        {
            Value7 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RunStreamEventVariant8? Value8 { get; init; }
#else
        public global::G.RunStreamEventVariant8? Value8 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value8))]
#endif
        public bool IsValue8 => Value8 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RunStreamEvent(global::G.RunStreamEventVariant8 value) => new RunStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RunStreamEventVariant8?(RunStreamEvent @this) => @this.Value8;

        /// <summary>
        /// 
        /// </summary>
        public RunStreamEvent(global::G.RunStreamEventVariant8? value)
        {
            Value8 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RunStreamEventVariant9? Value9 { get; init; }
#else
        public global::G.RunStreamEventVariant9? Value9 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value9))]
#endif
        public bool IsValue9 => Value9 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RunStreamEvent(global::G.RunStreamEventVariant9 value) => new RunStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RunStreamEventVariant9?(RunStreamEvent @this) => @this.Value9;

        /// <summary>
        /// 
        /// </summary>
        public RunStreamEvent(global::G.RunStreamEventVariant9? value)
        {
            Value9 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RunStreamEvent(
            global::G.RunStreamEventVariant1? value1,
            global::G.RunStreamEventVariant2? value2,
            global::G.RunStreamEventVariant3? value3,
            global::G.RunStreamEventVariant4? value4,
            global::G.RunStreamEventVariant5? value5,
            global::G.RunStreamEventVariant6? value6,
            global::G.RunStreamEventVariant7? value7,
            global::G.RunStreamEventVariant8? value8,
            global::G.RunStreamEventVariant9? value9
            )
        {
            Value1 = value1;
            Value2 = value2;
            Value3 = value3;
            Value4 = value4;
            Value5 = value5;
            Value6 = value6;
            Value7 = value7;
            Value8 = value8;
            Value9 = value9;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value9 as object ??
            Value8 as object ??
            Value7 as object ??
            Value6 as object ??
            Value5 as object ??
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
            return !IsValue1 && IsValue2 && IsValue3 && IsValue4 && IsValue5 && IsValue6 && IsValue7 && IsValue8 && IsValue9 || IsValue1 && !IsValue2 && IsValue3 && IsValue4 && IsValue5 && IsValue6 && IsValue7 && IsValue8 && IsValue9 || IsValue1 && IsValue2 && !IsValue3 && IsValue4 && IsValue5 && IsValue6 && IsValue7 && IsValue8 && IsValue9 || IsValue1 && IsValue2 && IsValue3 && !IsValue4 && IsValue5 && IsValue6 && IsValue7 && IsValue8 && IsValue9 || IsValue1 && IsValue2 && IsValue3 && IsValue4 && !IsValue5 && IsValue6 && IsValue7 && IsValue8 && IsValue9 || IsValue1 && IsValue2 && IsValue3 && IsValue4 && IsValue5 && !IsValue6 && IsValue7 && IsValue8 && IsValue9 || IsValue1 && IsValue2 && IsValue3 && IsValue4 && IsValue5 && IsValue6 && !IsValue7 && IsValue8 && IsValue9 || IsValue1 && IsValue2 && IsValue3 && IsValue4 && IsValue5 && IsValue6 && IsValue7 && !IsValue8 && IsValue9 || IsValue1 && IsValue2 && IsValue3 && IsValue4 && IsValue5 && IsValue6 && IsValue7 && IsValue8 && !IsValue9;
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(global::G.RunStreamEventVariant1),
                Value2,
                typeof(global::G.RunStreamEventVariant2),
                Value3,
                typeof(global::G.RunStreamEventVariant3),
                Value4,
                typeof(global::G.RunStreamEventVariant4),
                Value5,
                typeof(global::G.RunStreamEventVariant5),
                Value6,
                typeof(global::G.RunStreamEventVariant6),
                Value7,
                typeof(global::G.RunStreamEventVariant7),
                Value8,
                typeof(global::G.RunStreamEventVariant8),
                Value9,
                typeof(global::G.RunStreamEventVariant9),
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
        public bool Equals(RunStreamEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.RunStreamEventVariant1?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RunStreamEventVariant2?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RunStreamEventVariant3?>.Default.Equals(Value3, other.Value3) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RunStreamEventVariant4?>.Default.Equals(Value4, other.Value4) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RunStreamEventVariant5?>.Default.Equals(Value5, other.Value5) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RunStreamEventVariant6?>.Default.Equals(Value6, other.Value6) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RunStreamEventVariant7?>.Default.Equals(Value7, other.Value7) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RunStreamEventVariant8?>.Default.Equals(Value8, other.Value8) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RunStreamEventVariant9?>.Default.Equals(Value9, other.Value9) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RunStreamEvent obj1, RunStreamEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RunStreamEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RunStreamEvent obj1, RunStreamEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RunStreamEvent o && Equals(o);
        }
    }
}
