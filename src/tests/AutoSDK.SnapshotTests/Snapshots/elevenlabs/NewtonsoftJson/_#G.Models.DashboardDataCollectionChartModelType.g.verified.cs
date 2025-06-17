//HintName: G.Models.DashboardDataCollectionChartModelType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: data_collection
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DashboardDataCollectionChartModelType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="data_collection")]
        DataCollection,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DashboardDataCollectionChartModelTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DashboardDataCollectionChartModelType value)
        {
            return value switch
            {
                DashboardDataCollectionChartModelType.DataCollection => "data_collection",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DashboardDataCollectionChartModelType? ToEnum(string value)
        {
            return value switch
            {
                "data_collection" => DashboardDataCollectionChartModelType.DataCollection,
                _ => null,
            };
        }
    }
}