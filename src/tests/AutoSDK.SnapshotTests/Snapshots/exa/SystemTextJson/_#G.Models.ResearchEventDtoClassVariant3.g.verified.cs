//HintName: G.Models.ResearchEventDtoClassVariant3.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ResearchEventDtoClassVariant3 : global::System.IEquatable<ResearchEventDtoClassVariant3>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResearchEventDtoClassVariant3Variant1? TaskDefinition { get; init; }
#else
        public global::G.ResearchEventDtoClassVariant3Variant1? TaskDefinition { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TaskDefinition))]
#endif
        public bool IsTaskDefinition => TaskDefinition != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResearchEventDtoClassVariant3Variant2? TaskOperation { get; init; }
#else
        public global::G.ResearchEventDtoClassVariant3Variant2? TaskOperation { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TaskOperation))]
#endif
        public bool IsTaskOperation => TaskOperation != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResearchEventDtoClassVariant3Variant3? TaskOutput { get; init; }
#else
        public global::G.ResearchEventDtoClassVariant3Variant3? TaskOutput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TaskOutput))]
#endif
        public bool IsTaskOutput => TaskOutput != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResearchEventDtoClassVariant3(global::G.ResearchEventDtoClassVariant3Variant1 value) => new ResearchEventDtoClassVariant3((global::G.ResearchEventDtoClassVariant3Variant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResearchEventDtoClassVariant3Variant1?(ResearchEventDtoClassVariant3 @this) => @this.TaskDefinition;

        /// <summary>
        /// 
        /// </summary>
        public ResearchEventDtoClassVariant3(global::G.ResearchEventDtoClassVariant3Variant1? value)
        {
            TaskDefinition = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResearchEventDtoClassVariant3(global::G.ResearchEventDtoClassVariant3Variant2 value) => new ResearchEventDtoClassVariant3((global::G.ResearchEventDtoClassVariant3Variant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResearchEventDtoClassVariant3Variant2?(ResearchEventDtoClassVariant3 @this) => @this.TaskOperation;

        /// <summary>
        /// 
        /// </summary>
        public ResearchEventDtoClassVariant3(global::G.ResearchEventDtoClassVariant3Variant2? value)
        {
            TaskOperation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResearchEventDtoClassVariant3(global::G.ResearchEventDtoClassVariant3Variant3 value) => new ResearchEventDtoClassVariant3((global::G.ResearchEventDtoClassVariant3Variant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResearchEventDtoClassVariant3Variant3?(ResearchEventDtoClassVariant3 @this) => @this.TaskOutput;

        /// <summary>
        /// 
        /// </summary>
        public ResearchEventDtoClassVariant3(global::G.ResearchEventDtoClassVariant3Variant3? value)
        {
            TaskOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ResearchEventDtoClassVariant3(
            global::G.ResearchEventDtoClassVariant3Variant1? taskDefinition,
            global::G.ResearchEventDtoClassVariant3Variant2? taskOperation,
            global::G.ResearchEventDtoClassVariant3Variant3? taskOutput
            )
        {
            TaskDefinition = taskDefinition;
            TaskOperation = taskOperation;
            TaskOutput = taskOutput;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TaskOutput as object ??
            TaskOperation as object ??
            TaskDefinition as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            TaskDefinition?.ToString() ??
            TaskOperation?.ToString() ??
            TaskOutput?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTaskDefinition && !IsTaskOperation && !IsTaskOutput || !IsTaskDefinition && IsTaskOperation && !IsTaskOutput || !IsTaskDefinition && !IsTaskOperation && IsTaskOutput;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ResearchEventDtoClassVariant3Variant1?, TResult>? taskDefinition = null,
            global::System.Func<global::G.ResearchEventDtoClassVariant3Variant2?, TResult>? taskOperation = null,
            global::System.Func<global::G.ResearchEventDtoClassVariant3Variant3?, TResult>? taskOutput = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTaskDefinition && taskDefinition != null)
            {
                return taskDefinition(TaskDefinition!);
            }
            else if (IsTaskOperation && taskOperation != null)
            {
                return taskOperation(TaskOperation!);
            }
            else if (IsTaskOutput && taskOutput != null)
            {
                return taskOutput(TaskOutput!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ResearchEventDtoClassVariant3Variant1?>? taskDefinition = null,
            global::System.Action<global::G.ResearchEventDtoClassVariant3Variant2?>? taskOperation = null,
            global::System.Action<global::G.ResearchEventDtoClassVariant3Variant3?>? taskOutput = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTaskDefinition)
            {
                taskDefinition?.Invoke(TaskDefinition!);
            }
            else if (IsTaskOperation)
            {
                taskOperation?.Invoke(TaskOperation!);
            }
            else if (IsTaskOutput)
            {
                taskOutput?.Invoke(TaskOutput!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TaskDefinition,
                typeof(global::G.ResearchEventDtoClassVariant3Variant1),
                TaskOperation,
                typeof(global::G.ResearchEventDtoClassVariant3Variant2),
                TaskOutput,
                typeof(global::G.ResearchEventDtoClassVariant3Variant3),
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
        public bool Equals(ResearchEventDtoClassVariant3 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ResearchEventDtoClassVariant3Variant1?>.Default.Equals(TaskDefinition, other.TaskDefinition) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResearchEventDtoClassVariant3Variant2?>.Default.Equals(TaskOperation, other.TaskOperation) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResearchEventDtoClassVariant3Variant3?>.Default.Equals(TaskOutput, other.TaskOutput) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ResearchEventDtoClassVariant3 obj1, ResearchEventDtoClassVariant3 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResearchEventDtoClassVariant3>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ResearchEventDtoClassVariant3 obj1, ResearchEventDtoClassVariant3 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResearchEventDtoClassVariant3 o && Equals(o);
        }
    }
}
