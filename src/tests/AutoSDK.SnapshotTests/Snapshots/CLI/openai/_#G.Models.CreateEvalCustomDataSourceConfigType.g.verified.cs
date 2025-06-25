//HintName: G.Models.CreateEvalCustomDataSourceConfigType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of data source. Always `custom`.<br/>
    /// Default Value: custom
    /// </summary>
    public enum CreateEvalCustomDataSourceConfigType
    {
        /// <summary>
        /// 
        /// </summary>
        Custom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateEvalCustomDataSourceConfigTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateEvalCustomDataSourceConfigType value)
        {
            return value switch
            {
                CreateEvalCustomDataSourceConfigType.Custom => "custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateEvalCustomDataSourceConfigType? ToEnum(string value)
        {
            return value switch
            {
                "custom" => CreateEvalCustomDataSourceConfigType.Custom,
                _ => null,
            };
        }
    }
}