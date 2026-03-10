//HintName: G.Models.BackupLlmConfig.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for backup LLM cascading. Can be disabled, use system defaults, or specify custom order.
    /// </summary>
    public readonly partial struct BackupLlmConfig : global::System.IEquatable<BackupLlmConfig>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.PromptAgentAPIModelInputBackupLlmConfigDiscriminatorPreference? Preference { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BackupLLMDefault? Default { get; init; }
#else
        public global::G.BackupLLMDefault? Default { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Default))]
#endif
        public bool IsDefault => Default != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BackupLLMDisabled? Disabled { get; init; }
#else
        public global::G.BackupLLMDisabled? Disabled { get; }
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
        public global::G.BackupLLMOverride? Override { get; init; }
#else
        public global::G.BackupLLMOverride? Override { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Override))]
#endif
        public bool IsOverride => Override != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BackupLlmConfig(global::G.BackupLLMDefault value) => new BackupLlmConfig((global::G.BackupLLMDefault?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BackupLLMDefault?(BackupLlmConfig @this) => @this.Default;

        /// <summary>
        /// 
        /// </summary>
        public BackupLlmConfig(global::G.BackupLLMDefault? value)
        {
            Default = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BackupLlmConfig(global::G.BackupLLMDisabled value) => new BackupLlmConfig((global::G.BackupLLMDisabled?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BackupLLMDisabled?(BackupLlmConfig @this) => @this.Disabled;

        /// <summary>
        /// 
        /// </summary>
        public BackupLlmConfig(global::G.BackupLLMDisabled? value)
        {
            Disabled = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BackupLlmConfig(global::G.BackupLLMOverride value) => new BackupLlmConfig((global::G.BackupLLMOverride?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BackupLLMOverride?(BackupLlmConfig @this) => @this.Override;

        /// <summary>
        /// 
        /// </summary>
        public BackupLlmConfig(global::G.BackupLLMOverride? value)
        {
            Override = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BackupLlmConfig(
            global::G.PromptAgentAPIModelInputBackupLlmConfigDiscriminatorPreference? preference,
            global::G.BackupLLMDefault? @default,
            global::G.BackupLLMDisabled? disabled,
            global::G.BackupLLMOverride? @override
            )
        {
            Preference = preference;

            Default = @default;
            Disabled = disabled;
            Override = @override;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Override as object ??
            Disabled as object ??
            Default as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Default?.ToString() ??
            Disabled?.ToString() ??
            Override?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsDefault && !IsDisabled && !IsOverride || !IsDefault && IsDisabled && !IsOverride || !IsDefault && !IsDisabled && IsOverride;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.BackupLLMDefault?, TResult>? @default = null,
            global::System.Func<global::G.BackupLLMDisabled?, TResult>? disabled = null,
            global::System.Func<global::G.BackupLLMOverride?, TResult>? @override = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDefault && @default != null)
            {
                return @default(Default!);
            }
            else if (IsDisabled && disabled != null)
            {
                return disabled(Disabled!);
            }
            else if (IsOverride && @override != null)
            {
                return @override(Override!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.BackupLLMDefault?>? @default = null,
            global::System.Action<global::G.BackupLLMDisabled?>? disabled = null,
            global::System.Action<global::G.BackupLLMOverride?>? @override = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDefault)
            {
                @default?.Invoke(Default!);
            }
            else if (IsDisabled)
            {
                disabled?.Invoke(Disabled!);
            }
            else if (IsOverride)
            {
                @override?.Invoke(Override!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Default,
                typeof(global::G.BackupLLMDefault),
                Disabled,
                typeof(global::G.BackupLLMDisabled),
                Override,
                typeof(global::G.BackupLLMOverride),
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
        public bool Equals(BackupLlmConfig other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.BackupLLMDefault?>.Default.Equals(Default, other.Default) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BackupLLMDisabled?>.Default.Equals(Disabled, other.Disabled) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BackupLLMOverride?>.Default.Equals(Override, other.Override) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BackupLlmConfig obj1, BackupLlmConfig obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BackupLlmConfig>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BackupLlmConfig obj1, BackupLlmConfig obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BackupLlmConfig o && Equals(o);
        }
    }
}
