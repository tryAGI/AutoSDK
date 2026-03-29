//HintName: G.Models.DataEntryVariant2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DataEntryVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        PromptInput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DataEntryVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DataEntryVariant2Type value)
        {
            return value switch
            {
                DataEntryVariant2Type.PromptInput => "prompt-input",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DataEntryVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "prompt-input" => DataEntryVariant2Type.PromptInput,
                _ => null,
            };
        }
    }
}