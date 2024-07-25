//HintName: G.Models.RunsFilterDataSourceTypeEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enum for run data source types.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RunsFilterDataSourceTypeEnum
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
    public static class RunsFilterDataSourceTypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunsFilterDataSourceTypeEnum value)
        {
            return value switch
            {
                RunsFilterDataSourceTypeEnum.Current => "current",
                RunsFilterDataSourceTypeEnum.Historical => "historical",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunsFilterDataSourceTypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "current" => RunsFilterDataSourceTypeEnum.Current,
                "historical" => RunsFilterDataSourceTypeEnum.Historical,
                _ => null,
            };
        }
    }
}