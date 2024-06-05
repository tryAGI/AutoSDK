//HintName: G.Models.DeleteFileResponseObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DeleteFileResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        File,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeleteFileResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteFileResponseObject value)
        {
            return value switch
            {
                DeleteFileResponseObject.File => "file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteFileResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "file" => DeleteFileResponseObject.File,
                _ => null,
            };
        }
    }
}