//HintName: G.Models.GetDatasetRowsResponseRowItemType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDatasetRowsResponseRowItemType
    {
        /// <summary>
        /// 
        /// </summary>
        Dataset,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDatasetRowsResponseRowItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDatasetRowsResponseRowItemType value)
        {
            return value switch
            {
                GetDatasetRowsResponseRowItemType.Dataset => "dataset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDatasetRowsResponseRowItemType? ToEnum(string value)
        {
            return value switch
            {
                "dataset" => GetDatasetRowsResponseRowItemType.Dataset,
                _ => null,
            };
        }
    }
}