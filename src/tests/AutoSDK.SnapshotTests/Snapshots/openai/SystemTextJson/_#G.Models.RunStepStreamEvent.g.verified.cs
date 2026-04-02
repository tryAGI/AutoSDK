//HintName: G.Models.RunStepStreamEvent.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct RunStepStreamEvent : global::System.IEquatable<RunStepStreamEvent>
    {
        /// <summary>
        /// Occurs when a [run step](/docs/api-reference/run-steps/step-object) is created.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RunStepStreamEventVariant1? RunStepStreamEventVariant1 { get; init; }
#else
        public global::G.RunStepStreamEventVariant1? RunStepStreamEventVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RunStepStreamEventVariant1))]
#endif
        public bool IsRunStepStreamEventVariant1 => RunStepStreamEventVariant1 != null;

        /// <summary>
        /// Occurs when a [run step](/docs/api-reference/run-steps/step-object) moves to an `in_progress` state.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RunStepStreamEventVariant2? RunStepStreamEventVariant2 { get; init; }
#else
        public global::G.RunStepStreamEventVariant2? RunStepStreamEventVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RunStepStreamEventVariant2))]
#endif
        public bool IsRunStepStreamEventVariant2 => RunStepStreamEventVariant2 != null;

        /// <summary>
        /// Occurs when parts of a [run step](/docs/api-reference/run-steps/step-object) are being streamed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RunStepStreamEventVariant3? RunStepStreamEventVariant3 { get; init; }
#else
        public global::G.RunStepStreamEventVariant3? RunStepStreamEventVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RunStepStreamEventVariant3))]
#endif
        public bool IsRunStepStreamEventVariant3 => RunStepStreamEventVariant3 != null;

        /// <summary>
        /// Occurs when a [run step](/docs/api-reference/run-steps/step-object) is completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RunStepStreamEventVariant4? RunStepStreamEventVariant4 { get; init; }
#else
        public global::G.RunStepStreamEventVariant4? RunStepStreamEventVariant4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RunStepStreamEventVariant4))]
#endif
        public bool IsRunStepStreamEventVariant4 => RunStepStreamEventVariant4 != null;

        /// <summary>
        /// Occurs when a [run step](/docs/api-reference/run-steps/step-object) fails.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RunStepStreamEventVariant5? RunStepStreamEventVariant5 { get; init; }
#else
        public global::G.RunStepStreamEventVariant5? RunStepStreamEventVariant5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RunStepStreamEventVariant5))]
#endif
        public bool IsRunStepStreamEventVariant5 => RunStepStreamEventVariant5 != null;

        /// <summary>
        /// Occurs when a [run step](/docs/api-reference/run-steps/step-object) is cancelled.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RunStepStreamEventVariant6? RunStepStreamEventVariant6 { get; init; }
#else
        public global::G.RunStepStreamEventVariant6? RunStepStreamEventVariant6 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RunStepStreamEventVariant6))]
#endif
        public bool IsRunStepStreamEventVariant6 => RunStepStreamEventVariant6 != null;

        /// <summary>
        /// Occurs when a [run step](/docs/api-reference/run-steps/step-object) expires.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RunStepStreamEventVariant7? RunStepStreamEventVariant7 { get; init; }
#else
        public global::G.RunStepStreamEventVariant7? RunStepStreamEventVariant7 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RunStepStreamEventVariant7))]
#endif
        public bool IsRunStepStreamEventVariant7 => RunStepStreamEventVariant7 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RunStepStreamEvent(global::G.RunStepStreamEventVariant1 value) => new RunStepStreamEvent((global::G.RunStepStreamEventVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RunStepStreamEventVariant1?(RunStepStreamEvent @this) => @this.RunStepStreamEventVariant1;

        /// <summary>
        /// 
        /// </summary>
        public RunStepStreamEvent(global::G.RunStepStreamEventVariant1? value)
        {
            RunStepStreamEventVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RunStepStreamEvent(global::G.RunStepStreamEventVariant2 value) => new RunStepStreamEvent((global::G.RunStepStreamEventVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RunStepStreamEventVariant2?(RunStepStreamEvent @this) => @this.RunStepStreamEventVariant2;

        /// <summary>
        /// 
        /// </summary>
        public RunStepStreamEvent(global::G.RunStepStreamEventVariant2? value)
        {
            RunStepStreamEventVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RunStepStreamEvent(global::G.RunStepStreamEventVariant3 value) => new RunStepStreamEvent((global::G.RunStepStreamEventVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RunStepStreamEventVariant3?(RunStepStreamEvent @this) => @this.RunStepStreamEventVariant3;

        /// <summary>
        /// 
        /// </summary>
        public RunStepStreamEvent(global::G.RunStepStreamEventVariant3? value)
        {
            RunStepStreamEventVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RunStepStreamEvent(global::G.RunStepStreamEventVariant4 value) => new RunStepStreamEvent((global::G.RunStepStreamEventVariant4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RunStepStreamEventVariant4?(RunStepStreamEvent @this) => @this.RunStepStreamEventVariant4;

        /// <summary>
        /// 
        /// </summary>
        public RunStepStreamEvent(global::G.RunStepStreamEventVariant4? value)
        {
            RunStepStreamEventVariant4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RunStepStreamEvent(global::G.RunStepStreamEventVariant5 value) => new RunStepStreamEvent((global::G.RunStepStreamEventVariant5?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RunStepStreamEventVariant5?(RunStepStreamEvent @this) => @this.RunStepStreamEventVariant5;

        /// <summary>
        /// 
        /// </summary>
        public RunStepStreamEvent(global::G.RunStepStreamEventVariant5? value)
        {
            RunStepStreamEventVariant5 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RunStepStreamEvent(global::G.RunStepStreamEventVariant6 value) => new RunStepStreamEvent((global::G.RunStepStreamEventVariant6?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RunStepStreamEventVariant6?(RunStepStreamEvent @this) => @this.RunStepStreamEventVariant6;

        /// <summary>
        /// 
        /// </summary>
        public RunStepStreamEvent(global::G.RunStepStreamEventVariant6? value)
        {
            RunStepStreamEventVariant6 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RunStepStreamEvent(global::G.RunStepStreamEventVariant7 value) => new RunStepStreamEvent((global::G.RunStepStreamEventVariant7?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RunStepStreamEventVariant7?(RunStepStreamEvent @this) => @this.RunStepStreamEventVariant7;

        /// <summary>
        /// 
        /// </summary>
        public RunStepStreamEvent(global::G.RunStepStreamEventVariant7? value)
        {
            RunStepStreamEventVariant7 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RunStepStreamEvent(
            global::G.RunStepStreamEventVariant1? runStepStreamEventVariant1,
            global::G.RunStepStreamEventVariant2? runStepStreamEventVariant2,
            global::G.RunStepStreamEventVariant3? runStepStreamEventVariant3,
            global::G.RunStepStreamEventVariant4? runStepStreamEventVariant4,
            global::G.RunStepStreamEventVariant5? runStepStreamEventVariant5,
            global::G.RunStepStreamEventVariant6? runStepStreamEventVariant6,
            global::G.RunStepStreamEventVariant7? runStepStreamEventVariant7
            )
        {
            RunStepStreamEventVariant1 = runStepStreamEventVariant1;
            RunStepStreamEventVariant2 = runStepStreamEventVariant2;
            RunStepStreamEventVariant3 = runStepStreamEventVariant3;
            RunStepStreamEventVariant4 = runStepStreamEventVariant4;
            RunStepStreamEventVariant5 = runStepStreamEventVariant5;
            RunStepStreamEventVariant6 = runStepStreamEventVariant6;
            RunStepStreamEventVariant7 = runStepStreamEventVariant7;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            RunStepStreamEventVariant7 as object ??
            RunStepStreamEventVariant6 as object ??
            RunStepStreamEventVariant5 as object ??
            RunStepStreamEventVariant4 as object ??
            RunStepStreamEventVariant3 as object ??
            RunStepStreamEventVariant2 as object ??
            RunStepStreamEventVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            RunStepStreamEventVariant1?.ToString() ??
            RunStepStreamEventVariant2?.ToString() ??
            RunStepStreamEventVariant3?.ToString() ??
            RunStepStreamEventVariant4?.ToString() ??
            RunStepStreamEventVariant5?.ToString() ??
            RunStepStreamEventVariant6?.ToString() ??
            RunStepStreamEventVariant7?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsRunStepStreamEventVariant1 && !IsRunStepStreamEventVariant2 && !IsRunStepStreamEventVariant3 && !IsRunStepStreamEventVariant4 && !IsRunStepStreamEventVariant5 && !IsRunStepStreamEventVariant6 && !IsRunStepStreamEventVariant7 || !IsRunStepStreamEventVariant1 && IsRunStepStreamEventVariant2 && !IsRunStepStreamEventVariant3 && !IsRunStepStreamEventVariant4 && !IsRunStepStreamEventVariant5 && !IsRunStepStreamEventVariant6 && !IsRunStepStreamEventVariant7 || !IsRunStepStreamEventVariant1 && !IsRunStepStreamEventVariant2 && IsRunStepStreamEventVariant3 && !IsRunStepStreamEventVariant4 && !IsRunStepStreamEventVariant5 && !IsRunStepStreamEventVariant6 && !IsRunStepStreamEventVariant7 || !IsRunStepStreamEventVariant1 && !IsRunStepStreamEventVariant2 && !IsRunStepStreamEventVariant3 && IsRunStepStreamEventVariant4 && !IsRunStepStreamEventVariant5 && !IsRunStepStreamEventVariant6 && !IsRunStepStreamEventVariant7 || !IsRunStepStreamEventVariant1 && !IsRunStepStreamEventVariant2 && !IsRunStepStreamEventVariant3 && !IsRunStepStreamEventVariant4 && IsRunStepStreamEventVariant5 && !IsRunStepStreamEventVariant6 && !IsRunStepStreamEventVariant7 || !IsRunStepStreamEventVariant1 && !IsRunStepStreamEventVariant2 && !IsRunStepStreamEventVariant3 && !IsRunStepStreamEventVariant4 && !IsRunStepStreamEventVariant5 && IsRunStepStreamEventVariant6 && !IsRunStepStreamEventVariant7 || !IsRunStepStreamEventVariant1 && !IsRunStepStreamEventVariant2 && !IsRunStepStreamEventVariant3 && !IsRunStepStreamEventVariant4 && !IsRunStepStreamEventVariant5 && !IsRunStepStreamEventVariant6 && IsRunStepStreamEventVariant7;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.RunStepStreamEventVariant1?, TResult>? runStepStreamEventVariant1 = null,
            global::System.Func<global::G.RunStepStreamEventVariant2?, TResult>? runStepStreamEventVariant2 = null,
            global::System.Func<global::G.RunStepStreamEventVariant3?, TResult>? runStepStreamEventVariant3 = null,
            global::System.Func<global::G.RunStepStreamEventVariant4?, TResult>? runStepStreamEventVariant4 = null,
            global::System.Func<global::G.RunStepStreamEventVariant5?, TResult>? runStepStreamEventVariant5 = null,
            global::System.Func<global::G.RunStepStreamEventVariant6?, TResult>? runStepStreamEventVariant6 = null,
            global::System.Func<global::G.RunStepStreamEventVariant7?, TResult>? runStepStreamEventVariant7 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRunStepStreamEventVariant1 && runStepStreamEventVariant1 != null)
            {
                return runStepStreamEventVariant1(RunStepStreamEventVariant1!);
            }
            else if (IsRunStepStreamEventVariant2 && runStepStreamEventVariant2 != null)
            {
                return runStepStreamEventVariant2(RunStepStreamEventVariant2!);
            }
            else if (IsRunStepStreamEventVariant3 && runStepStreamEventVariant3 != null)
            {
                return runStepStreamEventVariant3(RunStepStreamEventVariant3!);
            }
            else if (IsRunStepStreamEventVariant4 && runStepStreamEventVariant4 != null)
            {
                return runStepStreamEventVariant4(RunStepStreamEventVariant4!);
            }
            else if (IsRunStepStreamEventVariant5 && runStepStreamEventVariant5 != null)
            {
                return runStepStreamEventVariant5(RunStepStreamEventVariant5!);
            }
            else if (IsRunStepStreamEventVariant6 && runStepStreamEventVariant6 != null)
            {
                return runStepStreamEventVariant6(RunStepStreamEventVariant6!);
            }
            else if (IsRunStepStreamEventVariant7 && runStepStreamEventVariant7 != null)
            {
                return runStepStreamEventVariant7(RunStepStreamEventVariant7!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.RunStepStreamEventVariant1?>? runStepStreamEventVariant1 = null,
            global::System.Action<global::G.RunStepStreamEventVariant2?>? runStepStreamEventVariant2 = null,
            global::System.Action<global::G.RunStepStreamEventVariant3?>? runStepStreamEventVariant3 = null,
            global::System.Action<global::G.RunStepStreamEventVariant4?>? runStepStreamEventVariant4 = null,
            global::System.Action<global::G.RunStepStreamEventVariant5?>? runStepStreamEventVariant5 = null,
            global::System.Action<global::G.RunStepStreamEventVariant6?>? runStepStreamEventVariant6 = null,
            global::System.Action<global::G.RunStepStreamEventVariant7?>? runStepStreamEventVariant7 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRunStepStreamEventVariant1)
            {
                runStepStreamEventVariant1?.Invoke(RunStepStreamEventVariant1!);
            }
            else if (IsRunStepStreamEventVariant2)
            {
                runStepStreamEventVariant2?.Invoke(RunStepStreamEventVariant2!);
            }
            else if (IsRunStepStreamEventVariant3)
            {
                runStepStreamEventVariant3?.Invoke(RunStepStreamEventVariant3!);
            }
            else if (IsRunStepStreamEventVariant4)
            {
                runStepStreamEventVariant4?.Invoke(RunStepStreamEventVariant4!);
            }
            else if (IsRunStepStreamEventVariant5)
            {
                runStepStreamEventVariant5?.Invoke(RunStepStreamEventVariant5!);
            }
            else if (IsRunStepStreamEventVariant6)
            {
                runStepStreamEventVariant6?.Invoke(RunStepStreamEventVariant6!);
            }
            else if (IsRunStepStreamEventVariant7)
            {
                runStepStreamEventVariant7?.Invoke(RunStepStreamEventVariant7!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                RunStepStreamEventVariant1,
                typeof(global::G.RunStepStreamEventVariant1),
                RunStepStreamEventVariant2,
                typeof(global::G.RunStepStreamEventVariant2),
                RunStepStreamEventVariant3,
                typeof(global::G.RunStepStreamEventVariant3),
                RunStepStreamEventVariant4,
                typeof(global::G.RunStepStreamEventVariant4),
                RunStepStreamEventVariant5,
                typeof(global::G.RunStepStreamEventVariant5),
                RunStepStreamEventVariant6,
                typeof(global::G.RunStepStreamEventVariant6),
                RunStepStreamEventVariant7,
                typeof(global::G.RunStepStreamEventVariant7),
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
        public bool Equals(RunStepStreamEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.RunStepStreamEventVariant1?>.Default.Equals(RunStepStreamEventVariant1, other.RunStepStreamEventVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RunStepStreamEventVariant2?>.Default.Equals(RunStepStreamEventVariant2, other.RunStepStreamEventVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RunStepStreamEventVariant3?>.Default.Equals(RunStepStreamEventVariant3, other.RunStepStreamEventVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RunStepStreamEventVariant4?>.Default.Equals(RunStepStreamEventVariant4, other.RunStepStreamEventVariant4) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RunStepStreamEventVariant5?>.Default.Equals(RunStepStreamEventVariant5, other.RunStepStreamEventVariant5) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RunStepStreamEventVariant6?>.Default.Equals(RunStepStreamEventVariant6, other.RunStepStreamEventVariant6) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RunStepStreamEventVariant7?>.Default.Equals(RunStepStreamEventVariant7, other.RunStepStreamEventVariant7) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RunStepStreamEvent obj1, RunStepStreamEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RunStepStreamEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RunStepStreamEvent obj1, RunStepStreamEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RunStepStreamEvent o && Equals(o);
        }
    }
}
