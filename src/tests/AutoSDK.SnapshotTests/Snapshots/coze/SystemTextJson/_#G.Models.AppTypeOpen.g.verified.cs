//HintName: G.Models.AppTypeOpen.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppTypeOpen
    {
        /// <summary>
        /// 
        /// </summary>
        Connector,
        /// <summary>
        /// 
        /// </summary>
        Normal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppTypeOpenExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppTypeOpen value)
        {
            return value switch
            {
                AppTypeOpen.Connector => "connector",
                AppTypeOpen.Normal => "normal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppTypeOpen? ToEnum(string value)
        {
            return value switch
            {
                "connector" => AppTypeOpen.Connector,
                "normal" => AppTypeOpen.Normal,
                _ => null,
            };
        }
    }
}