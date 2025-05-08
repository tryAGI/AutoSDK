//HintName: G.Models.EvalCustomDataSourceConfigType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of data source. Always `custom`.<br/>
    /// Default Value: custom
    /// </summary>
    public enum EvalCustomDataSourceConfigType
    {
        /// <summary>
        /// 
        /// </summary>
        Custom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvalCustomDataSourceConfigTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvalCustomDataSourceConfigType value)
        {
            return value switch
            {
                EvalCustomDataSourceConfigType.Custom => "custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvalCustomDataSourceConfigType? ToEnum(string value)
        {
            return value switch
            {
                "custom" => EvalCustomDataSourceConfigType.Custom,
                _ => null,
            };
        }
    }
}