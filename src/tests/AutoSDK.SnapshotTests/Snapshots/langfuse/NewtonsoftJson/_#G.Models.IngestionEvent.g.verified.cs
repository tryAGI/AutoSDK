//HintName: G.Models.IngestionEvent.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct IngestionEvent : global::System.IEquatable<IngestionEvent>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AllOf<global::G.IngestionEventVariant12, global::G.TraceEvent>? Value1 { get; init; }
#else
        public global::G.AllOf<global::G.IngestionEventVariant12, global::G.TraceEvent>? Value1 { get; }
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
#if NET6_0_OR_GREATER
        public global::G.AllOf<global::G.IngestionEventVariant22, global::G.ScoreEvent>? Value2 { get; init; }
#else
        public global::G.AllOf<global::G.IngestionEventVariant22, global::G.ScoreEvent>? Value2 { get; }
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
#if NET6_0_OR_GREATER
        public global::G.AllOf<global::G.IngestionEventVariant32, global::G.CreateSpanEvent>? Value3 { get; init; }
#else
        public global::G.AllOf<global::G.IngestionEventVariant32, global::G.CreateSpanEvent>? Value3 { get; }
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
#if NET6_0_OR_GREATER
        public global::G.AllOf<global::G.IngestionEventVariant42, global::G.UpdateSpanEvent>? Value4 { get; init; }
#else
        public global::G.AllOf<global::G.IngestionEventVariant42, global::G.UpdateSpanEvent>? Value4 { get; }
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
#if NET6_0_OR_GREATER
        public global::G.AllOf<global::G.IngestionEventVariant52, global::G.CreateGenerationEvent>? Value5 { get; init; }
#else
        public global::G.AllOf<global::G.IngestionEventVariant52, global::G.CreateGenerationEvent>? Value5 { get; }
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
#if NET6_0_OR_GREATER
        public global::G.AllOf<global::G.IngestionEventVariant62, global::G.UpdateGenerationEvent>? Value6 { get; init; }
#else
        public global::G.AllOf<global::G.IngestionEventVariant62, global::G.UpdateGenerationEvent>? Value6 { get; }
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
#if NET6_0_OR_GREATER
        public global::G.AllOf<global::G.IngestionEventVariant72, global::G.CreateEventEvent>? Value7 { get; init; }
#else
        public global::G.AllOf<global::G.IngestionEventVariant72, global::G.CreateEventEvent>? Value7 { get; }
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
#if NET6_0_OR_GREATER
        public global::G.AllOf<global::G.IngestionEventVariant82, global::G.SDKLogEvent>? Value8 { get; init; }
#else
        public global::G.AllOf<global::G.IngestionEventVariant82, global::G.SDKLogEvent>? Value8 { get; }
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
#if NET6_0_OR_GREATER
        public global::G.AllOf<global::G.IngestionEventVariant92, global::G.CreateObservationEvent>? Value9 { get; init; }
#else
        public global::G.AllOf<global::G.IngestionEventVariant92, global::G.CreateObservationEvent>? Value9 { get; }
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
#if NET6_0_OR_GREATER
        public global::G.AllOf<global::G.IngestionEventVariant102, global::G.UpdateObservationEvent>? Value10 { get; init; }
#else
        public global::G.AllOf<global::G.IngestionEventVariant102, global::G.UpdateObservationEvent>? Value10 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value10))]
#endif
        public bool IsValue10 => Value10 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IngestionEvent(global::G.AllOf<global::G.IngestionEventVariant12, global::G.TraceEvent> value) => new IngestionEvent((global::G.AllOf<global::G.IngestionEventVariant12, global::G.TraceEvent>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AllOf<global::G.IngestionEventVariant12, global::G.TraceEvent>?(IngestionEvent @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public IngestionEvent(global::G.AllOf<global::G.IngestionEventVariant12, global::G.TraceEvent>? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IngestionEvent(global::G.AllOf<global::G.IngestionEventVariant22, global::G.ScoreEvent> value) => new IngestionEvent((global::G.AllOf<global::G.IngestionEventVariant22, global::G.ScoreEvent>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AllOf<global::G.IngestionEventVariant22, global::G.ScoreEvent>?(IngestionEvent @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public IngestionEvent(global::G.AllOf<global::G.IngestionEventVariant22, global::G.ScoreEvent>? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IngestionEvent(global::G.AllOf<global::G.IngestionEventVariant32, global::G.CreateSpanEvent> value) => new IngestionEvent((global::G.AllOf<global::G.IngestionEventVariant32, global::G.CreateSpanEvent>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AllOf<global::G.IngestionEventVariant32, global::G.CreateSpanEvent>?(IngestionEvent @this) => @this.Value3;

        /// <summary>
        /// 
        /// </summary>
        public IngestionEvent(global::G.AllOf<global::G.IngestionEventVariant32, global::G.CreateSpanEvent>? value)
        {
            Value3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IngestionEvent(global::G.AllOf<global::G.IngestionEventVariant42, global::G.UpdateSpanEvent> value) => new IngestionEvent((global::G.AllOf<global::G.IngestionEventVariant42, global::G.UpdateSpanEvent>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AllOf<global::G.IngestionEventVariant42, global::G.UpdateSpanEvent>?(IngestionEvent @this) => @this.Value4;

        /// <summary>
        /// 
        /// </summary>
        public IngestionEvent(global::G.AllOf<global::G.IngestionEventVariant42, global::G.UpdateSpanEvent>? value)
        {
            Value4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IngestionEvent(global::G.AllOf<global::G.IngestionEventVariant52, global::G.CreateGenerationEvent> value) => new IngestionEvent((global::G.AllOf<global::G.IngestionEventVariant52, global::G.CreateGenerationEvent>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AllOf<global::G.IngestionEventVariant52, global::G.CreateGenerationEvent>?(IngestionEvent @this) => @this.Value5;

        /// <summary>
        /// 
        /// </summary>
        public IngestionEvent(global::G.AllOf<global::G.IngestionEventVariant52, global::G.CreateGenerationEvent>? value)
        {
            Value5 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IngestionEvent(global::G.AllOf<global::G.IngestionEventVariant62, global::G.UpdateGenerationEvent> value) => new IngestionEvent((global::G.AllOf<global::G.IngestionEventVariant62, global::G.UpdateGenerationEvent>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AllOf<global::G.IngestionEventVariant62, global::G.UpdateGenerationEvent>?(IngestionEvent @this) => @this.Value6;

        /// <summary>
        /// 
        /// </summary>
        public IngestionEvent(global::G.AllOf<global::G.IngestionEventVariant62, global::G.UpdateGenerationEvent>? value)
        {
            Value6 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IngestionEvent(global::G.AllOf<global::G.IngestionEventVariant72, global::G.CreateEventEvent> value) => new IngestionEvent((global::G.AllOf<global::G.IngestionEventVariant72, global::G.CreateEventEvent>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AllOf<global::G.IngestionEventVariant72, global::G.CreateEventEvent>?(IngestionEvent @this) => @this.Value7;

        /// <summary>
        /// 
        /// </summary>
        public IngestionEvent(global::G.AllOf<global::G.IngestionEventVariant72, global::G.CreateEventEvent>? value)
        {
            Value7 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IngestionEvent(global::G.AllOf<global::G.IngestionEventVariant82, global::G.SDKLogEvent> value) => new IngestionEvent((global::G.AllOf<global::G.IngestionEventVariant82, global::G.SDKLogEvent>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AllOf<global::G.IngestionEventVariant82, global::G.SDKLogEvent>?(IngestionEvent @this) => @this.Value8;

        /// <summary>
        /// 
        /// </summary>
        public IngestionEvent(global::G.AllOf<global::G.IngestionEventVariant82, global::G.SDKLogEvent>? value)
        {
            Value8 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IngestionEvent(global::G.AllOf<global::G.IngestionEventVariant92, global::G.CreateObservationEvent> value) => new IngestionEvent((global::G.AllOf<global::G.IngestionEventVariant92, global::G.CreateObservationEvent>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AllOf<global::G.IngestionEventVariant92, global::G.CreateObservationEvent>?(IngestionEvent @this) => @this.Value9;

        /// <summary>
        /// 
        /// </summary>
        public IngestionEvent(global::G.AllOf<global::G.IngestionEventVariant92, global::G.CreateObservationEvent>? value)
        {
            Value9 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IngestionEvent(global::G.AllOf<global::G.IngestionEventVariant102, global::G.UpdateObservationEvent> value) => new IngestionEvent((global::G.AllOf<global::G.IngestionEventVariant102, global::G.UpdateObservationEvent>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AllOf<global::G.IngestionEventVariant102, global::G.UpdateObservationEvent>?(IngestionEvent @this) => @this.Value10;

        /// <summary>
        /// 
        /// </summary>
        public IngestionEvent(global::G.AllOf<global::G.IngestionEventVariant102, global::G.UpdateObservationEvent>? value)
        {
            Value10 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public IngestionEvent(
            global::G.AllOf<global::G.IngestionEventVariant12, global::G.TraceEvent>? value1,
            global::G.AllOf<global::G.IngestionEventVariant22, global::G.ScoreEvent>? value2,
            global::G.AllOf<global::G.IngestionEventVariant32, global::G.CreateSpanEvent>? value3,
            global::G.AllOf<global::G.IngestionEventVariant42, global::G.UpdateSpanEvent>? value4,
            global::G.AllOf<global::G.IngestionEventVariant52, global::G.CreateGenerationEvent>? value5,
            global::G.AllOf<global::G.IngestionEventVariant62, global::G.UpdateGenerationEvent>? value6,
            global::G.AllOf<global::G.IngestionEventVariant72, global::G.CreateEventEvent>? value7,
            global::G.AllOf<global::G.IngestionEventVariant82, global::G.SDKLogEvent>? value8,
            global::G.AllOf<global::G.IngestionEventVariant92, global::G.CreateObservationEvent>? value9,
            global::G.AllOf<global::G.IngestionEventVariant102, global::G.UpdateObservationEvent>? value10
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
            Value10 = value10;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value10 as object ??
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
        public override string? ToString() =>
            Value1?.ToString() ??
            Value2?.ToString() ??
            Value3?.ToString() ??
            Value4?.ToString() ??
            Value5?.ToString() ??
            Value6?.ToString() ??
            Value7?.ToString() ??
            Value8?.ToString() ??
            Value9?.ToString() ??
            Value10?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 || !IsValue1 && IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 || !IsValue1 && !IsValue2 && IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 || !IsValue1 && !IsValue2 && !IsValue3 && IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && IsValue8 && !IsValue9 && !IsValue10 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && IsValue9 && !IsValue10 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && IsValue10;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.AllOf<global::G.IngestionEventVariant12, global::G.TraceEvent>?, TResult>? value1 = null,
            global::System.Func<global::G.AllOf<global::G.IngestionEventVariant22, global::G.ScoreEvent>?, TResult>? value2 = null,
            global::System.Func<global::G.AllOf<global::G.IngestionEventVariant32, global::G.CreateSpanEvent>?, TResult>? value3 = null,
            global::System.Func<global::G.AllOf<global::G.IngestionEventVariant42, global::G.UpdateSpanEvent>?, TResult>? value4 = null,
            global::System.Func<global::G.AllOf<global::G.IngestionEventVariant52, global::G.CreateGenerationEvent>?, TResult>? value5 = null,
            global::System.Func<global::G.AllOf<global::G.IngestionEventVariant62, global::G.UpdateGenerationEvent>?, TResult>? value6 = null,
            global::System.Func<global::G.AllOf<global::G.IngestionEventVariant72, global::G.CreateEventEvent>?, TResult>? value7 = null,
            global::System.Func<global::G.AllOf<global::G.IngestionEventVariant82, global::G.SDKLogEvent>?, TResult>? value8 = null,
            global::System.Func<global::G.AllOf<global::G.IngestionEventVariant92, global::G.CreateObservationEvent>?, TResult>? value9 = null,
            global::System.Func<global::G.AllOf<global::G.IngestionEventVariant102, global::G.UpdateObservationEvent>?, TResult>? value10 = null,
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
            else if (IsValue5 && value5 != null)
            {
                return value5(Value5!);
            }
            else if (IsValue6 && value6 != null)
            {
                return value6(Value6!);
            }
            else if (IsValue7 && value7 != null)
            {
                return value7(Value7!);
            }
            else if (IsValue8 && value8 != null)
            {
                return value8(Value8!);
            }
            else if (IsValue9 && value9 != null)
            {
                return value9(Value9!);
            }
            else if (IsValue10 && value10 != null)
            {
                return value10(Value10!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.AllOf<global::G.IngestionEventVariant12, global::G.TraceEvent>?>? value1 = null,
            global::System.Action<global::G.AllOf<global::G.IngestionEventVariant22, global::G.ScoreEvent>?>? value2 = null,
            global::System.Action<global::G.AllOf<global::G.IngestionEventVariant32, global::G.CreateSpanEvent>?>? value3 = null,
            global::System.Action<global::G.AllOf<global::G.IngestionEventVariant42, global::G.UpdateSpanEvent>?>? value4 = null,
            global::System.Action<global::G.AllOf<global::G.IngestionEventVariant52, global::G.CreateGenerationEvent>?>? value5 = null,
            global::System.Action<global::G.AllOf<global::G.IngestionEventVariant62, global::G.UpdateGenerationEvent>?>? value6 = null,
            global::System.Action<global::G.AllOf<global::G.IngestionEventVariant72, global::G.CreateEventEvent>?>? value7 = null,
            global::System.Action<global::G.AllOf<global::G.IngestionEventVariant82, global::G.SDKLogEvent>?>? value8 = null,
            global::System.Action<global::G.AllOf<global::G.IngestionEventVariant92, global::G.CreateObservationEvent>?>? value9 = null,
            global::System.Action<global::G.AllOf<global::G.IngestionEventVariant102, global::G.UpdateObservationEvent>?>? value10 = null,
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
            else if (IsValue5)
            {
                value5?.Invoke(Value5!);
            }
            else if (IsValue6)
            {
                value6?.Invoke(Value6!);
            }
            else if (IsValue7)
            {
                value7?.Invoke(Value7!);
            }
            else if (IsValue8)
            {
                value8?.Invoke(Value8!);
            }
            else if (IsValue9)
            {
                value9?.Invoke(Value9!);
            }
            else if (IsValue10)
            {
                value10?.Invoke(Value10!);
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
                typeof(global::G.AllOf<global::G.IngestionEventVariant12, global::G.TraceEvent>),
                Value2,
                typeof(global::G.AllOf<global::G.IngestionEventVariant22, global::G.ScoreEvent>),
                Value3,
                typeof(global::G.AllOf<global::G.IngestionEventVariant32, global::G.CreateSpanEvent>),
                Value4,
                typeof(global::G.AllOf<global::G.IngestionEventVariant42, global::G.UpdateSpanEvent>),
                Value5,
                typeof(global::G.AllOf<global::G.IngestionEventVariant52, global::G.CreateGenerationEvent>),
                Value6,
                typeof(global::G.AllOf<global::G.IngestionEventVariant62, global::G.UpdateGenerationEvent>),
                Value7,
                typeof(global::G.AllOf<global::G.IngestionEventVariant72, global::G.CreateEventEvent>),
                Value8,
                typeof(global::G.AllOf<global::G.IngestionEventVariant82, global::G.SDKLogEvent>),
                Value9,
                typeof(global::G.AllOf<global::G.IngestionEventVariant92, global::G.CreateObservationEvent>),
                Value10,
                typeof(global::G.AllOf<global::G.IngestionEventVariant102, global::G.UpdateObservationEvent>),
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
        public bool Equals(IngestionEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.AllOf<global::G.IngestionEventVariant12, global::G.TraceEvent>?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AllOf<global::G.IngestionEventVariant22, global::G.ScoreEvent>?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AllOf<global::G.IngestionEventVariant32, global::G.CreateSpanEvent>?>.Default.Equals(Value3, other.Value3) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AllOf<global::G.IngestionEventVariant42, global::G.UpdateSpanEvent>?>.Default.Equals(Value4, other.Value4) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AllOf<global::G.IngestionEventVariant52, global::G.CreateGenerationEvent>?>.Default.Equals(Value5, other.Value5) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AllOf<global::G.IngestionEventVariant62, global::G.UpdateGenerationEvent>?>.Default.Equals(Value6, other.Value6) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AllOf<global::G.IngestionEventVariant72, global::G.CreateEventEvent>?>.Default.Equals(Value7, other.Value7) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AllOf<global::G.IngestionEventVariant82, global::G.SDKLogEvent>?>.Default.Equals(Value8, other.Value8) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AllOf<global::G.IngestionEventVariant92, global::G.CreateObservationEvent>?>.Default.Equals(Value9, other.Value9) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AllOf<global::G.IngestionEventVariant102, global::G.UpdateObservationEvent>?>.Default.Equals(Value10, other.Value10) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(IngestionEvent obj1, IngestionEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IngestionEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(IngestionEvent obj1, IngestionEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IngestionEvent o && Equals(o);
        }
    }
}
