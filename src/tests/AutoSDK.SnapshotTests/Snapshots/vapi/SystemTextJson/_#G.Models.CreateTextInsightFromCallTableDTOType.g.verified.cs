//HintName: G.Models.CreateTextInsightFromCallTableDTOType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the Insight.<br/>
    /// It is required to be `text` to create a text insight.
    /// </summary>
    public enum CreateTextInsightFromCallTableDTOType
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTextInsightFromCallTableDTOTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextInsightFromCallTableDTOType value)
        {
            return value switch
            {
                CreateTextInsightFromCallTableDTOType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextInsightFromCallTableDTOType? ToEnum(string value)
        {
            return value switch
            {
                "text" => CreateTextInsightFromCallTableDTOType.Text,
                _ => null,
            };
        }
    }
}