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
        public global::G.AllOf<global::G.IngestionEventVariant12, global::G.TraceEvent>? IngestionEventVariant1 { get; init; }
#else
        public global::G.AllOf<global::G.IngestionEventVariant12, global::G.TraceEvent>? IngestionEventVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(IngestionEventVariant1))]
#endif
        public bool IsIngestionEventVariant1 => IngestionEventVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AllOf<global::G.IngestionEventVariant22, global::G.ScoreEvent>? IngestionEventVariant2 { get; init; }
#else
        public global::G.AllOf<global::G.IngestionEventVariant22, global::G.ScoreEvent>? IngestionEventVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(IngestionEventVariant2))]
#endif
        public bool IsIngestionEventVariant2 => IngestionEventVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AllOf<global::G.IngestionEventVariant32, global::G.CreateSpanEvent>? IngestionEventVariant3 { get; init; }
#else
        public global::G.AllOf<global::G.IngestionEventVariant32, global::G.CreateSpanEvent>? IngestionEventVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(IngestionEventVariant3))]
#endif
        public bool IsIngestionEventVariant3 => IngestionEventVariant3 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AllOf<global::G.IngestionEventVariant42, global::G.UpdateSpanEvent>? IngestionEventVariant4 { get; init; }
#else
        public global::G.AllOf<global::G.IngestionEventVariant42, global::G.UpdateSpanEvent>? IngestionEventVariant4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(IngestionEventVariant4))]
#endif
        public bool IsIngestionEventVariant4 => IngestionEventVariant4 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AllOf<global::G.IngestionEventVariant52, global::G.CreateGenerationEvent>? IngestionEventVariant5 { get; init; }
#else
        public global::G.AllOf<global::G.IngestionEventVariant52, global::G.CreateGenerationEvent>? IngestionEventVariant5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(IngestionEventVariant5))]
#endif
        public bool IsIngestionEventVariant5 => IngestionEventVariant5 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AllOf<global::G.IngestionEventVariant62, global::G.UpdateGenerationEvent>? IngestionEventVariant6 { get; init; }
#else
        public global::G.AllOf<global::G.IngestionEventVariant62, global::G.UpdateGenerationEvent>? IngestionEventVariant6 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(IngestionEventVariant6))]
#endif
        public bool IsIngestionEventVariant6 => IngestionEventVariant6 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AllOf<global::G.IngestionEventVariant72, global::G.CreateEventEvent>? IngestionEventVariant7 { get; init; }
#else
        public global::G.AllOf<global::G.IngestionEventVariant72, global::G.CreateEventEvent>? IngestionEventVariant7 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(IngestionEventVariant7))]
#endif
        public bool IsIngestionEventVariant7 => IngestionEventVariant7 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AllOf<global::G.IngestionEventVariant82, global::G.SDKLogEvent>? IngestionEventVariant8 { get; init; }
#else
        public global::G.AllOf<global::G.IngestionEventVariant82, global::G.SDKLogEvent>? IngestionEventVariant8 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(IngestionEventVariant8))]
#endif
        public bool IsIngestionEventVariant8 => IngestionEventVariant8 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AllOf<global::G.IngestionEventVariant92, global::G.CreateObservationEvent>? IngestionEventVariant9 { get; init; }
#else
        public global::G.AllOf<global::G.IngestionEventVariant92, global::G.CreateObservationEvent>? IngestionEventVariant9 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(IngestionEventVariant9))]
#endif
        public bool IsIngestionEventVariant9 => IngestionEventVariant9 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AllOf<global::G.IngestionEventVariant102, global::G.UpdateObservationEvent>? IngestionEventVariant10 { get; init; }
#else
        public global::G.AllOf<global::G.IngestionEventVariant102, global::G.UpdateObservationEvent>? IngestionEventVariant10 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(IngestionEventVariant10))]
#endif
        public bool IsIngestionEventVariant10 => IngestionEventVariant10 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IngestionEvent(global::G.AllOf<global::G.IngestionEventVariant12, global::G.TraceEvent> value) => new IngestionEvent((global::G.AllOf<global::G.IngestionEventVariant12, global::G.TraceEvent>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AllOf<global::G.IngestionEventVariant12, global::G.TraceEvent>?(IngestionEvent @this) => @this.IngestionEventVariant1;

        /// <summary>
        /// 
        /// </summary>
        public IngestionEvent(global::G.AllOf<global::G.IngestionEventVariant12, global::G.TraceEvent>? value)
        {
            IngestionEventVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IngestionEvent(global::G.AllOf<global::G.IngestionEventVariant22, global::G.ScoreEvent> value) => new IngestionEvent((global::G.AllOf<global::G.IngestionEventVariant22, global::G.ScoreEvent>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AllOf<global::G.IngestionEventVariant22, global::G.ScoreEvent>?(IngestionEvent @this) => @this.IngestionEventVariant2;

        /// <summary>
        /// 
        /// </summary>
        public IngestionEvent(global::G.AllOf<global::G.IngestionEventVariant22, global::G.ScoreEvent>? value)
        {
            IngestionEventVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IngestionEvent(global::G.AllOf<global::G.IngestionEventVariant32, global::G.CreateSpanEvent> value) => new IngestionEvent((global::G.AllOf<global::G.IngestionEventVariant32, global::G.CreateSpanEvent>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AllOf<global::G.IngestionEventVariant32, global::G.CreateSpanEvent>?(IngestionEvent @this) => @this.IngestionEventVariant3;

        /// <summary>
        /// 
        /// </summary>
        public IngestionEvent(global::G.AllOf<global::G.IngestionEventVariant32, global::G.CreateSpanEvent>? value)
        {
            IngestionEventVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IngestionEvent(global::G.AllOf<global::G.IngestionEventVariant42, global::G.UpdateSpanEvent> value) => new IngestionEvent((global::G.AllOf<global::G.IngestionEventVariant42, global::G.UpdateSpanEvent>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AllOf<global::G.IngestionEventVariant42, global::G.UpdateSpanEvent>?(IngestionEvent @this) => @this.IngestionEventVariant4;

        /// <summary>
        /// 
        /// </summary>
        public IngestionEvent(global::G.AllOf<global::G.IngestionEventVariant42, global::G.UpdateSpanEvent>? value)
        {
            IngestionEventVariant4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IngestionEvent(global::G.AllOf<global::G.IngestionEventVariant52, global::G.CreateGenerationEvent> value) => new IngestionEvent((global::G.AllOf<global::G.IngestionEventVariant52, global::G.CreateGenerationEvent>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AllOf<global::G.IngestionEventVariant52, global::G.CreateGenerationEvent>?(IngestionEvent @this) => @this.IngestionEventVariant5;

        /// <summary>
        /// 
        /// </summary>
        public IngestionEvent(global::G.AllOf<global::G.IngestionEventVariant52, global::G.CreateGenerationEvent>? value)
        {
            IngestionEventVariant5 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IngestionEvent(global::G.AllOf<global::G.IngestionEventVariant62, global::G.UpdateGenerationEvent> value) => new IngestionEvent((global::G.AllOf<global::G.IngestionEventVariant62, global::G.UpdateGenerationEvent>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AllOf<global::G.IngestionEventVariant62, global::G.UpdateGenerationEvent>?(IngestionEvent @this) => @this.IngestionEventVariant6;

        /// <summary>
        /// 
        /// </summary>
        public IngestionEvent(global::G.AllOf<global::G.IngestionEventVariant62, global::G.UpdateGenerationEvent>? value)
        {
            IngestionEventVariant6 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IngestionEvent(global::G.AllOf<global::G.IngestionEventVariant72, global::G.CreateEventEvent> value) => new IngestionEvent((global::G.AllOf<global::G.IngestionEventVariant72, global::G.CreateEventEvent>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AllOf<global::G.IngestionEventVariant72, global::G.CreateEventEvent>?(IngestionEvent @this) => @this.IngestionEventVariant7;

        /// <summary>
        /// 
        /// </summary>
        public IngestionEvent(global::G.AllOf<global::G.IngestionEventVariant72, global::G.CreateEventEvent>? value)
        {
            IngestionEventVariant7 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IngestionEvent(global::G.AllOf<global::G.IngestionEventVariant82, global::G.SDKLogEvent> value) => new IngestionEvent((global::G.AllOf<global::G.IngestionEventVariant82, global::G.SDKLogEvent>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AllOf<global::G.IngestionEventVariant82, global::G.SDKLogEvent>?(IngestionEvent @this) => @this.IngestionEventVariant8;

        /// <summary>
        /// 
        /// </summary>
        public IngestionEvent(global::G.AllOf<global::G.IngestionEventVariant82, global::G.SDKLogEvent>? value)
        {
            IngestionEventVariant8 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IngestionEvent(global::G.AllOf<global::G.IngestionEventVariant92, global::G.CreateObservationEvent> value) => new IngestionEvent((global::G.AllOf<global::G.IngestionEventVariant92, global::G.CreateObservationEvent>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AllOf<global::G.IngestionEventVariant92, global::G.CreateObservationEvent>?(IngestionEvent @this) => @this.IngestionEventVariant9;

        /// <summary>
        /// 
        /// </summary>
        public IngestionEvent(global::G.AllOf<global::G.IngestionEventVariant92, global::G.CreateObservationEvent>? value)
        {
            IngestionEventVariant9 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IngestionEvent(global::G.AllOf<global::G.IngestionEventVariant102, global::G.UpdateObservationEvent> value) => new IngestionEvent((global::G.AllOf<global::G.IngestionEventVariant102, global::G.UpdateObservationEvent>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AllOf<global::G.IngestionEventVariant102, global::G.UpdateObservationEvent>?(IngestionEvent @this) => @this.IngestionEventVariant10;

        /// <summary>
        /// 
        /// </summary>
        public IngestionEvent(global::G.AllOf<global::G.IngestionEventVariant102, global::G.UpdateObservationEvent>? value)
        {
            IngestionEventVariant10 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public IngestionEvent(
            global::G.AllOf<global::G.IngestionEventVariant12, global::G.TraceEvent>? ingestionEventVariant1,
            global::G.AllOf<global::G.IngestionEventVariant22, global::G.ScoreEvent>? ingestionEventVariant2,
            global::G.AllOf<global::G.IngestionEventVariant32, global::G.CreateSpanEvent>? ingestionEventVariant3,
            global::G.AllOf<global::G.IngestionEventVariant42, global::G.UpdateSpanEvent>? ingestionEventVariant4,
            global::G.AllOf<global::G.IngestionEventVariant52, global::G.CreateGenerationEvent>? ingestionEventVariant5,
            global::G.AllOf<global::G.IngestionEventVariant62, global::G.UpdateGenerationEvent>? ingestionEventVariant6,
            global::G.AllOf<global::G.IngestionEventVariant72, global::G.CreateEventEvent>? ingestionEventVariant7,
            global::G.AllOf<global::G.IngestionEventVariant82, global::G.SDKLogEvent>? ingestionEventVariant8,
            global::G.AllOf<global::G.IngestionEventVariant92, global::G.CreateObservationEvent>? ingestionEventVariant9,
            global::G.AllOf<global::G.IngestionEventVariant102, global::G.UpdateObservationEvent>? ingestionEventVariant10
            )
        {
            IngestionEventVariant1 = ingestionEventVariant1;
            IngestionEventVariant2 = ingestionEventVariant2;
            IngestionEventVariant3 = ingestionEventVariant3;
            IngestionEventVariant4 = ingestionEventVariant4;
            IngestionEventVariant5 = ingestionEventVariant5;
            IngestionEventVariant6 = ingestionEventVariant6;
            IngestionEventVariant7 = ingestionEventVariant7;
            IngestionEventVariant8 = ingestionEventVariant8;
            IngestionEventVariant9 = ingestionEventVariant9;
            IngestionEventVariant10 = ingestionEventVariant10;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            IngestionEventVariant10 as object ??
            IngestionEventVariant9 as object ??
            IngestionEventVariant8 as object ??
            IngestionEventVariant7 as object ??
            IngestionEventVariant6 as object ??
            IngestionEventVariant5 as object ??
            IngestionEventVariant4 as object ??
            IngestionEventVariant3 as object ??
            IngestionEventVariant2 as object ??
            IngestionEventVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            IngestionEventVariant1?.ToString() ??
            IngestionEventVariant2?.ToString() ??
            IngestionEventVariant3?.ToString() ??
            IngestionEventVariant4?.ToString() ??
            IngestionEventVariant5?.ToString() ??
            IngestionEventVariant6?.ToString() ??
            IngestionEventVariant7?.ToString() ??
            IngestionEventVariant8?.ToString() ??
            IngestionEventVariant9?.ToString() ??
            IngestionEventVariant10?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsIngestionEventVariant1 && !IsIngestionEventVariant2 && !IsIngestionEventVariant3 && !IsIngestionEventVariant4 && !IsIngestionEventVariant5 && !IsIngestionEventVariant6 && !IsIngestionEventVariant7 && !IsIngestionEventVariant8 && !IsIngestionEventVariant9 && !IsIngestionEventVariant10 || !IsIngestionEventVariant1 && IsIngestionEventVariant2 && !IsIngestionEventVariant3 && !IsIngestionEventVariant4 && !IsIngestionEventVariant5 && !IsIngestionEventVariant6 && !IsIngestionEventVariant7 && !IsIngestionEventVariant8 && !IsIngestionEventVariant9 && !IsIngestionEventVariant10 || !IsIngestionEventVariant1 && !IsIngestionEventVariant2 && IsIngestionEventVariant3 && !IsIngestionEventVariant4 && !IsIngestionEventVariant5 && !IsIngestionEventVariant6 && !IsIngestionEventVariant7 && !IsIngestionEventVariant8 && !IsIngestionEventVariant9 && !IsIngestionEventVariant10 || !IsIngestionEventVariant1 && !IsIngestionEventVariant2 && !IsIngestionEventVariant3 && IsIngestionEventVariant4 && !IsIngestionEventVariant5 && !IsIngestionEventVariant6 && !IsIngestionEventVariant7 && !IsIngestionEventVariant8 && !IsIngestionEventVariant9 && !IsIngestionEventVariant10 || !IsIngestionEventVariant1 && !IsIngestionEventVariant2 && !IsIngestionEventVariant3 && !IsIngestionEventVariant4 && IsIngestionEventVariant5 && !IsIngestionEventVariant6 && !IsIngestionEventVariant7 && !IsIngestionEventVariant8 && !IsIngestionEventVariant9 && !IsIngestionEventVariant10 || !IsIngestionEventVariant1 && !IsIngestionEventVariant2 && !IsIngestionEventVariant3 && !IsIngestionEventVariant4 && !IsIngestionEventVariant5 && IsIngestionEventVariant6 && !IsIngestionEventVariant7 && !IsIngestionEventVariant8 && !IsIngestionEventVariant9 && !IsIngestionEventVariant10 || !IsIngestionEventVariant1 && !IsIngestionEventVariant2 && !IsIngestionEventVariant3 && !IsIngestionEventVariant4 && !IsIngestionEventVariant5 && !IsIngestionEventVariant6 && IsIngestionEventVariant7 && !IsIngestionEventVariant8 && !IsIngestionEventVariant9 && !IsIngestionEventVariant10 || !IsIngestionEventVariant1 && !IsIngestionEventVariant2 && !IsIngestionEventVariant3 && !IsIngestionEventVariant4 && !IsIngestionEventVariant5 && !IsIngestionEventVariant6 && !IsIngestionEventVariant7 && IsIngestionEventVariant8 && !IsIngestionEventVariant9 && !IsIngestionEventVariant10 || !IsIngestionEventVariant1 && !IsIngestionEventVariant2 && !IsIngestionEventVariant3 && !IsIngestionEventVariant4 && !IsIngestionEventVariant5 && !IsIngestionEventVariant6 && !IsIngestionEventVariant7 && !IsIngestionEventVariant8 && IsIngestionEventVariant9 && !IsIngestionEventVariant10 || !IsIngestionEventVariant1 && !IsIngestionEventVariant2 && !IsIngestionEventVariant3 && !IsIngestionEventVariant4 && !IsIngestionEventVariant5 && !IsIngestionEventVariant6 && !IsIngestionEventVariant7 && !IsIngestionEventVariant8 && !IsIngestionEventVariant9 && IsIngestionEventVariant10;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.AllOf<global::G.IngestionEventVariant12, global::G.TraceEvent>?, TResult>? ingestionEventVariant1 = null,
            global::System.Func<global::G.AllOf<global::G.IngestionEventVariant22, global::G.ScoreEvent>?, TResult>? ingestionEventVariant2 = null,
            global::System.Func<global::G.AllOf<global::G.IngestionEventVariant32, global::G.CreateSpanEvent>?, TResult>? ingestionEventVariant3 = null,
            global::System.Func<global::G.AllOf<global::G.IngestionEventVariant42, global::G.UpdateSpanEvent>?, TResult>? ingestionEventVariant4 = null,
            global::System.Func<global::G.AllOf<global::G.IngestionEventVariant52, global::G.CreateGenerationEvent>?, TResult>? ingestionEventVariant5 = null,
            global::System.Func<global::G.AllOf<global::G.IngestionEventVariant62, global::G.UpdateGenerationEvent>?, TResult>? ingestionEventVariant6 = null,
            global::System.Func<global::G.AllOf<global::G.IngestionEventVariant72, global::G.CreateEventEvent>?, TResult>? ingestionEventVariant7 = null,
            global::System.Func<global::G.AllOf<global::G.IngestionEventVariant82, global::G.SDKLogEvent>?, TResult>? ingestionEventVariant8 = null,
            global::System.Func<global::G.AllOf<global::G.IngestionEventVariant92, global::G.CreateObservationEvent>?, TResult>? ingestionEventVariant9 = null,
            global::System.Func<global::G.AllOf<global::G.IngestionEventVariant102, global::G.UpdateObservationEvent>?, TResult>? ingestionEventVariant10 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsIngestionEventVariant1 && ingestionEventVariant1 != null)
            {
                return ingestionEventVariant1(IngestionEventVariant1!);
            }
            else if (IsIngestionEventVariant2 && ingestionEventVariant2 != null)
            {
                return ingestionEventVariant2(IngestionEventVariant2!);
            }
            else if (IsIngestionEventVariant3 && ingestionEventVariant3 != null)
            {
                return ingestionEventVariant3(IngestionEventVariant3!);
            }
            else if (IsIngestionEventVariant4 && ingestionEventVariant4 != null)
            {
                return ingestionEventVariant4(IngestionEventVariant4!);
            }
            else if (IsIngestionEventVariant5 && ingestionEventVariant5 != null)
            {
                return ingestionEventVariant5(IngestionEventVariant5!);
            }
            else if (IsIngestionEventVariant6 && ingestionEventVariant6 != null)
            {
                return ingestionEventVariant6(IngestionEventVariant6!);
            }
            else if (IsIngestionEventVariant7 && ingestionEventVariant7 != null)
            {
                return ingestionEventVariant7(IngestionEventVariant7!);
            }
            else if (IsIngestionEventVariant8 && ingestionEventVariant8 != null)
            {
                return ingestionEventVariant8(IngestionEventVariant8!);
            }
            else if (IsIngestionEventVariant9 && ingestionEventVariant9 != null)
            {
                return ingestionEventVariant9(IngestionEventVariant9!);
            }
            else if (IsIngestionEventVariant10 && ingestionEventVariant10 != null)
            {
                return ingestionEventVariant10(IngestionEventVariant10!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.AllOf<global::G.IngestionEventVariant12, global::G.TraceEvent>?>? ingestionEventVariant1 = null,
            global::System.Action<global::G.AllOf<global::G.IngestionEventVariant22, global::G.ScoreEvent>?>? ingestionEventVariant2 = null,
            global::System.Action<global::G.AllOf<global::G.IngestionEventVariant32, global::G.CreateSpanEvent>?>? ingestionEventVariant3 = null,
            global::System.Action<global::G.AllOf<global::G.IngestionEventVariant42, global::G.UpdateSpanEvent>?>? ingestionEventVariant4 = null,
            global::System.Action<global::G.AllOf<global::G.IngestionEventVariant52, global::G.CreateGenerationEvent>?>? ingestionEventVariant5 = null,
            global::System.Action<global::G.AllOf<global::G.IngestionEventVariant62, global::G.UpdateGenerationEvent>?>? ingestionEventVariant6 = null,
            global::System.Action<global::G.AllOf<global::G.IngestionEventVariant72, global::G.CreateEventEvent>?>? ingestionEventVariant7 = null,
            global::System.Action<global::G.AllOf<global::G.IngestionEventVariant82, global::G.SDKLogEvent>?>? ingestionEventVariant8 = null,
            global::System.Action<global::G.AllOf<global::G.IngestionEventVariant92, global::G.CreateObservationEvent>?>? ingestionEventVariant9 = null,
            global::System.Action<global::G.AllOf<global::G.IngestionEventVariant102, global::G.UpdateObservationEvent>?>? ingestionEventVariant10 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsIngestionEventVariant1)
            {
                ingestionEventVariant1?.Invoke(IngestionEventVariant1!);
            }
            else if (IsIngestionEventVariant2)
            {
                ingestionEventVariant2?.Invoke(IngestionEventVariant2!);
            }
            else if (IsIngestionEventVariant3)
            {
                ingestionEventVariant3?.Invoke(IngestionEventVariant3!);
            }
            else if (IsIngestionEventVariant4)
            {
                ingestionEventVariant4?.Invoke(IngestionEventVariant4!);
            }
            else if (IsIngestionEventVariant5)
            {
                ingestionEventVariant5?.Invoke(IngestionEventVariant5!);
            }
            else if (IsIngestionEventVariant6)
            {
                ingestionEventVariant6?.Invoke(IngestionEventVariant6!);
            }
            else if (IsIngestionEventVariant7)
            {
                ingestionEventVariant7?.Invoke(IngestionEventVariant7!);
            }
            else if (IsIngestionEventVariant8)
            {
                ingestionEventVariant8?.Invoke(IngestionEventVariant8!);
            }
            else if (IsIngestionEventVariant9)
            {
                ingestionEventVariant9?.Invoke(IngestionEventVariant9!);
            }
            else if (IsIngestionEventVariant10)
            {
                ingestionEventVariant10?.Invoke(IngestionEventVariant10!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                IngestionEventVariant1,
                typeof(global::G.AllOf<global::G.IngestionEventVariant12, global::G.TraceEvent>),
                IngestionEventVariant2,
                typeof(global::G.AllOf<global::G.IngestionEventVariant22, global::G.ScoreEvent>),
                IngestionEventVariant3,
                typeof(global::G.AllOf<global::G.IngestionEventVariant32, global::G.CreateSpanEvent>),
                IngestionEventVariant4,
                typeof(global::G.AllOf<global::G.IngestionEventVariant42, global::G.UpdateSpanEvent>),
                IngestionEventVariant5,
                typeof(global::G.AllOf<global::G.IngestionEventVariant52, global::G.CreateGenerationEvent>),
                IngestionEventVariant6,
                typeof(global::G.AllOf<global::G.IngestionEventVariant62, global::G.UpdateGenerationEvent>),
                IngestionEventVariant7,
                typeof(global::G.AllOf<global::G.IngestionEventVariant72, global::G.CreateEventEvent>),
                IngestionEventVariant8,
                typeof(global::G.AllOf<global::G.IngestionEventVariant82, global::G.SDKLogEvent>),
                IngestionEventVariant9,
                typeof(global::G.AllOf<global::G.IngestionEventVariant92, global::G.CreateObservationEvent>),
                IngestionEventVariant10,
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
                global::System.Collections.Generic.EqualityComparer<global::G.AllOf<global::G.IngestionEventVariant12, global::G.TraceEvent>?>.Default.Equals(IngestionEventVariant1, other.IngestionEventVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AllOf<global::G.IngestionEventVariant22, global::G.ScoreEvent>?>.Default.Equals(IngestionEventVariant2, other.IngestionEventVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AllOf<global::G.IngestionEventVariant32, global::G.CreateSpanEvent>?>.Default.Equals(IngestionEventVariant3, other.IngestionEventVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AllOf<global::G.IngestionEventVariant42, global::G.UpdateSpanEvent>?>.Default.Equals(IngestionEventVariant4, other.IngestionEventVariant4) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AllOf<global::G.IngestionEventVariant52, global::G.CreateGenerationEvent>?>.Default.Equals(IngestionEventVariant5, other.IngestionEventVariant5) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AllOf<global::G.IngestionEventVariant62, global::G.UpdateGenerationEvent>?>.Default.Equals(IngestionEventVariant6, other.IngestionEventVariant6) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AllOf<global::G.IngestionEventVariant72, global::G.CreateEventEvent>?>.Default.Equals(IngestionEventVariant7, other.IngestionEventVariant7) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AllOf<global::G.IngestionEventVariant82, global::G.SDKLogEvent>?>.Default.Equals(IngestionEventVariant8, other.IngestionEventVariant8) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AllOf<global::G.IngestionEventVariant92, global::G.CreateObservationEvent>?>.Default.Equals(IngestionEventVariant9, other.IngestionEventVariant9) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AllOf<global::G.IngestionEventVariant102, global::G.UpdateObservationEvent>?>.Default.Equals(IngestionEventVariant10, other.IngestionEventVariant10) 
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
