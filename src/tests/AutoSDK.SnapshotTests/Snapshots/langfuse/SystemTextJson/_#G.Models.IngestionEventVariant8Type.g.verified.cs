//HintName: G.Models.IngestionEventVariant8Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum IngestionEventVariant8Type
    {
        /// <summary>
        /// 
        /// </summary>
        SdkLog,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IngestionEventVariant8TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IngestionEventVariant8Type value)
        {
            return value switch
            {
                IngestionEventVariant8Type.SdkLog => "sdk-log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IngestionEventVariant8Type? ToEnum(string value)
        {
            return value switch
            {
                "sdk-log" => IngestionEventVariant8Type.SdkLog,
                _ => null,
            };
        }
    }
}