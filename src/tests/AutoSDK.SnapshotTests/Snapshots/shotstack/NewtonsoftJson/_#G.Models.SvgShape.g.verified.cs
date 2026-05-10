//HintName: G.Models.SvgShape.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// The shape definition for an SVG asset. Each shape type has its own specific<br/>
    /// properties. The `type` field determines which shape is rendered.
    /// </summary>
    public readonly partial struct SvgShape : global::System.IEquatable<SvgShape>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.SvgShapeDiscriminatorType? Type { get; }

        /// <summary>
        /// A rectangle shape with optional rounded corners.<br/>
        /// The rectangle is defined by its width and height dimensions.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.SvgRectangleShape? Rectangle { get; init; }
#else
        public global::G.SvgRectangleShape? Rectangle { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Rectangle))]
#endif
        public bool IsRectangle => Rectangle != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickRectangle(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.SvgRectangleShape? value)
        {
            value = Rectangle;
            return IsRectangle;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.SvgRectangleShape PickRectangle() => IsRectangle
            ? Rectangle!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Rectangle' but the value was {ToString()}.");

        /// <summary>
        /// A perfect circle shape defined by its radius.<br/>
        /// The circle is centered at the shape's position.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.SvgCircleShape? Circle { get; init; }
#else
        public global::G.SvgCircleShape? Circle { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Circle))]
#endif
        public bool IsCircle => Circle != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCircle(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.SvgCircleShape? value)
        {
            value = Circle;
            return IsCircle;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.SvgCircleShape PickCircle() => IsCircle
            ? Circle!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Circle' but the value was {ToString()}.");

        /// <summary>
        /// An ellipse (oval) shape with separate horizontal and vertical radii.<br/>
        /// The ellipse is centered at the shape's position.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.SvgEllipseShape? Ellipse { get; init; }
#else
        public global::G.SvgEllipseShape? Ellipse { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Ellipse))]
#endif
        public bool IsEllipse => Ellipse != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickEllipse(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.SvgEllipseShape? value)
        {
            value = Ellipse;
            return IsEllipse;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.SvgEllipseShape PickEllipse() => IsEllipse
            ? Ellipse!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Ellipse' but the value was {ToString()}.");

        /// <summary>
        /// A straight line shape with a specified length and thickness.<br/>
        /// The line is drawn horizontally by default and can be rotated using transform.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.SvgLineShape? Line { get; init; }
#else
        public global::G.SvgLineShape? Line { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Line))]
#endif
        public bool IsLine => Line != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickLine(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.SvgLineShape? value)
        {
            value = Line;
            return IsLine;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.SvgLineShape PickLine() => IsLine
            ? Line!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Line' but the value was {ToString()}.");

        /// <summary>
        /// A regular polygon shape with a specified number of sides.<br/>
        /// Examples: triangle (3), square (4), pentagon (5), hexagon (6), etc.<br/>
        /// The polygon is inscribed in a circle of the given radius.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.SvgPolygonShape? Polygon { get; init; }
#else
        public global::G.SvgPolygonShape? Polygon { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Polygon))]
#endif
        public bool IsPolygon => Polygon != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickPolygon(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.SvgPolygonShape? value)
        {
            value = Polygon;
            return IsPolygon;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.SvgPolygonShape PickPolygon() => IsPolygon
            ? Polygon!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Polygon' but the value was {ToString()}.");

        /// <summary>
        /// A star shape with a specified number of points.<br/>
        /// The star is defined by outer and inner radii, creating the characteristic<br/>
        /// pointed appearance.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.SvgStarShape? Star { get; init; }
#else
        public global::G.SvgStarShape? Star { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Star))]
#endif
        public bool IsStar => Star != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStar(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.SvgStarShape? value)
        {
            value = Star;
            return IsStar;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.SvgStarShape PickStar() => IsStar
            ? Star!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Star' but the value was {ToString()}.");

        /// <summary>
        /// An arrow shape pointing to the right by default.<br/>
        /// Use transform rotation to change direction.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.SvgArrowShape? Arrow { get; init; }
#else
        public global::G.SvgArrowShape? Arrow { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Arrow))]
#endif
        public bool IsArrow => Arrow != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickArrow(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.SvgArrowShape? value)
        {
            value = Arrow;
            return IsArrow;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.SvgArrowShape PickArrow() => IsArrow
            ? Arrow!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Arrow' but the value was {ToString()}.");

        /// <summary>
        /// A heart shape commonly used for love/like icons.<br/>
        /// The heart is defined by a single size parameter.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.SvgHeartShape? Heart { get; init; }
#else
        public global::G.SvgHeartShape? Heart { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Heart))]
#endif
        public bool IsHeart => Heart != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickHeart(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.SvgHeartShape? value)
        {
            value = Heart;
            return IsHeart;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.SvgHeartShape PickHeart() => IsHeart
            ? Heart!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Heart' but the value was {ToString()}.");

        /// <summary>
        /// A cross or plus shape with equal or different arm lengths.<br/>
        /// Can be styled as a plus sign (+) or a cross (x with rotation).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.SvgCrossShape? Cross { get; init; }
#else
        public global::G.SvgCrossShape? Cross { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Cross))]
#endif
        public bool IsCross => Cross != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCross(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.SvgCrossShape? value)
        {
            value = Cross;
            return IsCross;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.SvgCrossShape PickCross() => IsCross
            ? Cross!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Cross' but the value was {ToString()}.");

        /// <summary>
        /// A ring (donut/annulus) shape - a circle with a circular hole in the center.<br/>
        /// The ring is defined by outer and inner radii.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.SvgRingShape? Ring { get; init; }
#else
        public global::G.SvgRingShape? Ring { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Ring))]
#endif
        public bool IsRing => Ring != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickRing(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.SvgRingShape? value)
        {
            value = Ring;
            return IsRing;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.SvgRingShape PickRing() => IsRing
            ? Ring!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Ring' but the value was {ToString()}.");

        /// <summary>
        /// A custom shape defined by SVG path data.<br/>
        /// Supports all standard SVG path commands for creating complex shapes.<br/>
        /// **Path Commands:**<br/>
        /// - `M x y` / `m dx dy` - Move to (absolute/relative)<br/>
        /// - `L x y` / `l dx dy` - Line to<br/>
        /// - `H x` / `h dx` - Horizontal line to<br/>
        /// - `V y` / `v dy` - Vertical line to<br/>
        /// - `C x1 y1 x2 y2 x y` / `c` - Cubic Bezier curve<br/>
        /// - `S x2 y2 x y` / `s` - Smooth cubic Bezier<br/>
        /// - `Q x1 y1 x y` / `q` - Quadratic Bezier curve<br/>
        /// - `T x y` / `t` - Smooth quadratic Bezier<br/>
        /// - `A rx ry angle large-arc sweep x y` / `a` - Elliptical arc<br/>
        /// - `Z` / `z` - Close path
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.SvgPathShape? Path { get; init; }
#else
        public global::G.SvgPathShape? Path { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Path))]
#endif
        public bool IsPath => Path != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickPath(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.SvgPathShape? value)
        {
            value = Path;
            return IsPath;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.SvgPathShape PickPath() => IsPath
            ? Path!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Path' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SvgShape(global::G.SvgRectangleShape value) => new SvgShape((global::G.SvgRectangleShape?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SvgRectangleShape?(SvgShape @this) => @this.Rectangle;

        /// <summary>
        /// 
        /// </summary>
        public SvgShape(global::G.SvgRectangleShape? value)
        {
            Rectangle = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SvgShape FromRectangle(global::G.SvgRectangleShape? value) => new SvgShape(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SvgShape(global::G.SvgCircleShape value) => new SvgShape((global::G.SvgCircleShape?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SvgCircleShape?(SvgShape @this) => @this.Circle;

        /// <summary>
        /// 
        /// </summary>
        public SvgShape(global::G.SvgCircleShape? value)
        {
            Circle = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SvgShape FromCircle(global::G.SvgCircleShape? value) => new SvgShape(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SvgShape(global::G.SvgEllipseShape value) => new SvgShape((global::G.SvgEllipseShape?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SvgEllipseShape?(SvgShape @this) => @this.Ellipse;

        /// <summary>
        /// 
        /// </summary>
        public SvgShape(global::G.SvgEllipseShape? value)
        {
            Ellipse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SvgShape FromEllipse(global::G.SvgEllipseShape? value) => new SvgShape(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SvgShape(global::G.SvgLineShape value) => new SvgShape((global::G.SvgLineShape?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SvgLineShape?(SvgShape @this) => @this.Line;

        /// <summary>
        /// 
        /// </summary>
        public SvgShape(global::G.SvgLineShape? value)
        {
            Line = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SvgShape FromLine(global::G.SvgLineShape? value) => new SvgShape(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SvgShape(global::G.SvgPolygonShape value) => new SvgShape((global::G.SvgPolygonShape?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SvgPolygonShape?(SvgShape @this) => @this.Polygon;

        /// <summary>
        /// 
        /// </summary>
        public SvgShape(global::G.SvgPolygonShape? value)
        {
            Polygon = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SvgShape FromPolygon(global::G.SvgPolygonShape? value) => new SvgShape(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SvgShape(global::G.SvgStarShape value) => new SvgShape((global::G.SvgStarShape?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SvgStarShape?(SvgShape @this) => @this.Star;

        /// <summary>
        /// 
        /// </summary>
        public SvgShape(global::G.SvgStarShape? value)
        {
            Star = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SvgShape FromStar(global::G.SvgStarShape? value) => new SvgShape(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SvgShape(global::G.SvgArrowShape value) => new SvgShape((global::G.SvgArrowShape?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SvgArrowShape?(SvgShape @this) => @this.Arrow;

        /// <summary>
        /// 
        /// </summary>
        public SvgShape(global::G.SvgArrowShape? value)
        {
            Arrow = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SvgShape FromArrow(global::G.SvgArrowShape? value) => new SvgShape(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SvgShape(global::G.SvgHeartShape value) => new SvgShape((global::G.SvgHeartShape?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SvgHeartShape?(SvgShape @this) => @this.Heart;

        /// <summary>
        /// 
        /// </summary>
        public SvgShape(global::G.SvgHeartShape? value)
        {
            Heart = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SvgShape FromHeart(global::G.SvgHeartShape? value) => new SvgShape(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SvgShape(global::G.SvgCrossShape value) => new SvgShape((global::G.SvgCrossShape?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SvgCrossShape?(SvgShape @this) => @this.Cross;

        /// <summary>
        /// 
        /// </summary>
        public SvgShape(global::G.SvgCrossShape? value)
        {
            Cross = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SvgShape FromCross(global::G.SvgCrossShape? value) => new SvgShape(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SvgShape(global::G.SvgRingShape value) => new SvgShape((global::G.SvgRingShape?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SvgRingShape?(SvgShape @this) => @this.Ring;

        /// <summary>
        /// 
        /// </summary>
        public SvgShape(global::G.SvgRingShape? value)
        {
            Ring = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SvgShape FromRing(global::G.SvgRingShape? value) => new SvgShape(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SvgShape(global::G.SvgPathShape value) => new SvgShape((global::G.SvgPathShape?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SvgPathShape?(SvgShape @this) => @this.Path;

        /// <summary>
        /// 
        /// </summary>
        public SvgShape(global::G.SvgPathShape? value)
        {
            Path = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SvgShape FromPath(global::G.SvgPathShape? value) => new SvgShape(value);

        /// <summary>
        /// 
        /// </summary>
        public SvgShape(
            global::G.SvgShapeDiscriminatorType? type,
            global::G.SvgRectangleShape? rectangle,
            global::G.SvgCircleShape? circle,
            global::G.SvgEllipseShape? ellipse,
            global::G.SvgLineShape? line,
            global::G.SvgPolygonShape? polygon,
            global::G.SvgStarShape? star,
            global::G.SvgArrowShape? arrow,
            global::G.SvgHeartShape? heart,
            global::G.SvgCrossShape? cross,
            global::G.SvgRingShape? ring,
            global::G.SvgPathShape? path
            )
        {
            Type = type;

            Rectangle = rectangle;
            Circle = circle;
            Ellipse = ellipse;
            Line = line;
            Polygon = polygon;
            Star = star;
            Arrow = arrow;
            Heart = heart;
            Cross = cross;
            Ring = ring;
            Path = path;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Path as object ??
            Ring as object ??
            Cross as object ??
            Heart as object ??
            Arrow as object ??
            Star as object ??
            Polygon as object ??
            Line as object ??
            Ellipse as object ??
            Circle as object ??
            Rectangle as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Rectangle?.ToString() ??
            Circle?.ToString() ??
            Ellipse?.ToString() ??
            Line?.ToString() ??
            Polygon?.ToString() ??
            Star?.ToString() ??
            Arrow?.ToString() ??
            Heart?.ToString() ??
            Cross?.ToString() ??
            Ring?.ToString() ??
            Path?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsRectangle && !IsCircle && !IsEllipse && !IsLine && !IsPolygon && !IsStar && !IsArrow && !IsHeart && !IsCross && !IsRing && !IsPath || !IsRectangle && IsCircle && !IsEllipse && !IsLine && !IsPolygon && !IsStar && !IsArrow && !IsHeart && !IsCross && !IsRing && !IsPath || !IsRectangle && !IsCircle && IsEllipse && !IsLine && !IsPolygon && !IsStar && !IsArrow && !IsHeart && !IsCross && !IsRing && !IsPath || !IsRectangle && !IsCircle && !IsEllipse && IsLine && !IsPolygon && !IsStar && !IsArrow && !IsHeart && !IsCross && !IsRing && !IsPath || !IsRectangle && !IsCircle && !IsEllipse && !IsLine && IsPolygon && !IsStar && !IsArrow && !IsHeart && !IsCross && !IsRing && !IsPath || !IsRectangle && !IsCircle && !IsEllipse && !IsLine && !IsPolygon && IsStar && !IsArrow && !IsHeart && !IsCross && !IsRing && !IsPath || !IsRectangle && !IsCircle && !IsEllipse && !IsLine && !IsPolygon && !IsStar && IsArrow && !IsHeart && !IsCross && !IsRing && !IsPath || !IsRectangle && !IsCircle && !IsEllipse && !IsLine && !IsPolygon && !IsStar && !IsArrow && IsHeart && !IsCross && !IsRing && !IsPath || !IsRectangle && !IsCircle && !IsEllipse && !IsLine && !IsPolygon && !IsStar && !IsArrow && !IsHeart && IsCross && !IsRing && !IsPath || !IsRectangle && !IsCircle && !IsEllipse && !IsLine && !IsPolygon && !IsStar && !IsArrow && !IsHeart && !IsCross && IsRing && !IsPath || !IsRectangle && !IsCircle && !IsEllipse && !IsLine && !IsPolygon && !IsStar && !IsArrow && !IsHeart && !IsCross && !IsRing && IsPath;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.SvgRectangleShape, TResult>? rectangle = null,
            global::System.Func<global::G.SvgCircleShape, TResult>? circle = null,
            global::System.Func<global::G.SvgEllipseShape, TResult>? ellipse = null,
            global::System.Func<global::G.SvgLineShape, TResult>? line = null,
            global::System.Func<global::G.SvgPolygonShape, TResult>? polygon = null,
            global::System.Func<global::G.SvgStarShape, TResult>? star = null,
            global::System.Func<global::G.SvgArrowShape, TResult>? arrow = null,
            global::System.Func<global::G.SvgHeartShape, TResult>? heart = null,
            global::System.Func<global::G.SvgCrossShape, TResult>? cross = null,
            global::System.Func<global::G.SvgRingShape, TResult>? ring = null,
            global::System.Func<global::G.SvgPathShape, TResult>? path = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRectangle && rectangle != null)
            {
                return rectangle(Rectangle!);
            }
            else if (IsCircle && circle != null)
            {
                return circle(Circle!);
            }
            else if (IsEllipse && ellipse != null)
            {
                return ellipse(Ellipse!);
            }
            else if (IsLine && line != null)
            {
                return line(Line!);
            }
            else if (IsPolygon && polygon != null)
            {
                return polygon(Polygon!);
            }
            else if (IsStar && star != null)
            {
                return star(Star!);
            }
            else if (IsArrow && arrow != null)
            {
                return arrow(Arrow!);
            }
            else if (IsHeart && heart != null)
            {
                return heart(Heart!);
            }
            else if (IsCross && cross != null)
            {
                return cross(Cross!);
            }
            else if (IsRing && ring != null)
            {
                return ring(Ring!);
            }
            else if (IsPath && path != null)
            {
                return path(Path!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.SvgRectangleShape>? rectangle = null,

            global::System.Action<global::G.SvgCircleShape>? circle = null,

            global::System.Action<global::G.SvgEllipseShape>? ellipse = null,

            global::System.Action<global::G.SvgLineShape>? line = null,

            global::System.Action<global::G.SvgPolygonShape>? polygon = null,

            global::System.Action<global::G.SvgStarShape>? star = null,

            global::System.Action<global::G.SvgArrowShape>? arrow = null,

            global::System.Action<global::G.SvgHeartShape>? heart = null,

            global::System.Action<global::G.SvgCrossShape>? cross = null,

            global::System.Action<global::G.SvgRingShape>? ring = null,

            global::System.Action<global::G.SvgPathShape>? path = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRectangle)
            {
                rectangle?.Invoke(Rectangle!);
            }
            else if (IsCircle)
            {
                circle?.Invoke(Circle!);
            }
            else if (IsEllipse)
            {
                ellipse?.Invoke(Ellipse!);
            }
            else if (IsLine)
            {
                line?.Invoke(Line!);
            }
            else if (IsPolygon)
            {
                polygon?.Invoke(Polygon!);
            }
            else if (IsStar)
            {
                star?.Invoke(Star!);
            }
            else if (IsArrow)
            {
                arrow?.Invoke(Arrow!);
            }
            else if (IsHeart)
            {
                heart?.Invoke(Heart!);
            }
            else if (IsCross)
            {
                cross?.Invoke(Cross!);
            }
            else if (IsRing)
            {
                ring?.Invoke(Ring!);
            }
            else if (IsPath)
            {
                path?.Invoke(Path!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::G.SvgRectangleShape>? rectangle = null,
            global::System.Action<global::G.SvgCircleShape>? circle = null,
            global::System.Action<global::G.SvgEllipseShape>? ellipse = null,
            global::System.Action<global::G.SvgLineShape>? line = null,
            global::System.Action<global::G.SvgPolygonShape>? polygon = null,
            global::System.Action<global::G.SvgStarShape>? star = null,
            global::System.Action<global::G.SvgArrowShape>? arrow = null,
            global::System.Action<global::G.SvgHeartShape>? heart = null,
            global::System.Action<global::G.SvgCrossShape>? cross = null,
            global::System.Action<global::G.SvgRingShape>? ring = null,
            global::System.Action<global::G.SvgPathShape>? path = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRectangle)
            {
                rectangle?.Invoke(Rectangle!);
            }
            else if (IsCircle)
            {
                circle?.Invoke(Circle!);
            }
            else if (IsEllipse)
            {
                ellipse?.Invoke(Ellipse!);
            }
            else if (IsLine)
            {
                line?.Invoke(Line!);
            }
            else if (IsPolygon)
            {
                polygon?.Invoke(Polygon!);
            }
            else if (IsStar)
            {
                star?.Invoke(Star!);
            }
            else if (IsArrow)
            {
                arrow?.Invoke(Arrow!);
            }
            else if (IsHeart)
            {
                heart?.Invoke(Heart!);
            }
            else if (IsCross)
            {
                cross?.Invoke(Cross!);
            }
            else if (IsRing)
            {
                ring?.Invoke(Ring!);
            }
            else if (IsPath)
            {
                path?.Invoke(Path!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Rectangle,
                typeof(global::G.SvgRectangleShape),
                Circle,
                typeof(global::G.SvgCircleShape),
                Ellipse,
                typeof(global::G.SvgEllipseShape),
                Line,
                typeof(global::G.SvgLineShape),
                Polygon,
                typeof(global::G.SvgPolygonShape),
                Star,
                typeof(global::G.SvgStarShape),
                Arrow,
                typeof(global::G.SvgArrowShape),
                Heart,
                typeof(global::G.SvgHeartShape),
                Cross,
                typeof(global::G.SvgCrossShape),
                Ring,
                typeof(global::G.SvgRingShape),
                Path,
                typeof(global::G.SvgPathShape),
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
        public bool Equals(SvgShape other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.SvgRectangleShape?>.Default.Equals(Rectangle, other.Rectangle) &&
                global::System.Collections.Generic.EqualityComparer<global::G.SvgCircleShape?>.Default.Equals(Circle, other.Circle) &&
                global::System.Collections.Generic.EqualityComparer<global::G.SvgEllipseShape?>.Default.Equals(Ellipse, other.Ellipse) &&
                global::System.Collections.Generic.EqualityComparer<global::G.SvgLineShape?>.Default.Equals(Line, other.Line) &&
                global::System.Collections.Generic.EqualityComparer<global::G.SvgPolygonShape?>.Default.Equals(Polygon, other.Polygon) &&
                global::System.Collections.Generic.EqualityComparer<global::G.SvgStarShape?>.Default.Equals(Star, other.Star) &&
                global::System.Collections.Generic.EqualityComparer<global::G.SvgArrowShape?>.Default.Equals(Arrow, other.Arrow) &&
                global::System.Collections.Generic.EqualityComparer<global::G.SvgHeartShape?>.Default.Equals(Heart, other.Heart) &&
                global::System.Collections.Generic.EqualityComparer<global::G.SvgCrossShape?>.Default.Equals(Cross, other.Cross) &&
                global::System.Collections.Generic.EqualityComparer<global::G.SvgRingShape?>.Default.Equals(Ring, other.Ring) &&
                global::System.Collections.Generic.EqualityComparer<global::G.SvgPathShape?>.Default.Equals(Path, other.Path) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SvgShape obj1, SvgShape obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SvgShape>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SvgShape obj1, SvgShape obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SvgShape o && Equals(o);
        }
    }
}
