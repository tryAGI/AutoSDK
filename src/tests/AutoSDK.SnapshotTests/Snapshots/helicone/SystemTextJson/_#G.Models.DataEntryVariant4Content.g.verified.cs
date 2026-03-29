//HintName: G.Models.DataEntryVariant4Content.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DataEntryVariant4Content
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
    public static class DataEntryVariant4ContentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DataEntryVariant4Content value)
        {
            return value switch
            {
                DataEntryVariant4Content.Jsonify => "jsonify",
                DataEntryVariant4Content.Message => "message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DataEntryVariant4Content? ToEnum(string value)
        {
            return value switch
            {
                "jsonify" => DataEntryVariant4Content.Jsonify,
                "message" => DataEntryVariant4Content.Message,
                _ => null,
            };
        }
    }
}