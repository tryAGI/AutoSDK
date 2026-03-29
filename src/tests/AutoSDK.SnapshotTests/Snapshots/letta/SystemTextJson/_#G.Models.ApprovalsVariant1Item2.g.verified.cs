//HintName: G.Models.ApprovalsVariant1Item2.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ApprovalsVariant1Item2 : global::System.IEquatable<ApprovalsVariant1Item2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.ApprovalResponseMessageApprovalsVariant1ItemDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ApprovalReturn? Approval { get; init; }
#else
        public global::G.ApprovalReturn? Approval { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Approval))]
#endif
        public bool IsApproval => Approval != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.LettaSchemasLettaMessageToolReturn? Tool { get; init; }
#else
        public global::G.LettaSchemasLettaMessageToolReturn? Tool { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Tool))]
#endif
        public bool IsTool => Tool != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ApprovalsVariant1Item2(global::G.ApprovalReturn value) => new ApprovalsVariant1Item2((global::G.ApprovalReturn?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ApprovalReturn?(ApprovalsVariant1Item2 @this) => @this.Approval;

        /// <summary>
        /// 
        /// </summary>
        public ApprovalsVariant1Item2(global::G.ApprovalReturn? value)
        {
            Approval = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ApprovalsVariant1Item2(global::G.LettaSchemasLettaMessageToolReturn value) => new ApprovalsVariant1Item2((global::G.LettaSchemasLettaMessageToolReturn?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LettaSchemasLettaMessageToolReturn?(ApprovalsVariant1Item2 @this) => @this.Tool;

        /// <summary>
        /// 
        /// </summary>
        public ApprovalsVariant1Item2(global::G.LettaSchemasLettaMessageToolReturn? value)
        {
            Tool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ApprovalsVariant1Item2(
            global::G.ApprovalResponseMessageApprovalsVariant1ItemDiscriminatorType? type,
            global::G.ApprovalReturn? approval,
            global::G.LettaSchemasLettaMessageToolReturn? tool
            )
        {
            Type = type;

            Approval = approval;
            Tool = tool;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Tool as object ??
            Approval as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Approval?.ToString() ??
            Tool?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsApproval && !IsTool || !IsApproval && IsTool;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ApprovalReturn?, TResult>? approval = null,
            global::System.Func<global::G.LettaSchemasLettaMessageToolReturn?, TResult>? tool = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsApproval && approval != null)
            {
                return approval(Approval!);
            }
            else if (IsTool && tool != null)
            {
                return tool(Tool!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ApprovalReturn?>? approval = null,
            global::System.Action<global::G.LettaSchemasLettaMessageToolReturn?>? tool = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsApproval)
            {
                approval?.Invoke(Approval!);
            }
            else if (IsTool)
            {
                tool?.Invoke(Tool!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Approval,
                typeof(global::G.ApprovalReturn),
                Tool,
                typeof(global::G.LettaSchemasLettaMessageToolReturn),
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
        public bool Equals(ApprovalsVariant1Item2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ApprovalReturn?>.Default.Equals(Approval, other.Approval) &&
                global::System.Collections.Generic.EqualityComparer<global::G.LettaSchemasLettaMessageToolReturn?>.Default.Equals(Tool, other.Tool) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ApprovalsVariant1Item2 obj1, ApprovalsVariant1Item2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ApprovalsVariant1Item2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ApprovalsVariant1Item2 obj1, ApprovalsVariant1Item2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ApprovalsVariant1Item2 o && Equals(o);
        }
    }
}
