//HintName: G.Models.StoreEventListResponseDataItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum StoreEventListResponseDataItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Ingestion,
        /// <summary>
        /// 
        /// </summary>
        Search,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StoreEventListResponseDataItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StoreEventListResponseDataItemDiscriminatorType value)
        {
            return value switch
            {
                StoreEventListResponseDataItemDiscriminatorType.Ingestion => "ingestion",
                StoreEventListResponseDataItemDiscriminatorType.Search => "search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StoreEventListResponseDataItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "ingestion" => StoreEventListResponseDataItemDiscriminatorType.Ingestion,
                "search" => StoreEventListResponseDataItemDiscriminatorType.Search,
                _ => null,
            };
        }
    }
}