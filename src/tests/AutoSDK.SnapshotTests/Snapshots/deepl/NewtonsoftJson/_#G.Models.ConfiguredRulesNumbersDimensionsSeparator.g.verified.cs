//HintName: G.Models.ConfiguredRulesNumbersDimensionsSeparator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Dimensions Separator
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesNumbersDimensionsSeparator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_multiplication_sign_between_dimensions_with_space_on_either_side")]
        UseMultiplicationSignBetweenDimensionsWithSpaceOnEitherSide,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_multiplication_sign_between_dimensions_without_space_on_either_side")]
        UseMultiplicationSignBetweenDimensionsWithoutSpaceOnEitherSide,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_x_between_dimensions_with_space_on_either_side")]
        UseXBetweenDimensionsWithSpaceOnEitherSide,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_x_between_dimensions_without_space_on_either_side")]
        UseXBetweenDimensionsWithoutSpaceOnEitherSide,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesNumbersDimensionsSeparatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesNumbersDimensionsSeparator value)
        {
            return value switch
            {
                ConfiguredRulesNumbersDimensionsSeparator.UseMultiplicationSignBetweenDimensionsWithSpaceOnEitherSide => "use_multiplication_sign_between_dimensions_with_space_on_either_side",
                ConfiguredRulesNumbersDimensionsSeparator.UseMultiplicationSignBetweenDimensionsWithoutSpaceOnEitherSide => "use_multiplication_sign_between_dimensions_without_space_on_either_side",
                ConfiguredRulesNumbersDimensionsSeparator.UseXBetweenDimensionsWithSpaceOnEitherSide => "use_x_between_dimensions_with_space_on_either_side",
                ConfiguredRulesNumbersDimensionsSeparator.UseXBetweenDimensionsWithoutSpaceOnEitherSide => "use_x_between_dimensions_without_space_on_either_side",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesNumbersDimensionsSeparator? ToEnum(string value)
        {
            return value switch
            {
                "use_multiplication_sign_between_dimensions_with_space_on_either_side" => ConfiguredRulesNumbersDimensionsSeparator.UseMultiplicationSignBetweenDimensionsWithSpaceOnEitherSide,
                "use_multiplication_sign_between_dimensions_without_space_on_either_side" => ConfiguredRulesNumbersDimensionsSeparator.UseMultiplicationSignBetweenDimensionsWithoutSpaceOnEitherSide,
                "use_x_between_dimensions_with_space_on_either_side" => ConfiguredRulesNumbersDimensionsSeparator.UseXBetweenDimensionsWithSpaceOnEitherSide,
                "use_x_between_dimensions_without_space_on_either_side" => ConfiguredRulesNumbersDimensionsSeparator.UseXBetweenDimensionsWithoutSpaceOnEitherSide,
                _ => null,
            };
        }
    }
}