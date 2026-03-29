//HintName: G.Models.DataEntryVariant3Content.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DataEntryVariant3Content
    {
        /// <summary>
        /// 
        /// </summary>
        Jsonify,
        /// <summary>
        /// 
        /// </summary>
        Message,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DataEntryVariant3ContentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DataEntryVariant3Content value)
        {
            return value switch
            {
                DataEntryVariant3Content.Jsonify => "jsonify",
                DataEntryVariant3Content.Message => "message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DataEntryVariant3Content? ToEnum(string value)
        {
            return value switch
            {
                "jsonify" => DataEntryVariant3Content.Jsonify,
                "message" => DataEntryVariant3Content.Message,
                _ => null,
            };
        }
    }
}