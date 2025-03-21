//HintName: G.Models.ResponseModalitiesTextOnlyItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseModalitiesTextOnlyItem
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseModalitiesTextOnlyItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseModalitiesTextOnlyItem value)
        {
            return value switch
            {
                ResponseModalitiesTextOnlyItem.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseModalitiesTextOnlyItem? ToEnum(string value)
        {
            return value switch
            {
                "text" => ResponseModalitiesTextOnlyItem.Text,
                _ => null,
            };
        }
    }
}