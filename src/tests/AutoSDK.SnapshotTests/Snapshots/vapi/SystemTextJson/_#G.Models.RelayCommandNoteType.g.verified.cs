//HintName: G.Models.RelayCommandNoteType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of relay command
    /// </summary>
    public enum RelayCommandNoteType
    {
        /// <summary>
        /// 
        /// </summary>
        MessageAdd,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RelayCommandNoteTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RelayCommandNoteType value)
        {
            return value switch
            {
                RelayCommandNoteType.MessageAdd => "message.add",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RelayCommandNoteType? ToEnum(string value)
        {
            return value switch
            {
                "message.add" => RelayCommandNoteType.MessageAdd,
                _ => null,
            };
        }
    }
}