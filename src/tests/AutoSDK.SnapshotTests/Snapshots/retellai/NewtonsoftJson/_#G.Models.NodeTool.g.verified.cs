//HintName: G.Models.NodeTool.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct NodeTool : global::System.IEquatable<NodeTool>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.OneOf<global::G.CustomTool, global::G.CheckAvailabilityCalTool, global::G.BookAppointmentCalTool>? NodeToolVariant1 { get; init; }
#else
        public global::G.OneOf<global::G.CustomTool, global::G.CheckAvailabilityCalTool, global::G.BookAppointmentCalTool>? NodeToolVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NodeToolVariant1))]
#endif
        public bool IsNodeToolVariant1 => NodeToolVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.NodeToolVariant2? NodeToolVariant2 { get; init; }
#else
        public global::G.NodeToolVariant2? NodeToolVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NodeToolVariant2))]
#endif
        public bool IsNodeToolVariant2 => NodeToolVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NodeTool(global::G.OneOf<global::G.CustomTool, global::G.CheckAvailabilityCalTool, global::G.BookAppointmentCalTool> value) => new NodeTool((global::G.OneOf<global::G.CustomTool, global::G.CheckAvailabilityCalTool, global::G.BookAppointmentCalTool>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.OneOf<global::G.CustomTool, global::G.CheckAvailabilityCalTool, global::G.BookAppointmentCalTool>?(NodeTool @this) => @this.NodeToolVariant1;

        /// <summary>
        /// 
        /// </summary>
        public NodeTool(global::G.OneOf<global::G.CustomTool, global::G.CheckAvailabilityCalTool, global::G.BookAppointmentCalTool>? value)
        {
            NodeToolVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NodeTool(global::G.NodeToolVariant2 value) => new NodeTool((global::G.NodeToolVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.NodeToolVariant2?(NodeTool @this) => @this.NodeToolVariant2;

        /// <summary>
        /// 
        /// </summary>
        public NodeTool(global::G.NodeToolVariant2? value)
        {
            NodeToolVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public NodeTool(
            global::G.OneOf<global::G.CustomTool, global::G.CheckAvailabilityCalTool, global::G.BookAppointmentCalTool>? nodeToolVariant1,
            global::G.NodeToolVariant2? nodeToolVariant2
            )
        {
            NodeToolVariant1 = nodeToolVariant1;
            NodeToolVariant2 = nodeToolVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            NodeToolVariant2 as object ??
            NodeToolVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            NodeToolVariant1?.ToString() ??
            NodeToolVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsNodeToolVariant1 && IsNodeToolVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.OneOf<global::G.CustomTool, global::G.CheckAvailabilityCalTool, global::G.BookAppointmentCalTool>?, TResult>? nodeToolVariant1 = null,
            global::System.Func<global::G.NodeToolVariant2?, TResult>? nodeToolVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsNodeToolVariant1 && nodeToolVariant1 != null)
            {
                return nodeToolVariant1(NodeToolVariant1!);
            }
            else if (IsNodeToolVariant2 && nodeToolVariant2 != null)
            {
                return nodeToolVariant2(NodeToolVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.OneOf<global::G.CustomTool, global::G.CheckAvailabilityCalTool, global::G.BookAppointmentCalTool>?>? nodeToolVariant1 = null,
            global::System.Action<global::G.NodeToolVariant2?>? nodeToolVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsNodeToolVariant1)
            {
                nodeToolVariant1?.Invoke(NodeToolVariant1!);
            }
            else if (IsNodeToolVariant2)
            {
                nodeToolVariant2?.Invoke(NodeToolVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                NodeToolVariant1,
                typeof(global::G.OneOf<global::G.CustomTool, global::G.CheckAvailabilityCalTool, global::G.BookAppointmentCalTool>),
                NodeToolVariant2,
                typeof(global::G.NodeToolVariant2),
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
        public bool Equals(NodeTool other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.OneOf<global::G.CustomTool, global::G.CheckAvailabilityCalTool, global::G.BookAppointmentCalTool>?>.Default.Equals(NodeToolVariant1, other.NodeToolVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.NodeToolVariant2?>.Default.Equals(NodeToolVariant2, other.NodeToolVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(NodeTool obj1, NodeTool obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<NodeTool>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(NodeTool obj1, NodeTool obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is NodeTool o && Equals(o);
        }
    }
}
