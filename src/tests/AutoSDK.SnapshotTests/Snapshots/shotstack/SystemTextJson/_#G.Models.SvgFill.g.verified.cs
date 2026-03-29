//HintName: G.Models.SvgFill.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Fill properties for SVG shapes. Supports solid colors and gradients.<br/>
    /// The fill defines how the interior of a shape is painted.
    /// </summary>
    public readonly partial struct SvgFill : global::System.IEquatable<SvgFill>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.SvgFillDiscriminatorType? Type { get; }

        /// <summary>
        /// A solid color fill for SVG shapes.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.SvgSolidFill? Solid { get; init; }
#else
        public global::G.SvgSolidFill? Solid { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Solid))]
#endif
        public bool IsSolid => Solid != null;

        /// <summary>
        /// A linear gradient fill that transitions colors along a straight line.<br/>
        /// The gradient direction is controlled by the `angle` property.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.SvgLinearGradientFill? Linear { get; init; }
#else
        public global::G.SvgLinearGradientFill? Linear { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Linear))]
#endif
        public bool IsLinear => Linear != null;

        /// <summary>
        /// A radial gradient fill that transitions colors radiating outward from a center point.<br/>
        /// The gradient creates a circular or elliptical color transition.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.SvgRadialGradientFill? Radial { get; init; }
#else
        public global::G.SvgRadialGradientFill? Radial { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Radial))]
#endif
        public bool IsRadial => Radial != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SvgFill(global::G.SvgSolidFill value) => new SvgFill((global::G.SvgSolidFill?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SvgSolidFill?(SvgFill @this) => @this.Solid;

        /// <summary>
        /// 
        /// </summary>
        public SvgFill(global::G.SvgSolidFill? value)
        {
            Solid = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SvgFill(global::G.SvgLinearGradientFill value) => new SvgFill((global::G.SvgLinearGradientFill?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SvgLinearGradientFill?(SvgFill @this) => @this.Linear;

        /// <summary>
        /// 
        /// </summary>
        public SvgFill(global::G.SvgLinearGradientFill? value)
        {
            Linear = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SvgFill(global::G.SvgRadialGradientFill value) => new SvgFill((global::G.SvgRadialGradientFill?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SvgRadialGradientFill?(SvgFill @this) => @this.Radial;

        /// <summary>
        /// 
        /// </summary>
        public SvgFill(global::G.SvgRadialGradientFill? value)
        {
            Radial = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public SvgFill(
            global::G.SvgFillDiscriminatorType? type,
            global::G.SvgSolidFill? solid,
            global::G.SvgLinearGradientFill? linear,
            global::G.SvgRadialGradientFill? radial
            )
        {
            Type = type;

            Solid = solid;
            Linear = linear;
            Radial = radial;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Radial as object ??
            Linear as object ??
            Solid as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Solid?.ToString() ??
            Linear?.ToString() ??
            Radial?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSolid && !IsLinear && !IsRadial || !IsSolid && IsLinear && !IsRadial || !IsSolid && !IsLinear && IsRadial;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.SvgSolidFill?, TResult>? solid = null,
            global::System.Func<global::G.SvgLinearGradientFill?, TResult>? linear = null,
            global::System.Func<global::G.SvgRadialGradientFill?, TResult>? radial = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSolid && solid != null)
            {
                return solid(Solid!);
            }
            else if (IsLinear && linear != null)
            {
                return linear(Linear!);
            }
            else if (IsRadial && radial != null)
            {
                return radial(Radial!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.SvgSolidFill?>? solid = null,
            global::System.Action<global::G.SvgLinearGradientFill?>? linear = null,
            global::System.Action<global::G.SvgRadialGradientFill?>? radial = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSolid)
            {
                solid?.Invoke(Solid!);
            }
            else if (IsLinear)
            {
                linear?.Invoke(Linear!);
            }
            else if (IsRadial)
            {
                radial?.Invoke(Radial!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Solid,
                typeof(global::G.SvgSolidFill),
                Linear,
                typeof(global::G.SvgLinearGradientFill),
                Radial,
                typeof(global::G.SvgRadialGradientFill),
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
        public bool Equals(SvgFill other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.SvgSolidFill?>.Default.Equals(Solid, other.Solid) &&
                global::System.Collections.Generic.EqualityComparer<global::G.SvgLinearGradientFill?>.Default.Equals(Linear, other.Linear) &&
                global::System.Collections.Generic.EqualityComparer<global::G.SvgRadialGradientFill?>.Default.Equals(Radial, other.Radial) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SvgFill obj1, SvgFill obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SvgFill>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SvgFill obj1, SvgFill obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SvgFill o && Equals(o);
        }
    }
}
