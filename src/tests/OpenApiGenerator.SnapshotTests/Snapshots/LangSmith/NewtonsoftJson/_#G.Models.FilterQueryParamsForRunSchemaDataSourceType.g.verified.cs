//HintName: G.Models.FilterQueryParamsForRunSchemaDataSourceType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enum for run data source types.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FilterQueryParamsForRunSchemaDataSourceType
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
    public static class FilterQueryParamsForRunSchemaDataSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilterQueryParamsForRunSchemaDataSourceType value)
        {
            return value switch
            {
                FilterQueryParamsForRunSchemaDataSourceType.Current => "current",
                FilterQueryParamsForRunSchemaDataSourceType.Historical => "historical",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FilterQueryParamsForRunSchemaDataSourceType? ToEnum(string value)
        {
            return value switch
            {
                "current" => FilterQueryParamsForRunSchemaDataSourceType.Current,
                "historical" => FilterQueryParamsForRunSchemaDataSourceType.Historical,
                _ => null,
            };
        }
    }
}