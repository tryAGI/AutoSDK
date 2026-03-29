//HintName: G.Models.DatasetPublicVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DatasetPublicVisibility
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
    public static class DatasetPublicVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DatasetPublicVisibility value)
        {
            return value switch
            {
                DatasetPublicVisibility.Private => "private",
                DatasetPublicVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DatasetPublicVisibility? ToEnum(string value)
        {
            return value switch
            {
                "private" => DatasetPublicVisibility.Private,
                "public" => DatasetPublicVisibility.Public,
                _ => null,
            };
        }
    }
}