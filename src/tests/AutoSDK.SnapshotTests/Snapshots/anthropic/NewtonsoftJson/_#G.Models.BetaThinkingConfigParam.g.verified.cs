//HintName: G.Models.BetaThinkingConfigParam.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for enabling Claude's extended thinking. <br/>
    /// When enabled, responses include `thinking` content blocks showing Claude's thinking process before the final answer. Requires a minimum budget of 1,024 tokens and counts towards your `max_tokens` limit.<br/>
    /// See [extended thinking](https://docs.anthropic.com/en/docs/build-with-claude/extended-thinking) for details.
    /// </summary>
    public readonly partial struct BetaThinkingConfigParam : global::System.IEquatable<BetaThinkingConfigParam>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.BetaThinkingConfigParamDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BetaThinkingConfigEnabled? Enabled { get; init; }
#else
        public global::G.BetaThinkingConfigEnabled? Enabled { get; }
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
#if NET6_0_OR_GREATER
        public global::G.BetaThinkingConfigDisabled? Disabled { get; init; }
#else
        public global::G.BetaThinkingConfigDisabled? Disabled { get; }
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
        public static implicit operator BetaThinkingConfigParam(global::G.BetaThinkingConfigEnabled value) => new BetaThinkingConfigParam((global::G.BetaThinkingConfigEnabled?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaThinkingConfigEnabled?(BetaThinkingConfigParam @this) => @this.Enabled;

        /// <summary>
        /// 
        /// </summary>
        public BetaThinkingConfigParam(global::G.BetaThinkingConfigEnabled? value)
        {
            Enabled = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaThinkingConfigParam(global::G.BetaThinkingConfigDisabled value) => new BetaThinkingConfigParam((global::G.BetaThinkingConfigDisabled?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaThinkingConfigDisabled?(BetaThinkingConfigParam @this) => @this.Disabled;

        /// <summary>
        /// 
        /// </summary>
        public BetaThinkingConfigParam(global::G.BetaThinkingConfigDisabled? value)
        {
            Disabled = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BetaThinkingConfigParam(
            global::G.BetaThinkingConfigParamDiscriminatorType? type,
            global::G.BetaThinkingConfigEnabled? enabled,
            global::G.BetaThinkingConfigDisabled? disabled
            )
        {
            Type = type;

            Enabled = enabled;
            Disabled = disabled;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Disabled as object ??
            Enabled as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Enabled?.ToString() ??
            Disabled?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsEnabled && !IsDisabled || !IsEnabled && IsDisabled;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.BetaThinkingConfigEnabled?, TResult>? enabled = null,
            global::System.Func<global::G.BetaThinkingConfigDisabled?, TResult>? disabled = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEnabled && enabled != null)
            {
                return enabled(Enabled!);
            }
            else if (IsDisabled && disabled != null)
            {
                return disabled(Disabled!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.BetaThinkingConfigEnabled?>? enabled = null,
            global::System.Action<global::G.BetaThinkingConfigDisabled?>? disabled = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEnabled)
            {
                enabled?.Invoke(Enabled!);
            }
            else if (IsDisabled)
            {
                disabled?.Invoke(Disabled!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Enabled,
                typeof(global::G.BetaThinkingConfigEnabled),
                Disabled,
                typeof(global::G.BetaThinkingConfigDisabled),
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
        public bool Equals(BetaThinkingConfigParam other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.BetaThinkingConfigEnabled?>.Default.Equals(Enabled, other.Enabled) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BetaThinkingConfigDisabled?>.Default.Equals(Disabled, other.Disabled) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaThinkingConfigParam obj1, BetaThinkingConfigParam obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaThinkingConfigParam>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaThinkingConfigParam obj1, BetaThinkingConfigParam obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaThinkingConfigParam o && Equals(o);
        }
    }
}
