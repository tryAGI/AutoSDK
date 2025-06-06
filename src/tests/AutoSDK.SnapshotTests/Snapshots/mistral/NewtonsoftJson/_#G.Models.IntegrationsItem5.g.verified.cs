﻿//HintName: G.Models.IntegrationsItem5.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct IntegrationsItem5 : global::System.IEquatable<IntegrationsItem5>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.JobInIntegrationDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.WandbIntegration? Wandb { get; init; }
#else
        public global::G.WandbIntegration? Wandb { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Wandb))]
#endif
        public bool IsWandb => Wandb != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IntegrationsItem5(global::G.WandbIntegration value) => new IntegrationsItem5((global::G.WandbIntegration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.WandbIntegration?(IntegrationsItem5 @this) => @this.Wandb;

        /// <summary>
        /// 
        /// </summary>
        public IntegrationsItem5(global::G.WandbIntegration? value)
        {
            Wandb = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public IntegrationsItem5(
            global::G.JobInIntegrationDiscriminatorType? type,
            global::G.WandbIntegration? wandb
            )
        {
            Type = type;

            Wandb = wandb;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Wandb as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Wandb?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsWandb;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.WandbIntegration?, TResult>? wandb = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWandb && wandb != null)
            {
                return wandb(Wandb!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.WandbIntegration?>? wandb = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWandb)
            {
                wandb?.Invoke(Wandb!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Wandb,
                typeof(global::G.WandbIntegration),
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
        public bool Equals(IntegrationsItem5 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.WandbIntegration?>.Default.Equals(Wandb, other.Wandb) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(IntegrationsItem5 obj1, IntegrationsItem5 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IntegrationsItem5>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(IntegrationsItem5 obj1, IntegrationsItem5 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IntegrationsItem5 o && Equals(o);
        }
    }
}
