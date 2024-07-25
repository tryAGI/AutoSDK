//HintName: G.Models.BodyParamsForRunSchemaDataSourceType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enum for run data source types.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BodyParamsForRunSchemaDataSourceType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="current")]
        Current,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="historical")]
        Historical,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BodyParamsForRunSchemaDataSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyParamsForRunSchemaDataSourceType value)
        {
            return value switch
            {
                BodyParamsForRunSchemaDataSourceType.Current => "current",
                BodyParamsForRunSchemaDataSourceType.Historical => "historical",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyParamsForRunSchemaDataSourceType? ToEnum(string value)
        {
            return value switch
            {
                "current" => BodyParamsForRunSchemaDataSourceType.Current,
                "historical" => BodyParamsForRunSchemaDataSourceType.Historical,
                _ => null,
            };
        }
    }
}