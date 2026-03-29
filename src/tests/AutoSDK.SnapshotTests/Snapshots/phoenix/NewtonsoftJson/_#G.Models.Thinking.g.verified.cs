//HintName: G.Models.Thinking.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Thinking : global::System.IEquatable<Thinking>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.PromptAnthropicInvocationParametersContentThinkingDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PromptAnthropicThinkingConfigDisabled? Disabled { get; init; }
#else
        public global::G.PromptAnthropicThinkingConfigDisabled? Disabled { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Disabled))]
#endif
        public bool IsDisabled => Disabled != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PromptAnthropicThinkingConfigEnabled? Enabled { get; init; }
#else
        public global::G.PromptAnthropicThinkingConfigEnabled? Enabled { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Enabled))]
#endif
        public bool IsEnabled => Enabled != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Thinking(global::G.PromptAnthropicThinkingConfigDisabled value) => new Thinking((global::G.PromptAnthropicThinkingConfigDisabled?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PromptAnthropicThinkingConfigDisabled?(Thinking @this) => @this.Disabled;

        /// <summary>
        /// 
        /// </summary>
        public Thinking(global::G.PromptAnthropicThinkingConfigDisabled? value)
        {
            Disabled = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Thinking(global::G.PromptAnthropicThinkingConfigEnabled value) => new Thinking((global::G.PromptAnthropicThinkingConfigEnabled?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PromptAnthropicThinkingConfigEnabled?(Thinking @this) => @this.Enabled;

        /// <summary>
        /// 
        /// </summary>
        public Thinking(global::G.PromptAnthropicThinkingConfigEnabled? value)
        {
            Enabled = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Thinking(
            global::G.PromptAnthropicInvocationParametersContentThinkingDiscriminatorType? type,
            global::G.PromptAnthropicThinkingConfigDisabled? disabled,
            global::G.PromptAnthropicThinkingConfigEnabled? enabled
            )
        {
            Type = type;

            Disabled = disabled;
            Enabled = enabled;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Enabled as object ??
            Disabled as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Disabled?.ToString() ??
            Enabled?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsDisabled && !IsEnabled || !IsDisabled && IsEnabled;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.PromptAnthropicThinkingConfigDisabled?, TResult>? disabled = null,
            global::System.Func<global::G.PromptAnthropicThinkingConfigEnabled?, TResult>? enabled = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDisabled && disabled != null)
            {
                return disabled(Disabled!);
            }
            else if (IsEnabled && enabled != null)
            {
                return enabled(Enabled!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.PromptAnthropicThinkingConfigDisabled?>? disabled = null,
            global::System.Action<global::G.PromptAnthropicThinkingConfigEnabled?>? enabled = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDisabled)
            {
                disabled?.Invoke(Disabled!);
            }
            else if (IsEnabled)
            {
                enabled?.Invoke(Enabled!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Disabled,
                typeof(global::G.PromptAnthropicThinkingConfigDisabled),
                Enabled,
                typeof(global::G.PromptAnthropicThinkingConfigEnabled),
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
        public bool Equals(Thinking other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.PromptAnthropicThinkingConfigDisabled?>.Default.Equals(Disabled, other.Disabled) &&
                global::System.Collections.Generic.EqualityComparer<global::G.PromptAnthropicThinkingConfigEnabled?>.Default.Equals(Enabled, other.Enabled) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Thinking obj1, Thinking obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Thinking>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Thinking obj1, Thinking obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Thinking o && Equals(o);
        }
    }
}
