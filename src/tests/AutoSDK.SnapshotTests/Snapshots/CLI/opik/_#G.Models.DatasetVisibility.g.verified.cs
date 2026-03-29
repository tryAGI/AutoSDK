//HintName: G.Models.DatasetVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DatasetVisibility
    {
        /// <summary>
        /// 
        /// </summary>
        Private,
        /// <summary>
        /// 
        /// </summary>
        Public,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DatasetVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DatasetVisibility value)
        {
            return value switch
            {
                DatasetVisibility.Private => "private",
                DatasetVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DatasetVisibility? ToEnum(string value)
        {
            return value switch
            {
                "private" => DatasetVisibility.Private,
                "public" => DatasetVisibility.Public,
                _ => null,
            };
        }
    }
}