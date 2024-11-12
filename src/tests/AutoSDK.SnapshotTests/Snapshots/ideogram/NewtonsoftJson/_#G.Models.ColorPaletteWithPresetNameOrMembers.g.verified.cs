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
        public global::G.ColorPaletteWithPresetName? Value1 { get; init; }
#else
        public global::G.ColorPaletteWithPresetName? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ColorPaletteWithPresetNameOrMembers(global::G.ColorPaletteWithPresetName value) => new ColorPaletteWithPresetNameOrMembers(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ColorPaletteWithPresetName?(ColorPaletteWithPresetNameOrMembers @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public ColorPaletteWithPresetNameOrMembers(global::G.ColorPaletteWithPresetName? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// A color palette represented only via its members
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ColorPaletteWithMembers? Value2 { get; init; }
#else
        public global::G.ColorPaletteWithMembers? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ColorPaletteWithPresetNameOrMembers(global::G.ColorPaletteWithMembers value) => new ColorPaletteWithPresetNameOrMembers(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ColorPaletteWithMembers?(ColorPaletteWithPresetNameOrMembers @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public ColorPaletteWithPresetNameOrMembers(global::G.ColorPaletteWithMembers? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ColorPaletteWithPresetNameOrMembers(
            global::G.ColorPaletteWithPresetName? value1,
            global::G.ColorPaletteWithMembers? value2
            )
        {
            Value1 = value1;
            Value2 = value2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && !IsValue2 || !IsValue1 && IsValue2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ColorPaletteWithPresetName?, TResult>? value1 = null,
            global::System.Func<global::G.ColorPaletteWithMembers?, TResult>? value2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1 && value1 != null)
            {
                return value1(Value1!);
            }
            else if (IsValue2 && value2 != null)
            {
                return value2(Value2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ColorPaletteWithPresetName?>? value1 = null,
            global::System.Action<global::G.ColorPaletteWithMembers?>? value2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1)
            {
                value1?.Invoke(Value1!);
            }
            else if (IsValue2)
            {
                value2?.Invoke(Value2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(global::G.ColorPaletteWithPresetName),
                Value2,
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
                global::System.Collections.Generic.EqualityComparer<global::G.ColorPaletteWithPresetName?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ColorPaletteWithMembers?>.Default.Equals(Value2, other.Value2) 
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
