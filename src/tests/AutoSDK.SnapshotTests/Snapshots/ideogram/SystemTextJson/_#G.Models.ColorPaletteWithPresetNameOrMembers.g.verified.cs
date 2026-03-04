//HintName: G.Models.ColorPaletteWithPresetNameOrMembers.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// A color palette for generation, must EITHER be specified via one of the presets (name) or explicitly via hexadecimal representations of the color with optional weights (members).
    /// </summary>
    public readonly partial struct ColorPaletteWithPresetNameOrMembers : global::System.IEquatable<ColorPaletteWithPresetNameOrMembers>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ColorPaletteWithPresetName? ColorPaletteWithPresetName { get; init; }
#else
        public global::G.ColorPaletteWithPresetName? ColorPaletteWithPresetName { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ColorPaletteWithPresetName))]
#endif
        public bool IsColorPaletteWithPresetName => ColorPaletteWithPresetName != null;

        /// <summary>
        /// A color palette represented only via its members
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ColorPaletteWithMembers? ColorPaletteWithMembers { get; init; }
#else
        public global::G.ColorPaletteWithMembers? ColorPaletteWithMembers { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ColorPaletteWithMembers))]
#endif
        public bool IsColorPaletteWithMembers => ColorPaletteWithMembers != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ColorPaletteWithPresetNameOrMembers(global::G.ColorPaletteWithPresetName value) => new ColorPaletteWithPresetNameOrMembers((global::G.ColorPaletteWithPresetName?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ColorPaletteWithPresetName?(ColorPaletteWithPresetNameOrMembers @this) => @this.ColorPaletteWithPresetName;

        /// <summary>
        /// 
        /// </summary>
        public ColorPaletteWithPresetNameOrMembers(global::G.ColorPaletteWithPresetName? value)
        {
            ColorPaletteWithPresetName = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ColorPaletteWithPresetNameOrMembers(global::G.ColorPaletteWithMembers value) => new ColorPaletteWithPresetNameOrMembers((global::G.ColorPaletteWithMembers?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ColorPaletteWithMembers?(ColorPaletteWithPresetNameOrMembers @this) => @this.ColorPaletteWithMembers;

        /// <summary>
        /// 
        /// </summary>
        public ColorPaletteWithPresetNameOrMembers(global::G.ColorPaletteWithMembers? value)
        {
            ColorPaletteWithMembers = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ColorPaletteWithPresetNameOrMembers(
            global::G.ColorPaletteWithPresetName? colorPaletteWithPresetName,
            global::G.ColorPaletteWithMembers? colorPaletteWithMembers
            )
        {
            ColorPaletteWithPresetName = colorPaletteWithPresetName;
            ColorPaletteWithMembers = colorPaletteWithMembers;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ColorPaletteWithMembers as object ??
            ColorPaletteWithPresetName as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ColorPaletteWithPresetName?.ToString() ??
            ColorPaletteWithMembers?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsColorPaletteWithPresetName && !IsColorPaletteWithMembers || !IsColorPaletteWithPresetName && IsColorPaletteWithMembers;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ColorPaletteWithPresetName?, TResult>? colorPaletteWithPresetName = null,
            global::System.Func<global::G.ColorPaletteWithMembers?, TResult>? colorPaletteWithMembers = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsColorPaletteWithPresetName && colorPaletteWithPresetName != null)
            {
                return colorPaletteWithPresetName(ColorPaletteWithPresetName!);
            }
            else if (IsColorPaletteWithMembers && colorPaletteWithMembers != null)
            {
                return colorPaletteWithMembers(ColorPaletteWithMembers!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ColorPaletteWithPresetName?>? colorPaletteWithPresetName = null,
            global::System.Action<global::G.ColorPaletteWithMembers?>? colorPaletteWithMembers = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsColorPaletteWithPresetName)
            {
                colorPaletteWithPresetName?.Invoke(ColorPaletteWithPresetName!);
            }
            else if (IsColorPaletteWithMembers)
            {
                colorPaletteWithMembers?.Invoke(ColorPaletteWithMembers!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ColorPaletteWithPresetName,
                typeof(global::G.ColorPaletteWithPresetName),
                ColorPaletteWithMembers,
                typeof(global::G.ColorPaletteWithMembers),
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
        public bool Equals(ColorPaletteWithPresetNameOrMembers other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ColorPaletteWithPresetName?>.Default.Equals(ColorPaletteWithPresetName, other.ColorPaletteWithPresetName) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ColorPaletteWithMembers?>.Default.Equals(ColorPaletteWithMembers, other.ColorPaletteWithMembers) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ColorPaletteWithPresetNameOrMembers obj1, ColorPaletteWithPresetNameOrMembers obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ColorPaletteWithPresetNameOrMembers>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ColorPaletteWithPresetNameOrMembers obj1, ColorPaletteWithPresetNameOrMembers obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ColorPaletteWithPresetNameOrMembers o && Equals(o);
        }
    }
}
