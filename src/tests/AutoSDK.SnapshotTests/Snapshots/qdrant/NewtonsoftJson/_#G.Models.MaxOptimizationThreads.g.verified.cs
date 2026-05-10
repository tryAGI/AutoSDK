//HintName: G.Models.MaxOptimizationThreads.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct MaxOptimizationThreads : global::System.IEquatable<MaxOptimizationThreads>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MaxOptimizationThreadsSetting? Setting { get; init; }
#else
        public global::G.MaxOptimizationThreadsSetting? Setting { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Setting))]
#endif
        public bool IsSetting => Setting != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSetting(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.MaxOptimizationThreadsSetting? value)
        {
            value = Setting;
            return IsSetting;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.MaxOptimizationThreadsSetting PickSetting() => IsSetting
            ? Setting!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Setting' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public int? MaxOptimizationThreadsVariant2 { get; init; }
#else
        public int? MaxOptimizationThreadsVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MaxOptimizationThreadsVariant2))]
#endif
        public bool IsMaxOptimizationThreadsVariant2 => MaxOptimizationThreadsVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickMaxOptimizationThreadsVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out int? value)
        {
            value = MaxOptimizationThreadsVariant2;
            return IsMaxOptimizationThreadsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public int PickMaxOptimizationThreadsVariant2() => IsMaxOptimizationThreadsVariant2
            ? MaxOptimizationThreadsVariant2!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'MaxOptimizationThreadsVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MaxOptimizationThreads(global::G.MaxOptimizationThreadsSetting value) => new MaxOptimizationThreads((global::G.MaxOptimizationThreadsSetting?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MaxOptimizationThreadsSetting?(MaxOptimizationThreads @this) => @this.Setting;

        /// <summary>
        /// 
        /// </summary>
        public MaxOptimizationThreads(global::G.MaxOptimizationThreadsSetting? value)
        {
            Setting = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static MaxOptimizationThreads FromSetting(global::G.MaxOptimizationThreadsSetting? value) => new MaxOptimizationThreads(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MaxOptimizationThreads(int value) => new MaxOptimizationThreads((int?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator int?(MaxOptimizationThreads @this) => @this.MaxOptimizationThreadsVariant2;

        /// <summary>
        /// 
        /// </summary>
        public MaxOptimizationThreads(int? value)
        {
            MaxOptimizationThreadsVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static MaxOptimizationThreads FromMaxOptimizationThreadsVariant2(int? value) => new MaxOptimizationThreads(value);

        /// <summary>
        /// 
        /// </summary>
        public MaxOptimizationThreads(
            global::G.MaxOptimizationThreadsSetting? setting,
            int? maxOptimizationThreadsVariant2
            )
        {
            Setting = setting;
            MaxOptimizationThreadsVariant2 = maxOptimizationThreadsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            MaxOptimizationThreadsVariant2 as object ??
            Setting as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Setting?.ToValueString() ??
            MaxOptimizationThreadsVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSetting || IsMaxOptimizationThreadsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.MaxOptimizationThreadsSetting?, TResult>? setting = null,
            global::System.Func<int?, TResult>? maxOptimizationThreadsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSetting && setting != null)
            {
                return setting(Setting!);
            }
            else if (IsMaxOptimizationThreadsVariant2 && maxOptimizationThreadsVariant2 != null)
            {
                return maxOptimizationThreadsVariant2(MaxOptimizationThreadsVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.MaxOptimizationThreadsSetting?>? setting = null,

            global::System.Action<int?>? maxOptimizationThreadsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSetting)
            {
                setting?.Invoke(Setting!);
            }
            else if (IsMaxOptimizationThreadsVariant2)
            {
                maxOptimizationThreadsVariant2?.Invoke(MaxOptimizationThreadsVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::G.MaxOptimizationThreadsSetting?>? setting = null,
            global::System.Action<int?>? maxOptimizationThreadsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSetting)
            {
                setting?.Invoke(Setting!);
            }
            else if (IsMaxOptimizationThreadsVariant2)
            {
                maxOptimizationThreadsVariant2?.Invoke(MaxOptimizationThreadsVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Setting,
                typeof(global::G.MaxOptimizationThreadsSetting),
                MaxOptimizationThreadsVariant2,
                typeof(int),
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
        public bool Equals(MaxOptimizationThreads other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.MaxOptimizationThreadsSetting?>.Default.Equals(Setting, other.Setting) &&
                global::System.Collections.Generic.EqualityComparer<int?>.Default.Equals(MaxOptimizationThreadsVariant2, other.MaxOptimizationThreadsVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(MaxOptimizationThreads obj1, MaxOptimizationThreads obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<MaxOptimizationThreads>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(MaxOptimizationThreads obj1, MaxOptimizationThreads obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MaxOptimizationThreads o && Equals(o);
        }
    }
}
