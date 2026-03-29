//HintName: G.Models.TargetName.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TargetName
    {
        /// <summary>
        /// 
        /// </summary>
        Inbody,
        /// <summary>
        /// 
        /// </summary>
        Zip,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TargetNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TargetName value)
        {
            return value switch
            {
                TargetName.Inbody => "inbody",
                TargetName.Zip => "zip",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TargetName? ToEnum(string value)
        {
            return value switch
            {
                "inbody" => TargetName.Inbody,
                "zip" => TargetName.Zip,
                _ => null,
            };
        }
    }
}