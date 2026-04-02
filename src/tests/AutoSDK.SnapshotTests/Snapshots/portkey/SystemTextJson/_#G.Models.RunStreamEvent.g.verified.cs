//HintName: G.Models.RunStreamEvent.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct RunStreamEvent : global::System.IEquatable<RunStreamEvent>
    {
        /// <summary>
        /// Occurs when a new [run](https://platform.openai.com/docs/api-reference/runs/object) is created.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RunStreamEventVariant1? RunStreamEventVariant1 { get; init; }
#else
        public global::G.RunStreamEventVariant1? RunStreamEventVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RunStreamEventVariant1))]
#endif
        public bool IsRunStreamEventVariant1 => RunStreamEventVariant1 != null;

        /// <summary>
        /// Occurs when a [run](https://platform.openai.com/docs/api-reference/runs/object) moves to a `queued` status.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RunStreamEventVariant2? RunStreamEventVariant2 { get; init; }
#else
        public global::G.RunStreamEventVariant2? RunStreamEventVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RunStreamEventVariant2))]
#endif
        public bool IsRunStreamEventVariant2 => RunStreamEventVariant2 != null;

        /// <summary>
        /// Occurs when a [run](https://platform.openai.com/docs/api-reference/runs/object) moves to an `in_progress` status.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RunStreamEventVariant3? RunStreamEventVariant3 { get; init; }
#else
        public global::G.RunStreamEventVariant3? RunStreamEventVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RunStreamEventVariant3))]
#endif
        public bool IsRunStreamEventVariant3 => RunStreamEventVariant3 != null;

        /// <summary>
        /// Occurs when a [run](https://platform.openai.com/docs/api-reference/runs/object) moves to a `requires_action` status.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RunStreamEventVariant4? RunStreamEventVariant4 { get; init; }
#else
        public global::G.RunStreamEventVariant4? RunStreamEventVariant4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RunStreamEventVariant4))]
#endif
        public bool IsRunStreamEventVariant4 => RunStreamEventVariant4 != null;

        /// <summary>
        /// Occurs when a [run](https://platform.openai.com/docs/api-reference/runs/object) is completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RunStreamEventVariant5? RunStreamEventVariant5 { get; init; }
#else
        public global::G.RunStreamEventVariant5? RunStreamEventVariant5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RunStreamEventVariant5))]
#endif
        public bool IsRunStreamEventVariant5 => RunStreamEventVariant5 != null;

        /// <summary>
        /// Occurs when a [run](https://platform.openai.com/docs/api-reference/runs/object) ends with status `incomplete`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RunStreamEventVariant6? RunStreamEventVariant6 { get; init; }
#else
        public global::G.RunStreamEventVariant6? RunStreamEventVariant6 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RunStreamEventVariant6))]
#endif
        public bool IsRunStreamEventVariant6 => RunStreamEventVariant6 != null;

        /// <summary>
        /// Occurs when a [run](https://platform.openai.com/docs/api-reference/runs/object) fails.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RunStreamEventVariant7? RunStreamEventVariant7 { get; init; }
#else
        public global::G.RunStreamEventVariant7? RunStreamEventVariant7 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RunStreamEventVariant7))]
#endif
        public bool IsRunStreamEventVariant7 => RunStreamEventVariant7 != null;

        /// <summary>
        /// Occurs when a [run](https://platform.openai.com/docs/api-reference/runs/object) moves to a `cancelling` status.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RunStreamEventVariant8? RunStreamEventVariant8 { get; init; }
#else
        public global::G.RunStreamEventVariant8? RunStreamEventVariant8 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RunStreamEventVariant8))]
#endif
        public bool IsRunStreamEventVariant8 => RunStreamEventVariant8 != null;

        /// <summary>
        /// Occurs when a [run](https://platform.openai.com/docs/api-reference/runs/object) is cancelled.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RunStreamEventVariant9? RunStreamEventVariant9 { get; init; }
#else
        public global::G.RunStreamEventVariant9? RunStreamEventVariant9 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RunStreamEventVariant9))]
#endif
        public bool IsRunStreamEventVariant9 => RunStreamEventVariant9 != null;

        /// <summary>
        /// Occurs when a [run](https://platform.openai.com/docs/api-reference/runs/object) expires.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RunStreamEventVariant10? RunStreamEventVariant10 { get; init; }
#else
        public global::G.RunStreamEventVariant10? RunStreamEventVariant10 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RunStreamEventVariant10))]
#endif
        public bool IsRunStreamEventVariant10 => RunStreamEventVariant10 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RunStreamEvent(global::G.RunStreamEventVariant1 value) => new RunStreamEvent((global::G.RunStreamEventVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RunStreamEventVariant1?(RunStreamEvent @this) => @this.RunStreamEventVariant1;

        /// <summary>
        /// 
        /// </summary>
        public RunStreamEvent(global::G.RunStreamEventVariant1? value)
        {
            RunStreamEventVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RunStreamEvent(global::G.RunStreamEventVariant2 value) => new RunStreamEvent((global::G.RunStreamEventVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RunStreamEventVariant2?(RunStreamEvent @this) => @this.RunStreamEventVariant2;

        /// <summary>
        /// 
        /// </summary>
        public RunStreamEvent(global::G.RunStreamEventVariant2? value)
        {
            RunStreamEventVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RunStreamEvent(global::G.RunStreamEventVariant3 value) => new RunStreamEvent((global::G.RunStreamEventVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RunStreamEventVariant3?(RunStreamEvent @this) => @this.RunStreamEventVariant3;

        /// <summary>
        /// 
        /// </summary>
        public RunStreamEvent(global::G.RunStreamEventVariant3? value)
        {
            RunStreamEventVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RunStreamEvent(global::G.RunStreamEventVariant4 value) => new RunStreamEvent((global::G.RunStreamEventVariant4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RunStreamEventVariant4?(RunStreamEvent @this) => @this.RunStreamEventVariant4;

        /// <summary>
        /// 
        /// </summary>
        public RunStreamEvent(global::G.RunStreamEventVariant4? value)
        {
            RunStreamEventVariant4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RunStreamEvent(global::G.RunStreamEventVariant5 value) => new RunStreamEvent((global::G.RunStreamEventVariant5?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RunStreamEventVariant5?(RunStreamEvent @this) => @this.RunStreamEventVariant5;

        /// <summary>
        /// 
        /// </summary>
        public RunStreamEvent(global::G.RunStreamEventVariant5? value)
        {
            RunStreamEventVariant5 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RunStreamEvent(global::G.RunStreamEventVariant6 value) => new RunStreamEvent((global::G.RunStreamEventVariant6?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RunStreamEventVariant6?(RunStreamEvent @this) => @this.RunStreamEventVariant6;

        /// <summary>
        /// 
        /// </summary>
        public RunStreamEvent(global::G.RunStreamEventVariant6? value)
        {
            RunStreamEventVariant6 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RunStreamEvent(global::G.RunStreamEventVariant7 value) => new RunStreamEvent((global::G.RunStreamEventVariant7?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RunStreamEventVariant7?(RunStreamEvent @this) => @this.RunStreamEventVariant7;

        /// <summary>
        /// 
        /// </summary>
        public RunStreamEvent(global::G.RunStreamEventVariant7? value)
        {
            RunStreamEventVariant7 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RunStreamEvent(global::G.RunStreamEventVariant8 value) => new RunStreamEvent((global::G.RunStreamEventVariant8?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RunStreamEventVariant8?(RunStreamEvent @this) => @this.RunStreamEventVariant8;

        /// <summary>
        /// 
        /// </summary>
        public RunStreamEvent(global::G.RunStreamEventVariant8? value)
        {
            RunStreamEventVariant8 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RunStreamEvent(global::G.RunStreamEventVariant9 value) => new RunStreamEvent((global::G.RunStreamEventVariant9?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RunStreamEventVariant9?(RunStreamEvent @this) => @this.RunStreamEventVariant9;

        /// <summary>
        /// 
        /// </summary>
        public RunStreamEvent(global::G.RunStreamEventVariant9? value)
        {
            RunStreamEventVariant9 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RunStreamEvent(global::G.RunStreamEventVariant10 value) => new RunStreamEvent((global::G.RunStreamEventVariant10?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RunStreamEventVariant10?(RunStreamEvent @this) => @this.RunStreamEventVariant10;

        /// <summary>
        /// 
        /// </summary>
        public RunStreamEvent(global::G.RunStreamEventVariant10? value)
        {
            RunStreamEventVariant10 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RunStreamEvent(
            global::G.RunStreamEventVariant1? runStreamEventVariant1,
            global::G.RunStreamEventVariant2? runStreamEventVariant2,
            global::G.RunStreamEventVariant3? runStreamEventVariant3,
            global::G.RunStreamEventVariant4? runStreamEventVariant4,
            global::G.RunStreamEventVariant5? runStreamEventVariant5,
            global::G.RunStreamEventVariant6? runStreamEventVariant6,
            global::G.RunStreamEventVariant7? runStreamEventVariant7,
            global::G.RunStreamEventVariant8? runStreamEventVariant8,
            global::G.RunStreamEventVariant9? runStreamEventVariant9,
            global::G.RunStreamEventVariant10? runStreamEventVariant10
            )
        {
            RunStreamEventVariant1 = runStreamEventVariant1;
            RunStreamEventVariant2 = runStreamEventVariant2;
            RunStreamEventVariant3 = runStreamEventVariant3;
            RunStreamEventVariant4 = runStreamEventVariant4;
            RunStreamEventVariant5 = runStreamEventVariant5;
            RunStreamEventVariant6 = runStreamEventVariant6;
            RunStreamEventVariant7 = runStreamEventVariant7;
            RunStreamEventVariant8 = runStreamEventVariant8;
            RunStreamEventVariant9 = runStreamEventVariant9;
            RunStreamEventVariant10 = runStreamEventVariant10;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            RunStreamEventVariant10 as object ??
            RunStreamEventVariant9 as object ??
            RunStreamEventVariant8 as object ??
            RunStreamEventVariant7 as object ??
            RunStreamEventVariant6 as object ??
            RunStreamEventVariant5 as object ??
            RunStreamEventVariant4 as object ??
            RunStreamEventVariant3 as object ??
            RunStreamEventVariant2 as object ??
            RunStreamEventVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            RunStreamEventVariant1?.ToString() ??
            RunStreamEventVariant2?.ToString() ??
            RunStreamEventVariant3?.ToString() ??
            RunStreamEventVariant4?.ToString() ??
            RunStreamEventVariant5?.ToString() ??
            RunStreamEventVariant6?.ToString() ??
            RunStreamEventVariant7?.ToString() ??
            RunStreamEventVariant8?.ToString() ??
            RunStreamEventVariant9?.ToString() ??
            RunStreamEventVariant10?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsRunStreamEventVariant1 && !IsRunStreamEventVariant2 && !IsRunStreamEventVariant3 && !IsRunStreamEventVariant4 && !IsRunStreamEventVariant5 && !IsRunStreamEventVariant6 && !IsRunStreamEventVariant7 && !IsRunStreamEventVariant8 && !IsRunStreamEventVariant9 && !IsRunStreamEventVariant10 || !IsRunStreamEventVariant1 && IsRunStreamEventVariant2 && !IsRunStreamEventVariant3 && !IsRunStreamEventVariant4 && !IsRunStreamEventVariant5 && !IsRunStreamEventVariant6 && !IsRunStreamEventVariant7 && !IsRunStreamEventVariant8 && !IsRunStreamEventVariant9 && !IsRunStreamEventVariant10 || !IsRunStreamEventVariant1 && !IsRunStreamEventVariant2 && IsRunStreamEventVariant3 && !IsRunStreamEventVariant4 && !IsRunStreamEventVariant5 && !IsRunStreamEventVariant6 && !IsRunStreamEventVariant7 && !IsRunStreamEventVariant8 && !IsRunStreamEventVariant9 && !IsRunStreamEventVariant10 || !IsRunStreamEventVariant1 && !IsRunStreamEventVariant2 && !IsRunStreamEventVariant3 && IsRunStreamEventVariant4 && !IsRunStreamEventVariant5 && !IsRunStreamEventVariant6 && !IsRunStreamEventVariant7 && !IsRunStreamEventVariant8 && !IsRunStreamEventVariant9 && !IsRunStreamEventVariant10 || !IsRunStreamEventVariant1 && !IsRunStreamEventVariant2 && !IsRunStreamEventVariant3 && !IsRunStreamEventVariant4 && IsRunStreamEventVariant5 && !IsRunStreamEventVariant6 && !IsRunStreamEventVariant7 && !IsRunStreamEventVariant8 && !IsRunStreamEventVariant9 && !IsRunStreamEventVariant10 || !IsRunStreamEventVariant1 && !IsRunStreamEventVariant2 && !IsRunStreamEventVariant3 && !IsRunStreamEventVariant4 && !IsRunStreamEventVariant5 && IsRunStreamEventVariant6 && !IsRunStreamEventVariant7 && !IsRunStreamEventVariant8 && !IsRunStreamEventVariant9 && !IsRunStreamEventVariant10 || !IsRunStreamEventVariant1 && !IsRunStreamEventVariant2 && !IsRunStreamEventVariant3 && !IsRunStreamEventVariant4 && !IsRunStreamEventVariant5 && !IsRunStreamEventVariant6 && IsRunStreamEventVariant7 && !IsRunStreamEventVariant8 && !IsRunStreamEventVariant9 && !IsRunStreamEventVariant10 || !IsRunStreamEventVariant1 && !IsRunStreamEventVariant2 && !IsRunStreamEventVariant3 && !IsRunStreamEventVariant4 && !IsRunStreamEventVariant5 && !IsRunStreamEventVariant6 && !IsRunStreamEventVariant7 && IsRunStreamEventVariant8 && !IsRunStreamEventVariant9 && !IsRunStreamEventVariant10 || !IsRunStreamEventVariant1 && !IsRunStreamEventVariant2 && !IsRunStreamEventVariant3 && !IsRunStreamEventVariant4 && !IsRunStreamEventVariant5 && !IsRunStreamEventVariant6 && !IsRunStreamEventVariant7 && !IsRunStreamEventVariant8 && IsRunStreamEventVariant9 && !IsRunStreamEventVariant10 || !IsRunStreamEventVariant1 && !IsRunStreamEventVariant2 && !IsRunStreamEventVariant3 && !IsRunStreamEventVariant4 && !IsRunStreamEventVariant5 && !IsRunStreamEventVariant6 && !IsRunStreamEventVariant7 && !IsRunStreamEventVariant8 && !IsRunStreamEventVariant9 && IsRunStreamEventVariant10;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.RunStreamEventVariant1?, TResult>? runStreamEventVariant1 = null,
            global::System.Func<global::G.RunStreamEventVariant2?, TResult>? runStreamEventVariant2 = null,
            global::System.Func<global::G.RunStreamEventVariant3?, TResult>? runStreamEventVariant3 = null,
            global::System.Func<global::G.RunStreamEventVariant4?, TResult>? runStreamEventVariant4 = null,
            global::System.Func<global::G.RunStreamEventVariant5?, TResult>? runStreamEventVariant5 = null,
            global::System.Func<global::G.RunStreamEventVariant6?, TResult>? runStreamEventVariant6 = null,
            global::System.Func<global::G.RunStreamEventVariant7?, TResult>? runStreamEventVariant7 = null,
            global::System.Func<global::G.RunStreamEventVariant8?, TResult>? runStreamEventVariant8 = null,
            global::System.Func<global::G.RunStreamEventVariant9?, TResult>? runStreamEventVariant9 = null,
            global::System.Func<global::G.RunStreamEventVariant10?, TResult>? runStreamEventVariant10 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRunStreamEventVariant1 && runStreamEventVariant1 != null)
            {
                return runStreamEventVariant1(RunStreamEventVariant1!);
            }
            else if (IsRunStreamEventVariant2 && runStreamEventVariant2 != null)
            {
                return runStreamEventVariant2(RunStreamEventVariant2!);
            }
            else if (IsRunStreamEventVariant3 && runStreamEventVariant3 != null)
            {
                return runStreamEventVariant3(RunStreamEventVariant3!);
            }
            else if (IsRunStreamEventVariant4 && runStreamEventVariant4 != null)
            {
                return runStreamEventVariant4(RunStreamEventVariant4!);
            }
            else if (IsRunStreamEventVariant5 && runStreamEventVariant5 != null)
            {
                return runStreamEventVariant5(RunStreamEventVariant5!);
            }
            else if (IsRunStreamEventVariant6 && runStreamEventVariant6 != null)
            {
                return runStreamEventVariant6(RunStreamEventVariant6!);
            }
            else if (IsRunStreamEventVariant7 && runStreamEventVariant7 != null)
            {
                return runStreamEventVariant7(RunStreamEventVariant7!);
            }
            else if (IsRunStreamEventVariant8 && runStreamEventVariant8 != null)
            {
                return runStreamEventVariant8(RunStreamEventVariant8!);
            }
            else if (IsRunStreamEventVariant9 && runStreamEventVariant9 != null)
            {
                return runStreamEventVariant9(RunStreamEventVariant9!);
            }
            else if (IsRunStreamEventVariant10 && runStreamEventVariant10 != null)
            {
                return runStreamEventVariant10(RunStreamEventVariant10!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.RunStreamEventVariant1?>? runStreamEventVariant1 = null,
            global::System.Action<global::G.RunStreamEventVariant2?>? runStreamEventVariant2 = null,
            global::System.Action<global::G.RunStreamEventVariant3?>? runStreamEventVariant3 = null,
            global::System.Action<global::G.RunStreamEventVariant4?>? runStreamEventVariant4 = null,
            global::System.Action<global::G.RunStreamEventVariant5?>? runStreamEventVariant5 = null,
            global::System.Action<global::G.RunStreamEventVariant6?>? runStreamEventVariant6 = null,
            global::System.Action<global::G.RunStreamEventVariant7?>? runStreamEventVariant7 = null,
            global::System.Action<global::G.RunStreamEventVariant8?>? runStreamEventVariant8 = null,
            global::System.Action<global::G.RunStreamEventVariant9?>? runStreamEventVariant9 = null,
            global::System.Action<global::G.RunStreamEventVariant10?>? runStreamEventVariant10 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRunStreamEventVariant1)
            {
                runStreamEventVariant1?.Invoke(RunStreamEventVariant1!);
            }
            else if (IsRunStreamEventVariant2)
            {
                runStreamEventVariant2?.Invoke(RunStreamEventVariant2!);
            }
            else if (IsRunStreamEventVariant3)
            {
                runStreamEventVariant3?.Invoke(RunStreamEventVariant3!);
            }
            else if (IsRunStreamEventVariant4)
            {
                runStreamEventVariant4?.Invoke(RunStreamEventVariant4!);
            }
            else if (IsRunStreamEventVariant5)
            {
                runStreamEventVariant5?.Invoke(RunStreamEventVariant5!);
            }
            else if (IsRunStreamEventVariant6)
            {
                runStreamEventVariant6?.Invoke(RunStreamEventVariant6!);
            }
            else if (IsRunStreamEventVariant7)
            {
                runStreamEventVariant7?.Invoke(RunStreamEventVariant7!);
            }
            else if (IsRunStreamEventVariant8)
            {
                runStreamEventVariant8?.Invoke(RunStreamEventVariant8!);
            }
            else if (IsRunStreamEventVariant9)
            {
                runStreamEventVariant9?.Invoke(RunStreamEventVariant9!);
            }
            else if (IsRunStreamEventVariant10)
            {
                runStreamEventVariant10?.Invoke(RunStreamEventVariant10!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                RunStreamEventVariant1,
                typeof(global::G.RunStreamEventVariant1),
                RunStreamEventVariant2,
                typeof(global::G.RunStreamEventVariant2),
                RunStreamEventVariant3,
                typeof(global::G.RunStreamEventVariant3),
                RunStreamEventVariant4,
                typeof(global::G.RunStreamEventVariant4),
                RunStreamEventVariant5,
                typeof(global::G.RunStreamEventVariant5),
                RunStreamEventVariant6,
                typeof(global::G.RunStreamEventVariant6),
                RunStreamEventVariant7,
                typeof(global::G.RunStreamEventVariant7),
                RunStreamEventVariant8,
                typeof(global::G.RunStreamEventVariant8),
                RunStreamEventVariant9,
                typeof(global::G.RunStreamEventVariant9),
                RunStreamEventVariant10,
                typeof(global::G.RunStreamEventVariant10),
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
        public bool Equals(RunStreamEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.RunStreamEventVariant1?>.Default.Equals(RunStreamEventVariant1, other.RunStreamEventVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RunStreamEventVariant2?>.Default.Equals(RunStreamEventVariant2, other.RunStreamEventVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RunStreamEventVariant3?>.Default.Equals(RunStreamEventVariant3, other.RunStreamEventVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RunStreamEventVariant4?>.Default.Equals(RunStreamEventVariant4, other.RunStreamEventVariant4) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RunStreamEventVariant5?>.Default.Equals(RunStreamEventVariant5, other.RunStreamEventVariant5) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RunStreamEventVariant6?>.Default.Equals(RunStreamEventVariant6, other.RunStreamEventVariant6) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RunStreamEventVariant7?>.Default.Equals(RunStreamEventVariant7, other.RunStreamEventVariant7) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RunStreamEventVariant8?>.Default.Equals(RunStreamEventVariant8, other.RunStreamEventVariant8) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RunStreamEventVariant9?>.Default.Equals(RunStreamEventVariant9, other.RunStreamEventVariant9) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RunStreamEventVariant10?>.Default.Equals(RunStreamEventVariant10, other.RunStreamEventVariant10) 
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
