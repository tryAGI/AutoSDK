//HintName: G.Models.CollectionStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Current state of the collection. `Green` - all good. `Yellow` - optimization is running, 'Grey' - optimizations are possible but not triggered, `Red` - some operations failed and was not recovered
    /// </summary>
    public enum CollectionStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Green,
        /// <summary>
        /// 
        /// </summary>
        Grey,
        /// <summary>
        /// 
        /// </summary>
        Red,
        /// <summary>
        /// 
        /// </summary>
        Yellow,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CollectionStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CollectionStatus value)
        {
            return value switch
            {
                CollectionStatus.Green => "green",
                CollectionStatus.Grey => "grey",
                CollectionStatus.Red => "red",
                CollectionStatus.Yellow => "yellow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CollectionStatus? ToEnum(string value)
        {
            return value switch
            {
                "green" => CollectionStatus.Green,
                "grey" => CollectionStatus.Grey,
                "red" => CollectionStatus.Red,
                "yellow" => CollectionStatus.Yellow,
                _ => null,
            };
        }
    }
}