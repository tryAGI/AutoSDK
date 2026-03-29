//HintName: G.Models.GetDatasetRowsResponseRowItemType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetDatasetRowsResponseRowItemType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dataset")]
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