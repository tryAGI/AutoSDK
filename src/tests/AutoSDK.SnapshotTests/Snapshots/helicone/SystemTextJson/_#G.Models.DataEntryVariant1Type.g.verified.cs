//HintName: G.Models.DataEntryVariant1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DataEntryVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        SystemPrompt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DataEntryVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DataEntryVariant1Type value)
        {
            return value switch
            {
                DataEntryVariant1Type.SystemPrompt => "system-prompt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DataEntryVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "system-prompt" => DataEntryVariant1Type.SystemPrompt,
                _ => null,
            };
        }
    }
}