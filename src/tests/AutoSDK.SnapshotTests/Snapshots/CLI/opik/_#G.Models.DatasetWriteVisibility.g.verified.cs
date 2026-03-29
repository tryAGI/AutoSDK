//HintName: G.Models.DatasetWriteVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DatasetWriteVisibility
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
    public static class DatasetWriteVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DatasetWriteVisibility value)
        {
            return value switch
            {
                DatasetWriteVisibility.Private => "private",
                DatasetWriteVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DatasetWriteVisibility? ToEnum(string value)
        {
            return value switch
            {
                "private" => DatasetWriteVisibility.Private,
                "public" => DatasetWriteVisibility.Public,
                _ => null,
            };
        }
    }
}